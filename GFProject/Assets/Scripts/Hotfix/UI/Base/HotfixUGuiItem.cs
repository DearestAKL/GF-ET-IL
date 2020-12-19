using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Trinity;

namespace Trinity.Hotfix
{
    /// <summary>
    /// 热更新层UGU Item
    /// </summary>
    public class HotfixUGuiItem
    {
        protected Trinity.HotfixUGuiItem UIItemLogic
        {
            get;
            private set;
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        public virtual void OnInit(Trinity.HotfixUGuiItem uiFormLogic, object userdata)
        {
            UIItemLogic = uiFormLogic;
        }

        /// <summary>
        /// 物体回收
        /// </summary>
        public virtual void OnRecycle()
        {

        }

        /// <summary>
        /// 物体显示
        /// </summary>
        public virtual void OnShow(object userData)
        {

        }

        /// <summary>
        /// 物体隐藏
        /// </summary>
        public virtual void OnHide(bool isShutdown, object userData)
        {

        }

        /// <summary>
        /// 物体轮询
        /// </summary>
        public virtual void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {

        }
    }
}
