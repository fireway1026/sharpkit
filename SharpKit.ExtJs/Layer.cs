//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Layer
    /// <summary>
    /// An extended Ext.core.Element object that supports a shadow and shim, constrain to viewport and
    /// automatic maintaining of shadow/shim positions.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Layer : Ext.core.Element
    {
        /// <summary>
        /// Creates new Layer. ...
        /// </summary>
        public Layer(object config=null, object existingEl=null){}
        /// <summary>
        /// Sets the z-index of this layer and adjusts any shadow and shim z-indexes. ...
        /// </summary>
        public Layer setZIndex(JsNumber zindex){return null;}
        public Layer(LayerConfig config){}
    }
    #endregion
    #region LayerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LayerConfig : Ext.core.ElementConfig
    {
        public JsString cls{get;set;}
        public bool constrain{get;set;}
        public object dh{get;set;}
        /// <summary>
        /// A String which specifies how this Layer will be hidden. ...
        /// </summary>
        public JsString hideMode{get;set;}
        /// <summary>
        /// True to automatically create an Ext.Shadow, or a string indicating the
        /// shadow's display Ext.Shadow.mode. ...
        /// </summary>
        public object shadow{get;set;}
        public JsNumber shadowOffset{get;set;}
        public bool shim{get;set;}
        /// <summary>
        /// Defaults to use css offsets to hide the Layer. ...
        /// </summary>
        public bool useDisplay{get;set;}
        public JsString visibilityCls{get;set;}
        public JsNumber zindex{get;set;}
    }
    #endregion
    #region LayerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LayerEvents : Ext.core.ElementEvents
    {
    }
    #endregion
}
#endregion