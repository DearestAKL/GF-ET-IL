using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//自动生成于：2020/12/17 19:39:20
namespace Trinity.Hotfix
{

	public partial class UIMain : HotfixUGuiForm
	{

		public override void OnInit(Trinity.HotfixUGuiForm uiFormLogic, object userdata)
		{
			base.OnInit(uiFormLogic, userdata);

			GetBindComponents(uiFormLogic.gameObject);
		}
	}
}