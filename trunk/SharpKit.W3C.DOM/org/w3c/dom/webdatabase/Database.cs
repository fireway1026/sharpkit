using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.webdatabase
{

    public interface Database
    {
        // Database
        void transaction(SQLTransactionCallback callback);
        void transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);
        void transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
        void readTransaction(SQLTransactionCallback callback);
        void readTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);
        void readTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
        JsString version {get;}
        void changeVersion(string oldVersion, JsString newVersion);
        void changeVersion(string oldVersion, JsString newVersion, SQLTransactionCallback callback);
        void changeVersion(string oldVersion, JsString newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);
        void changeVersion(string oldVersion, JsString newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
    }

}