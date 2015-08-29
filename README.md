# LO_UILabelLession

## 通过代码讲解了NGUI中UILabel的实现方式和常用属性的设置

###关键代码
    void LO_CreateLabel ()
	{
		GameObject lab = NGUITools.AddChild (root);
		UILabel label = lab.AddComponent<UILabel> ();
		//设置Label的文字
		label.text = "LanOuKeji";
		//设置Label的字体颜色
		label.color = Color.green;
		//设置Label的字体
		//Font trueFont = Font.CreateDynamicFontFromOSFont ("Calibri", 20);
		//label.trueTypeFont = trueFont;

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
		