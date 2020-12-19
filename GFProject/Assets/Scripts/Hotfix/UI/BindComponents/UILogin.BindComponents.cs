using UnityEngine;
using UnityEngine.UI;
using FancyScrollView;
using FancyScrollView.Example01;

//自动生成于：2020/12/19 18:28:08
namespace Trinity.Hotfix
{
	public partial class UILogin
	{

		private Button btnToMain;
		private Button btnToBattle;
		private ScrollView sViewList;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();;

			btnToMain = autoBindTool.GetBindComponent<Button>(0);
			btnToBattle = autoBindTool.GetBindComponent<Button>(1);
			sViewList = autoBindTool.GetBindComponent<ScrollView>(2);
		}

	}
}
