using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom
{

    public interface DOMImplementation
    {
        // DOMImplementation
        bool hasFeature(string feature, JsString version);
//TODO:
//ORIGINAL LINE: public DocumentType createDocumentType(String qualifiedName, String publicId, String systemId) throws DOMException;
        DocumentType createDocumentType(string qualifiedName, JsString publicId, JsString systemId);
//TODO:
//ORIGINAL LINE: public Document createDocument(String namespaceURI, String qualifiedName, DocumentType doctype) throws DOMException;
        Document createDocument(string namespaceURI, JsString qualifiedName, DocumentType doctype);
        object getFeature(string feature, JsString version);
        // DOMHTMLImplementation
        Document createHTMLDocument(string title);
    }

}