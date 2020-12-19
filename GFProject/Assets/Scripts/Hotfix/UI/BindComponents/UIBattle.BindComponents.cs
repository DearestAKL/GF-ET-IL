using UnityEngine;
using UnityEngine.UI;

//自动生成于：2020/12/17 19:39:35
namespace Trinity.Hotfix
{

	public partial class UIBattle
	{

		private Button btnToMain;
		private Button btnToLogin;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();;

			btnToMain = autoBindTool.GetBindComponent<Button>(0);
			btnToLogin = autoBindTool.GetBindComponent<Button>(1);
		}

	}
}
