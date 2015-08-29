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
	
	}

	void LO_CreateLabel ()
	{
		GameObject lab = NGUITools.AddChild (root);
		UILabel label = lab.AddComponent<UILabel> ();
		label.text = "LanOuKeji";
		label.color = Color.green;

//		Font trueFont = Font.CreateDynamicFontFromOSFont ("Calibri", 20);
//		label.trueTypeFont = trueFont;


		UIFont ft = fontPrefab.GetComponent<UIFont> ();
		label.bitmapFont = ft;
	
		label.width = 200;
		label.height = 100;

		label.overflowMethod = UILabel.Overflow.ResizeFreely;
		label.effectStyle = UILabel.Effect.Shadow;

	}
}
