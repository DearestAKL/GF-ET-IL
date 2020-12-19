/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using UnityEngine;

namespace FancyScrollView
{
    /// <summary>
    /// <see cref="FancyScrollView{TItemData, TContext}"/> 在其中实现单元的抽象基类。
    /// <see cref="FancyCell{TItemData, TContext}.Context"/> 如果你不需要。
    /// 可代替 <see cref="FancyCell{TItemData}"/> 使用。
    /// </summary>
    /// <typeparam name="TItemData">项目数据类型。</typeparam>
    /// <typeparam name="TContext"><see cref="Context"/> 类型。</typeparam>
    public abstract class FancyCell<TItemData, TContext> : MonoBehaviour where TContext : class, new()
    {
        /// <summary>
        /// 此单元格中显示的数据索引.
        /// </summary>
        public int Index { get; set; } = -1;

        /// <summary>
        /// 此单元格的可见状态.
        /// </summary>
        public virtual bool IsVisible => gameObject.activeSelf;

        /// <summary>
        /// <see cref="FancyScrollView{TItemData, TContext}.Context"/> 的参考.
        /// 单元格和滚动视图之间共享同一实例，用于传递信息和保存状态。
        /// </summary>
        protected TContext Context { get; private set; }

        /// <summary>
        /// <see cref="Context"/> 设置
        /// </summary>
        /// <param name="context">内容</param>
        public virtual void SetContext(TContext context) => Context = context;

        /// <summary>
        /// 初始化。
        /// </summary>
        public virtual void Initialize() { }

        /// <summary>
        /// 设置此单元格的可见性。
        /// </summary>
        /// <param name="visible">如果可见 <c>true</c>, 如果不可见 <c>false</c>.</param>
        public virtual void SetVisible(bool visible) => gameObject.SetActive(visible);

        /// <summary>
        /// 根据项目数据更新此单元格的显示.
        /// </summary>
        /// <param name="itemData">项目数据.</param>
        public abstract void UpdateContent(TItemData itemData);

        /// <summary>
        /// <c>0.0f</c> ~ <c>1.0f</c> 根据的值更新此单元格的滚动位置。
        /// </summary>
        /// <param name="position">视口范围的标准化滚动位置</param>
        public abstract void UpdatePosition(float position);
    }

    /// <summary>
    /// <see cref="FancyScrollView{TItemData}"/> 在其中实现单元的抽象基类。
    /// </summary>
    /// <typeparam name="TItemData">项目数据类型。</typeparam>
    /// <seealso cref="FancyCell{TItemData, TContext}"/>
    public abstract class FancyCell<TItemData> : FancyCell<TItemData, NullContext>
    {
        /// <inheritdoc/>
        public sealed override void SetContext(NullContext context) => base.SetContext(context);
    }
}
