//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class UserDataHandler
{

	// UserDataHandler
	public static short NODE_CLONED = 1;
	public static short NODE_IMPORTED = 2;
	public static short NODE_DELETED = 3;
	public static short NODE_RENAMED = 4;
	public static short NODE_ADOPTED = 5;
	public void handle(short operation, string key, object data, Node src, Node dst) {}
}

}