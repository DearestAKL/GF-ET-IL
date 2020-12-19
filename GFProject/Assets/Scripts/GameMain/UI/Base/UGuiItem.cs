using GameFramework;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

namespace Trinity
{
    public abstract class UGuiItem : ItemLogic
    {

#if UNITY_2017_3_OR_NEWER
        protected override void OnInit(object userData)
#else
    protected internal override void OnInit(object userData)
#endif
        {
            base.OnInit(userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnRecycle()
#else
    protected internal override void OnRecycle()
#endif
        {
            base.OnRecycle();
        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnShow(object userData)
#else
    protected internal override void OnShow(object userData)
#endif
        {
            base.OnShow(userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnHide(bool isShutdown, object userData)
#else
    protected internal override void OnHide(object userData)
#endif
        {
            base.OnHide(isShutdown, userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
#else
    protected internal override void  OnUpdate(float elapseSeconds, float realElapseSeconds)
#endif
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }

#if UNITY_2017_3_OR_NEWER
        protected override void InternalSetVisible(bool visible)
#else
    protected internal override void InternalSetVisible(bool visible)
#endif
        {
            base.InternalSetVisible(visible);
        }
    }
}
