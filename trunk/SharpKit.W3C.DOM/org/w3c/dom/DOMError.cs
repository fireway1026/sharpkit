//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class DOMError
{

	// DOMError
	public static short SEVERITY_WARNING = 1;
	public static short SEVERITY_ERROR = 2;
	public static short SEVERITY_FATAL_ERROR = 3;
	public short severity {get;private set;}
	public string message {get;private set;}
	public string type {get;private set;}
	public object relatedException {get;private set;}
	public object relatedData {get;private set;}
	public DOMLocator location {get;private set;}
}

}