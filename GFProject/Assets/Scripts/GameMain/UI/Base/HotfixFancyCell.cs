using ILRuntime.Runtime.Enviorment;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using FancyScrollView;
using FancyScrollView.Example01;

namespace Trinity
{
    public class HotfixFancyCell<T>: FancyCell<T>
    {
        [SerializeField]
        private string m_HotfixFancyCellName;

        /// <summary>
        /// 对应的热更新层实体逻辑类实例
        /// </summary>
        private object m_HotfixInstance;

        //热更新层的方法缓存
        private ILInstanceMethod m_SetContext;
        private ILInstanceMethod m_SetVisble;
        private ILInstanceMethod m_UpdateContent;
        private ILInstanceMethod m_UpdatePosition;

        public override void Initialize()
        {
            base.Initialize();

            string hotfixFancyCellName = Utility.Text.Format("{0}.{1}", "Trinity.Hotfix", m_HotfixFancyCellName);

            //获取热更新层的实例
            IType type = GameEntry.ILRuntime.AppDomain.LoadedTypes[hotfixFancyCellName];
            m_HotfixInstance = ((ILType)type).Instantiate();

            //获取热更新层的方法并缓存

        }

        public override void SetVisible(bool visible)
        {
            base.SetVisible(visible);
        }

        public override void UpdateContent(T itemData)
        {
            throw new System.NotImplementedException();
        }

        public override void UpdatePosition(float position)
        {
            throw new System.NotImplementedException();
        }
    }
}