using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface HTMLTableElement : HTMLElement
    {
        // HTMLTableElement
        HTMLTableCaptionElement caption {get;set;}
        HTMLElement createCaption();
        void deleteCaption();
        HTMLTableSectionElement tHead {get;set;}
        HTMLElement createTHead();
        void deleteTHead();
        HTMLTableSectionElement tFoot {get;set;}
        HTMLElement createTFoot();
        void deleteTFoot();
        HTMLCollection tBodies {get;}
        HTMLElement createTBody();
        HTMLCollection rows {get;}
        HTMLElement insertRow();
        HTMLElement insertRow(int index);
        void deleteRow(int index);
        JsString summary {get;set;}
        // HTMLTableElement-31
        JsString align {get;set;}
        JsString bgColor {get;set;}
        JsString border {get;set;}
        JsString cellPadding {get;set;}
        JsString cellSpacing {get;set;}
        JsString frame {get;set;}
        JsString rules {get;set;}
        JsString width {get;set;}
    }

}