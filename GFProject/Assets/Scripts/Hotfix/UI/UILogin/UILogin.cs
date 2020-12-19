using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//自动生成于：2020/12/17 19:39:31
namespace Trinity.Hotfix
{

	public partial class UILogin : HotfixUGuiForm
	{

		public override void OnInit(Trinity.HotfixUGuiForm uiFormLogic, object userdata)
		{
			base.OnInit(uiFormLogic, userdata);

			GetBindComponents(uiFormLogic.gameObject);

			btnToBattle.SetGoActive(false);

			Debug.Log("打开了登录界面");
		}
	}
}
