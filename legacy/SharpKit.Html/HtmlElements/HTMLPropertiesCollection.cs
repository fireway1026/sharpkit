//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HtmlPropertiesCollection : HtmlCollection
{

	// HTMLPropertiesCollection
	[JsProperty(NativeIndexer = true)]
	public PropertyNodeList this[string name] {get { return default(PropertyNodeList); } }
	public DOMStringList names {get; private set; }
}

}