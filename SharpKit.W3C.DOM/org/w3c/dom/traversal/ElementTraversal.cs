//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.traversal
{

using SharpKit.JavaScript;
using Element = org.w3c.dom.Element;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class ElementTraversal
{

	// ElementTraversal
	public Element firstElementChild {get;private set;}
	public Element lastElementChild {get;private set;}
	public Element previousElementSibling {get;private set;}
	public Element nextElementSibling {get;private set;}
	public int childElementCount {get;private set;}
}

}