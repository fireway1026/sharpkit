//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Event = org.w3c.dom.events.Event;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class HashChangeEvent : Event
{

	// HashChangeEvent
	public object oldURL {get;private set;}
	public object newURL {get;private set;}
	public void initHashChangeEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string oldURLArg, string newURLArg) {}
}

}