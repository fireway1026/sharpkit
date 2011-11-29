//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom
{

using SharpKit.JavaScript;
using Window = org.w3c.dom.html.Window;
using StyleSheet = org.w3c.dom.stylesheets.StyleSheet;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Document : Node
{

	// Document
	public DocumentType doctype {get { return default(DocumentType); } }
	public DOMImplementation implementation {get { return default(DOMImplementation); } }
	public Element documentElement {get { return default(Element); } }
	public Element createElement(string tagName) { return default(Element); }
	public DocumentFragment createDocumentFragment() { return default(DocumentFragment); }
	public Text createTextNode(string data) { return default(Text); }
	public Comment createComment(string data) { return default(Comment); }
	public CDATASection createCDATASection(string data) { return default(CDATASection); }
	public ProcessingInstruction createProcessingInstruction(string target, string data) { return default(ProcessingInstruction); }
	public Attr createAttribute(string name) { return default(Attr); }
	public EntityReference createEntityReference(string name) { return default(EntityReference); }
	public NodeList getElementsByTagName(string tagname) { return default(NodeList); }
	public Node importNode(Node importedNode, bool deep) { return default(Node); }
	public Element createElementNS(string namespaceURI, string qualifiedName) { return default(Element); }
	public Attr createAttributeNS(string namespaceURI, string qualifiedName) { return default(Attr); }
	public NodeList getElementsByTagNameNS(string namespaceURI, string localName) { return default(NodeList); }
	public Element getElementById(string elementId) { return default(Element); }
	public string inputEncoding {get { return default(string); } }
	public string xmlEncoding {get { return default(string); } }
	public bool xmlStandalone {get { return default(bool); } set {}}
	public string xmlVersion {get { return default(string); } set {}}
	public bool strictErrorChecking {get { return default(bool); } set {}}
	public string documentURI {get { return default(string); } set {}}
	public Node adoptNode(Node source) { return default(Node); }
	public DOMConfiguration domConfig {get { return default(DOMConfiguration); } }
	public void normalizeDocument() {}
	public Node renameNode(Node n, string namespaceURI, string qualifiedName) { return default(Node); }

	// Document-39
	public StyleSheet styleSheets {get { return default(StyleSheet); } }
	public string selectedStyleSheetSet {get { return default(string); } set {}}
	public string lastStyleSheetSet {get { return default(string); } }
	public string preferredStyleSheetSet {get { return default(string); } }
	public DOMStringList styleSheetSets {get { return default(DOMStringList); } }
	public void enableStyleSheetsForSet(string name) {}

	// Document-40
	public Window defaultView {get { return default(Window); } }
	public Element elementFromPoint(float x, float y) { return default(Element); }
	public CaretPosition caretPositionFromPoint(float x, float y) { return default(CaretPosition); }

	// NodeSelector
	public Element querySelector(string selectors) { return default(Element); }
	public NodeList querySelectorAll(string selectors) { return default(NodeList); }
}

}