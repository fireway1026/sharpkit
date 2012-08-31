//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

	using SharpKit.JavaScript;

	[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "CSSRule")]
	public partial class CSSRule
	{

		// CSSRule
		public static short STYLE_RULE = 1;
		public static short IMPORT_RULE = 3;
		public static short MEDIA_RULE = 4;
		public static short FONT_FACE_RULE = 5;
		public static short PAGE_RULE = 6;
		public static short NAMESPACE_RULE = 10;
		public short type { get; private set; }
		public JsString cssText { get; set; }
		public CSSRule parentRule { get; private set; }
		public CSSStyleSheet parentStyleSheet { get; private set; }
	}

	[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
	public partial class CSSRuleList
	{

		public int length { get; private set; }
		[JsProperty(NativeIndexer = true)]
		public CSSStyleRule this[int index] { get { return default(CSSStyleRule); } }

	}

}