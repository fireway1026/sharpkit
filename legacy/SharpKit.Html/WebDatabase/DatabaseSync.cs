//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class DatabaseSync
{

	// DatabaseSync
	public void transaction(SQLTransactionSyncCallback callback) {}
	public void readTransaction(SQLTransactionSyncCallback callback) {}
	public JsString version {get; private set; }
	public void changeVersion(string oldVersion, string newVersion) {}
	public void changeVersion(string oldVersion, string newVersion, SQLTransactionSyncCallback callback) {}
}

}