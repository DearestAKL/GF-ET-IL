using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FancyScrollView;

namespace Trinity.Hotfix
{
    public class HotfixFancyCell
    {
        protected FancyCell<ItemData, HotfixUGuiItem> FancyCell
        {
            get;
            private set;
        }

        public virtual void Initialize(FancyCell<ItemData, HotfixUGuiItem> fancyCell)
        {
            FancyCell = fancyCell;
        }

        public virtual void SetContext(HotfixUGuiItem item)
        {

        }

        public virtual void SetVisble(bool visible)
        {

        }

        public virtual void UpdateContent(ItemData itemData)
        {

        }

        public virtual void UpdatePosition(float position)
        {

        }
    }
}
