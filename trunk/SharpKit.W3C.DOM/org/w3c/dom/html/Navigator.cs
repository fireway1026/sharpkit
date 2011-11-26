using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface Navigator
    {
        // Navigator
        // NavigatorID
        JsString appName {get;}
        JsString appVersion {get;}
        JsString platform {get;}
        JsString userAgent {get;}
        // NavigatorOnLine
        bool onLine {get;}
        // NavigatorAbilities
        void registerProtocolHandler(string scheme, JsString url, JsString title);
        void registerContentHandler(string mimeType, JsString url, JsString title);
        void yieldForStorageUpdates();
    }

}