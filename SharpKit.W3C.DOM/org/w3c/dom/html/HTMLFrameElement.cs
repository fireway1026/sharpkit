//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Document = org.w3c.dom.Document;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class HTMLFrameElement : HTMLElement
{

	// HTMLFrameElement
	public string frameBorder {get;set;}
	public string longDesc {get;set;}
	public string marginHeight {get;set;}
	public string marginWidth {get;set;}
	public string name {get;set;}
	public bool noResize {get;set;}
	public string scrolling {get;set;}
	public string src {get;set;}
	public Document contentDocument {get;private set;}
}

}