using UnityEngine;
using UnityEngine.UI;

//自动生成于：2020/12/16 16:57:17
namespace Trinity
{

	public partial class UIInitLoading
	{

		private Image m_Img_BarBottom;
		private Slider m_Slider_BarPoint;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();;

			m_Img_BarBottom = autoBindTool.GetBindComponent<Image>(0);
			m_Slider_BarPoint = autoBindTool.GetBindComponent<Slider>(1);
		}

	}
}
