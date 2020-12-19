using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//自动生成于：2020/12/19 18:28:08
namespace Trinity.Hotfix
{

	public partial class UILogin : HotfixUGuiForm
	{

		public override void OnInit(Trinity.HotfixUGuiForm uiFormLogic, object userdata)
		{
			base.OnInit(uiFormLogic, userdata);

			GetBindComponents(uiFormLogic.gameObject);

			var items = Enumerable.Range(0, 20)
			.Select(i => new FancyScrollView.Example01.ItemData($"Cell {i}"))
			.ToArray();

			sViewList.UpdateData(items);
		}
	}
}
