//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HtmlFrameElement : HtmlElement
{

	// HTMLFrameElement
	public JsString frameBorder {get; set; }
	public JsString longDesc {get; set; }
	public JsString marginHeight {get; set; }
	public JsString marginWidth {get; set; }
	public JsString name {get; set; }
	public bool noResize {get; set; }
	public JsString scrolling {get; set; }
	public JsString src {get; set; }
	public Document contentDocument {get; private set; }
}

}