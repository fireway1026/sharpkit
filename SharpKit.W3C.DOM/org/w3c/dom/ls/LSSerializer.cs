//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.ls
{

using SharpKit.JavaScript;
using DOMConfiguration = org.w3c.dom.DOMConfiguration;
using DOMException = org.w3c.dom.DOMException;
using Node = org.w3c.dom.Node;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class LSSerializer
{

	// LSSerializer
	public DOMConfiguration domConfig {get { return default(DOMConfiguration); } }
	public string newLine {get { return default(string); } set {}}
	public LSSerializerFilter filter {get { return default(LSSerializerFilter); } set {}}
	public bool write(Node nodeArg, LSOutput destination) { return default(bool); }
	public bool writeToURI(Node nodeArg, string uri) { return default(bool); }
	public string writeToString(Node nodeArg) { return default(string); }
}

}