//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.dd
namespace Ext.dd
{
    #region DragZone
    /// <summary>
    /// This class provides a container DD instance that allows dragging of multiple child source nodes. This class does not move the drag target nodes, but a proxy element which may contain
    /// any DOM structure you wish. The DOM element to show in the proxy is provided by either a
    /// provided implementation of getDragData, or by registered draggables registered with Ext.dd.Registry If you wish to provide draggability for an arbitrary number of DOM nodes, each of which represent some
    /// application object (For example nodes in a DataView) then use of this class
    /// is the most efficient way to &quot;activate&quot; those nodes. By default, this class requires that draggable child nodes are registered with Ext.dd.Registry.
    /// However a simpler way to allow a DragZone to manage any number of draggable elements is to configure
    /// the DragZone with  an implementation of the getDragData method which interrogates the passed
    /// mouse event to see if it has taken place within an element, or class of elements. This is easily done
    /// by using the event&#39;s getTarget method to identify a node based on a
    /// Ext.DomQuery selector. For example, to make the nodes of a DataView draggable, use the following
    /// technique. Knowledge of the use of the DataView is required: myDataView.on(&#39;render&#39;, function(v) {
    /// myDataView.dragZone = new Ext.dd.DragZone(v.getEl(), {
    /// //      On receipt of a mousedown event, see if it is within a DataView node.
    /// //      Return a drag data object if so.
    /// getDragData: function(e) {
    /// //          Use the DataView&#39;s own itemSelector (a mandatory property) to
    /// //          test if the mousedown is within one of the DataView&#39;s nodes.
    /// var sourceEl = e.getTarget(v.itemSelector, 10);
    /// //          If the mousedown is within a DataView node, clone the node to produce
    /// //          a ddel element for use by the drag proxy. Also add application data
    /// //          to the returned data object.
    /// if (sourceEl) {
    /// d = sourceEl.cloneNode(true);
    /// d.id = Ext.id();
    /// return {
    /// ddel: d,
    /// sourceEl: sourceEl,
    /// repairXY: Ext.fly(sourceEl).getXY(),
    /// sourceStore: v.store,
    /// draggedRecord: v.getRecord(sourceEl)
    /// }
    /// }
    /// },
    /// //      Provide coordinates for the proxy to slide back to on failed drag.
    /// //      This is the original XY coordinates of the draggable element captured
    /// //      in the getDragData method.
    /// getRepairXY: function() {
    /// return this.dragData.repairXY;
    /// }
    /// });
    /// }); See the DropZone documentation for details about building a DropZone which
    /// cooperates with this DragZone.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DragZone : DragSource
    {
        /// <summary>
        /// Creates new DragZone. ...
        /// </summary>
        public DragZone(object el, object config){}
        /// <summary>
        /// Called after a repair of an invalid drop. ...
        /// </summary>
        public object afterRepair(){return null;}
        /// <summary>
        /// Called when a mousedown occurs in this container. ...
        /// </summary>
        public object getDragData(EventObject e){return null;}
        /// <summary>
        /// Called before a repair of an invalid drop to get the XY to animate to. ...
        /// </summary>
        public JsArray getRepairXY(EventObject e){return null;}
        /// <summary>
        /// Called once drag threshold has been reached to initialize the proxy element. ...
        /// </summary>
        public bool onInitDrag(JsNumber x, JsNumber y){return false;}
        /// <summary>
        /// This property contains the data representing the dragged object. ...
        /// </summary>
        public object dragData{get;set;}
        public DragZone(DragZoneConfig config){}
        public DragZone(){}
    }
    #endregion
    #region DragZoneConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DragZoneConfig : DragSourceConfig
    {
        public bool containerScroll{get;set;}
    }
    #endregion
    #region DragZoneEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DragZoneEvents : DragSourceEvents
    {
    }
    #endregion
}
#endregion
