using ILRuntime.Runtime.Enviorment;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;

namespace Trinity
{
    /// <summary>
    /// 热更新层UGUI Item
    /// </summary>
    public class HotfixUGuiItem : UGuiItem
    {
        /// <summary>
        /// 对应的热更新层UGUI Item类名
        /// </summary>
        [SerializeField]
        private string m_HotfixUGuiItemName;

        /// <summary>
        /// 对应的热更新层实体逻辑类实例
        /// </summary>
        private object m_HotfixInstance;

        //热更新层的方法缓存
        private ILInstanceMethod m_OnRecycle;
        private ILInstanceMethod m_OnShow;
        private ILInstanceMethod m_OnHide;
        private IMethod m_OnUpdate;

        public void OnHotfixInit(string hotfixUGuiItemName,object userData = null)
        {
            if (string.IsNullOrEmpty(m_HotfixUGuiItemName))
            {
                m_HotfixUGuiItemName = hotfixUGuiItemName;
                OnInit(userData);
                OnShow(userData);
                Item.Logic = this;
            }
        }

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);

            string hotfixUGuiFormFullName = Utility.Text.Format("{0}.{1}", "Trinity.Hotfix", m_HotfixUGuiItemName);

            //获取热更新层的实例
            IType type = GameEntry.ILRuntime.AppDomain.LoadedTypes[hotfixUGuiFormFullName];
            m_HotfixInstance = ((ILType)type).Instantiate();

            //获取热更新层的方法并缓存
            m_OnRecycle = new ILInstanceMethod(m_HotfixInstance, hotfixUGuiFormFullName, "OnRecycle", 1);
            m_OnShow = new ILInstanceMethod(m_HotfixInstance, hotfixUGuiFormFullName, "OnShow", 0);
            m_OnHide = new ILInstanceMethod(m_HotfixInstance, hotfixUGuiFormFullName, "OnHide ", 0);
            m_OnUpdate = type.GetMethod("OnUpdate", 2);

            //调用热更新层的OnInit
            GameEntry.ILRuntime.AppDomain.Invoke(hotfixUGuiFormFullName, "OnInit", m_HotfixInstance, this, userData);
        }

        protected override void OnRecycle()
        {
            base.OnRecycle();

            m_OnRecycle?.Invoke();
        }

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);

            m_OnShow?.Invoke(userData);
        }

        protected override void OnHide(bool isShutdown, object userData)
        {
            base.OnHide(isShutdown,userData);

            m_OnHide?.Invoke(isShutdown, userData);
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);

            using (var ctx = GameEntry.ILRuntime.AppDomain.BeginInvoke(m_OnUpdate))
            {
                ctx.PushObject(m_HotfixInstance);
                ctx.PushFloat(elapseSeconds);
                ctx.PushFloat(realElapseSeconds);
                ctx.Invoke();
            }
        }
    }
}
