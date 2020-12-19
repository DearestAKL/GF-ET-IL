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
    public class HotfixFancyCell: FancyCell<ItemData>
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

        public override void UpdateContent(ItemData itemData)
        {
            throw new System.NotImplementedException();
        }

        public override void UpdatePosition(float position)
        {
            throw new System.NotImplementedException();
        }
    }
}