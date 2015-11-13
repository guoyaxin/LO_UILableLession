using UnityEngine;
using System.Collections;

public class CreateLabelScript : MonoBehaviour
{

	public GameObject root;

	public GameObject fontPrefab;
	// Use this for initialization
	void Start ()
	{
		LO_CreateLabel ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		print ("git push test");
	}

	/**
	 * 创建一个Label
	*/
	void LO_CreateLabel ()
	{
		GameObject lab = NGUITools.AddChild (root);
		UILabel label = lab.AddComponent<UILabel> ();
		//设置Label的文字
		label.text = "LanOuKeji";
		//设置Label的字体颜色
		label.color = Color.green;
		//设置Label的字体
//		Font trueFont = Font.CreateDynamicFontFromOSFont ("Calibri", 20);
//		label.trueTypeFont = trueFont;

		//设置Label的字体
		UIFont ft = fontPrefab.GetComponent<UIFont> ();
		label.bitmapFont = ft;
	
		//设置Label的宽度和高度
		label.width = 200;
		label.height = 100;
		//设置Label的尺寸根据字体的变化而变化
		label.overflowMethod = UILabel.Overflow.ResizeFreely;
		//设置Label文字有阴影效果
		label.effectStyle = UILabel.Effect.Shadow;

	}
}
