//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class MessagePort
{

	// MessagePort
	public void postMessage(object message) {}
	public void postMessage(object message, MessagePort[] ports) {}
	public void start() {}
	public void close() {}
	public JsAction onmessage {get; set; }
}

}