//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class PopStateEvent : DOMEvent
{

	// PopStateEvent
	public object state {get; private set; }
	public void initPopStateEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object stateArg) {}
}

}