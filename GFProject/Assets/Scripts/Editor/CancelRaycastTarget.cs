using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

[InitializeOnLoad]

public class CancelRaycastTarget {

    [MenuItem("GameObject/GFUI/Image", false, 0)]
    static void CreatImage()
    {
        if (Selection.activeTransform)
        {
            GameObject go = new GameObject("img_", typeof(Image));
            go.GetComponent<Image>().raycastTarget = false;
            go.transform.SetParent(Selection.activeTransform);
        }
    }

    [MenuItem("GameObject/GFUI/Text", false, 0)]
    static void CreatText()
    {
        if (Selection.activeTransform)
        {
            GameObject go = new GameObject("txt_", typeof(Text));
            go.GetComponent<Text>().raycastTarget = false;
            go.transform.SetParent(Selection.activeTransform);
        }
    }
    [MenuItem("GameObject/GFUI/TextMeshPro", false, 0)]
    static void CreatTextMeshPro() {
        if (Selection.activeTransform) {
            GameObject go = new GameObject("mTxt_", typeof(TextMeshProUGUI));
            go.GetComponent<TextMeshProUGUI>().raycastTarget  = false;
            go.transform.SetParent(Selection.activeTransform);
        }
    }

    [MenuItem("GameObject/GFUI/Button", false, 0)]
    static void CreatButton() {
        if (Selection.activeTransform) {
            GameObject go = new GameObject("btn_", typeof(Button));
            go.transform.SetParent(Selection.activeTransform);
        }
    }
    [MenuItem("GameObject/GFUI/Slider", false, 0)]
    static void CreatSlider() {
        if (Selection.activeTransform) {
            GameObject go = new GameObject("slider_", typeof(Slider));
            go.transform.SetParent(Selection.activeTransform);
        }
    }
    [MenuItem("GameObject/GFUI/Raw Image", false, 0)]
    static void CreatRawImage()
    {
        if (Selection.activeTransform)
        {
            GameObject go = new GameObject("rImg_", typeof(RawImage));
            go.GetComponent<RawImage>().raycastTarget = false;
            go.transform.SetParent(Selection.activeTransform);
        }
    }
    static CancelRaycastTarget() {
        ObjectFactory.componentWasAdded += ComponentWasAdded;
    }

    static public void ComponentWasAdded(Component com) {
        if (com.GetType() == typeof(Text) ) {
            com.GetComponent<Text>().raycastTarget = false;
        } else if (com.GetType() == typeof(Image)){
            com.GetComponent<Image>().raycastTarget = false;
        } else if (com.GetType() == typeof(TextMeshProUGUI)) {
            com.GetComponent<TextMeshProUGUI>().raycastTarget = false;
        }
    }
}
