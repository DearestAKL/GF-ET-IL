using UnityEngine;
using UnityEngine.UI;

//自动生成于：2020/12/19 14:11:39
namespace Trinity.Hotfix
{

	public partial class CellTest
	{

		private Text txtnumber;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();;

			txtnumber = autoBindTool.GetBindComponent<Text>(0);
		}

	}
}
