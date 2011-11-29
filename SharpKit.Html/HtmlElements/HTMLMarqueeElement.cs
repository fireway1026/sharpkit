//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HtmlMarqueeElement : HtmlElement
{

	// HTMLMarqueeElement
	public JsString behavior {get; set; }
	public JsString bgColor {get; set; }
	public JsString direction {get; set; }
	public JsString height {get; set; }
	public int hspace {get; set; }
	public int loop {get; set; }
	public int scrollAmount {get; set; }
	public int scrollDelay {get; set; }
	public JsString trueSpeed {get; set; }
	public int vspace {get; set; }
	public JsString width {get; set; }
	public JsAction onbounce {get; set; }
	public JsAction onfinish {get; set; }
	public JsAction onstart {get; set; }
	public void start() {}
	public void stop() {}
}

}