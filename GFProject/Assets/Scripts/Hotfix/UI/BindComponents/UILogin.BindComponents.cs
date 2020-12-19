using UnityEngine;
using UnityEngine.UI;

//自动生成于：2020/12/17 19:39:31
namespace Trinity.Hotfix
{

	public partial class UILogin
	{

		private Button btnToMain;
		private Button btnToBattle;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();;

			btnToMain = autoBindTool.GetBindComponent<Button>(0);
			btnToBattle = autoBindTool.GetBindComponent<Button>(1);
		}

	}
}
