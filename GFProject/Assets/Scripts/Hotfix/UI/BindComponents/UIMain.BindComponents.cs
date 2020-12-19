using UnityEngine;
using UnityEngine.UI;

//自动生成于：2020/12/17 19:39:20
namespace Trinity.Hotfix
{

	public partial class UIMain
	{

		private Button btnToLogin;
		private Button btnToBattle;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();;

			btnToLogin = autoBindTool.GetBindComponent<Button>(0);
			btnToBattle = autoBindTool.GetBindComponent<Button>(1);
		}

	}
}
