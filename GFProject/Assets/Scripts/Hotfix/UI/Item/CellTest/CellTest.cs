using FancyScrollView;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//自动生成于：2020/12/19 14:11:39
namespace Trinity.Hotfix
{

	public partial class CellTest : HotfixUGuiItem
	{

		public override void OnInit(Trinity.HotfixUGuiItem uiItemLogic, object userdata)
		{
			base.OnInit(uiItemLogic, userdata);

			GetBindComponents(uiItemLogic.gameObject);
		}
	}
}
