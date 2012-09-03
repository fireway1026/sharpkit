//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dd
{
    #region DragDropManager
    /// <inheritdocs />
    /// <summary>
    /// <p>DragDropManager is a singleton that tracks the element interaction for
    /// all DragDrop items in the window.  Generally, you will not call
    /// this class directly, but it does have helper methods that could
    /// be useful in your DragDrop implementations.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DragDropManager : Ext.Base
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        private static JsString @className{get;set;}
        /// <summary>
        /// In intersect mode, drag and drop interaction is defined by the
        /// overlap of two or more drag and drop objects.
        /// Defaults to: <c>1</c>
        /// </summary>
        public static JsNumber INTERSECT{get;set;}
        /// <summary>
        /// In point mode, drag and drop interaction is defined by the
        /// location of the cursor during the drag/drop
        /// Defaults to: <c>0</c>
        /// </summary>
        public static JsNumber POINT{get;set;}
        /// <summary>
        /// The number of pixels that the mouse needs to move after the
        /// mousedown before the drag is initiated.  Default=3;
        /// Defaults to: <c>3</c>
        /// </summary>
        public static JsNumber clickPixelThresh{get;set;}
        /// <summary>
        /// The number of milliseconds after the mousedown event to initiate the
        /// drag if we don't get a mouseup event. Default=350
        /// Defaults to: <c>350</c>
        /// </summary>
        public static JsNumber clickTimeThresh{get;set;}
        /// <summary>
        /// Timeout used for the click time threshold
        /// Defaults to: <c>null</c>
        /// </summary>
        private static JsObject clickTimeout{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject configMap{get;set;}
        /// <summary>
        /// the X distance between the cursor and the object being dragged
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber deltaX{get;set;}
        /// <summary>
        /// the Y distance between the cursor and the object being dragged
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber deltaY{get;set;}
        /// <summary>
        /// the DragDrop object that is currently being dragged
        /// Defaults to: <c>null</c>
        /// </summary>
        private static Ext.dd.DragDrop dragCurrent{get;set;}
        /// <summary>
        /// the DragDrop object(s) that are being hovered over
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static Ext.dd.DragDrop dragOvers{get;set;}
        /// <summary>
        /// Flag that indicates that either the drag pixel threshold or the
        /// mousdown time threshold has been met
        /// Defaults to: <c>false</c>
        /// </summary>
        private static bool dragThreshMet{get;set;}
        /// <summary>
        /// A cache of DOM elements
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject elementCache{get;set;}
        /// <summary>
        /// Array of element ids defined as drag handles.  Used to determine
        /// if the element that generated the mousedown event is actually the
        /// handle and not the html element itself.
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsString handleIds{get;set;}
        /// <summary>
        /// Two dimensional Array of registered DragDrop objects.  The first
        /// dimension is the DragDrop item group, the second the DragDrop
        /// object.
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsString ids{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        private static JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject initConfigMap{get;set;}
        /// <summary>
        /// Internal flag that is set to true when drag and drop has been
        /// intialized
        /// Defaults to: <c>false</c>
        /// </summary>
        private static bool initialized{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        private static bool isInstance{get;set;}
        /// <summary>
        /// Location cache that is set for all drag drop objects when a drag is
        /// initiated, cleared when the drag is finished.
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject locationCache{get;set;}
        /// <summary>
        /// All drag and drop can be disabled.
        /// Defaults to: <c>false</c>
        /// </summary>
        private static bool locked{get;set;}
        /// <summary>
        /// The current drag and drop mode.  Default: POINT
        /// Defaults to: <c>0</c>
        /// </summary>
        public static JsNumber mode{get;set;}
        /// <summary>
        /// This config is only provided to provide old, usually unwanted drag/drop behaviour.
        /// From ExtJS 4.1.0 onwards, when drop targets are contained in floating, absolutely positioned elements
        /// such as in <see cref="Ext.window.Window">Windows</see>, which may overlap each other, <c>over</c> and <c>drop</c> events
        /// are only delivered to the topmost drop target at the mouse position.
        /// If all targets below that in zIndex order should also receive notifications, set
        /// <c>notifyOccluded</c> to <c>true</c>.
        /// Defaults to: <c>false</c>
        /// </summary>
        public static bool notifyOccluded{get;set;}
        /// <summary>
        /// Flag to determine if we should prevent the default behavior of the
        /// events we define. By default this is true, but this can be set to
        /// false if you need the default behavior (not recommended)
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool preventDefault{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        protected static Class self{get;set;}
        /// <summary>
        /// The X position of the mousedown event stored for later use when a
        /// drag threshold is met.
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber startX{get;set;}
        /// <summary>
        /// The Y position of the mousedown event stored for later use when a
        /// drag threshold is met.
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber startY{get;set;}
        /// <summary>
        /// Flag to determine if we should stop the propagation of the events
        /// we generate. This is true by default but you may want to set it to
        /// false if the html element contains other features that require the
        /// mouse click.
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool stopPropagation{get;set;}
        /// <summary>
        /// Set useCache to false if you want to force object the lookup of each
        /// drag and drop linked element constantly during a drag.
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool useCache{get;set;}
        /// <summary>
        /// Runs method on all drag and drop objects
        /// </summary>
        /// <param name="sMethod">
        /// </param>
        /// <param name="args">
        /// </param>
        private static void _execOnAll(object sMethod, object args=null){}
        /// <summary>
        /// Drag and drop initialization.  Sets up the global event handlers
        /// </summary>
        private static void _onLoad(){}
        /// <summary>
        /// Reset constraints on all drag and drop objs
        /// </summary>
        /// <param name="e">
        /// </param>
        private static void _onResize(object e){}
        /// <summary>
        /// unload event handler
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <param name="me">
        /// </param>
        private static void _onUnload(object e, object me){}
        /// <summary>
        /// Unregisters a drag and drop item.  This is executed in
        /// DragDrop.unreg, use that method instead of calling this directly.
        /// </summary>
        /// <param name="oDD">
        /// </param>
        private static void _remove(object oDD){}
        /// <summary>
        /// Utility method to pass to Ext.Array.sort when sorting potential drop targets by z-index.
        /// </summary>
        /// <param name="d1">
        /// </param>
        /// <param name="d2">
        /// </param>
        private static void byZIndex(object d1, object d2){}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// constructor: function() {
        /// alert("I'm a cat!");
        /// }
        /// });
        /// My.Cat.override({
        /// constructor: function() {
        /// alert("I'm going to be a cat!");
        /// this.callOverridden();
        /// alert("Meeeeoooowwww");
        /// }
        /// });
        /// var kitty = new My.Cat(); // alerts "I'm going to be a cat!"
        /// // alerts "I'm a cat!"
        /// // alerts "Meeeeoooowwww"
        /// </code>
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>as of 4.1. Use <see cref="Ext.Base.callParent">callParent</see> instead.</p>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callOverridden(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the overridden method</p>
        /// </div>
        /// </returns>
        protected static object callOverridden(object args=null){return null;}
        /// <summary>
        /// Call the "parent" method of the current method. That is the method previously
        /// overridden by derivation or by an override (see Ext.define).
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Base', {
        /// constructor: function (x) {
        /// this.x = x;
        /// },
        /// statics: {
        /// method: function (x) {
        /// return x;
        /// }
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived', {
        /// extend: 'My.Base',
        /// constructor: function () {
        /// this.callParent([21]);
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // alerts 21
        /// </code>
        /// This can be used with an override as follows:
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.DerivedOverride', {
        /// override: 'My.Derived',
        /// constructor: function (x) {
        /// this.callParent([x*2]); // calls original My.Derived constructor
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // now alerts 42
        /// </code>
        /// This also works with static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2', {
        /// extend: 'My.Base',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Base.method
        /// }
        /// }
        /// });
        /// alert(My.Base.method(10);     // alerts 10
        /// alert(My.Derived2.method(10); // alerts 20
        /// </code>
        /// Lastly, it also works with overridden static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2Override', {
        /// override: 'My.Derived2',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Derived2.method
        /// }
        /// }
        /// });
        /// alert(My.Derived2.method(10); // now alerts 40
        /// </code>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callParent(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the parent method</p>
        /// </div>
        /// </returns>
        protected static object callParent(object args=null){return null;}
        /// <summary>
        /// </summary>
        private static void configClass(){}
        /// <summary>
        /// Overrides: <see cref="Ext.AbstractComponent.destroy">Ext.AbstractComponent.destroy</see>, <see cref="Ext.AbstractPlugin.destroy">Ext.AbstractPlugin.destroy</see>, <see cref="Ext.layout.Layout.destroy">Ext.layout.Layout.destroy</see>
        /// </summary>
        private static void destroy(){}
        /// <summary>
        /// Iterates over all of the DragDrop elements to find ones we are
        /// hovering over or dropping on
        /// </summary>
        /// <param name="e"><p>the event</p>
        /// </param>
        /// <param name="isDrop"><p>is this a drop op or a mouseover op?</p>
        /// </param>
        private static void fireEvents(object e, bool isDrop){}
        /// <summary>
        /// Helper function for getting the best match from the list of drag
        /// and drop objects returned by the drag and drop events when we are
        /// in INTERSECT mode.  It returns either the first object that the
        /// cursor is over, or the object that has the greatest overlap with
        /// the dragged element.
        /// </summary>
        /// <param name="dds"><p>The array of drag and drop objects
        /// targeted</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dd.DragDrop">Ext.dd.DragDrop</see></span><div><p>The best single match</p>
        /// </div>
        /// </returns>
        public static Ext.dd.DragDrop getBestMatch(JsArray<Ext.dd.DragDrop> dds){return null;}
        /// <summary>
        /// Parameters<li><span>name</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="name">
        /// </param>
        private static void getConfig(object name){}
        /// <summary>
        /// Returns the style property for the DOM element (i.e.,
        /// document.getElById(id).style)
        /// </summary>
        /// <param name="id"><p>the id of the elment to get</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The style property of the element</p>
        /// </div>
        /// </returns>
        public static object getCss(JsString id){return null;}
        /// <summary>
        /// Returns the DragDrop instance for a given id
        /// </summary>
        /// <param name="id"><p>the id of the DragDrop object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dd.DragDrop">Ext.dd.DragDrop</see></span><div><p>the drag drop object, null if it is not found</p>
        /// </div>
        /// </returns>
        public static Ext.dd.DragDrop getDDById(JsString id){return null;}
        /// <summary>
        /// Get the wrapper for the DOM element specified
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>This wrapper isn't that useful</p>
        /// </summary>
        /// <param name="id"><p>the id of the element to get</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dd.DragDropManager.ElementWrapper">Ext.dd.DragDropManager.ElementWrapper</see></span><div><p>the wrapped element</p>
        /// </div>
        /// </returns>
        private static Ext.dd.DragDropManager.ElementWrapper getElWrapper(JsString id){return null;}
        /// <summary>
        /// Returns the actual DOM element
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>use Ext.lib.Ext.getDom instead</p>
        /// </summary>
        /// <param name="id"><p>the id of the elment to get</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The element</p>
        /// </div>
        /// </returns>
        public static object getElement(JsString id){return null;}
        /// <summary>
        /// Returns the initial configuration passed to constructor when instantiating
        /// this class.
        /// </summary>
        /// <param name="name"><p>Name of the config option to return.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/Mixed</span><div><p>The full config object or a single config value
        /// when <c>name</c> parameter specified.</p>
        /// </div>
        /// </returns>
        public static object getInitialConfig(object name=null){return null;}
        /// <summary>
        /// Returns a Region object containing the drag and drop element's position
        /// and size, including the padding configured for it
        /// </summary>
        /// <param name="oDD"><p>the drag and drop object to get the location for.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.util.Region">Ext.util.Region</see></span><div><p>a Region object representing the total area
        /// the element occupies, including any padding
        /// the instance is configured for.</p>
        /// </div>
        /// </returns>
        public static Ext.util.Region getLocation(Ext.dd.DragDrop oDD){return null;}
        /// <summary>
        /// Returns the drag and drop instances that are in all groups the
        /// passed in instance belongs to.
        /// </summary>
        /// <param name="p_oDD"><p>the obj to get related data for</p>
        /// </param>
        /// <param name="bTargetsOnly"><p>if true, only return targetable objs</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.dd.DragDrop">Ext.dd.DragDrop</see>[]</span><div><p>the related instances</p>
        /// </div>
        /// </returns>
        public static Ext.dd.DragDrop[] getRelated(Ext.dd.DragDrop p_oDD, bool bTargetsOnly){return null;}
        /// <summary>
        /// Collects the z-index of the passed element, looking up the parentNode axis to find an absolutely positioned ancestor
        /// which is able to yield a z-index. If found to be not absolutely positionedm returns -1.
        /// This is used when sorting potential drop targets into z-index order so that only the topmost receives <c>over</c> and <c>drop</c> events.
        /// </summary>
        /// <param name="element">
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The z-index of the element, or of its topmost absolutely positioned ancestor. Returns -1 if the element is not
        /// absolutely positioned.</p>
        /// </div>
        /// </returns>
        private static JsNumber getZIndex(object element){return null;}
        /// <summary>
        /// Fired after a registered DragDrop object gets the mousedown event.
        /// Sets up the events required to track the object being dragged
        /// </summary>
        /// <param name="e"><p>the event</p>
        /// </param>
        /// <param name="oDD"><p>the DragDrop object being dragged</p>
        /// </param>
        private static void handleMouseDown(object e, Ext.dd.DragDrop oDD){}
        /// <summary>
        /// Internal function to handle the mousemove event.  Will be invoked
        /// from the context of the html element.
        /// @TODO figure out what we can do about mouse events lost when the
        /// user drags objects beyond the window boundary.  Currently we can
        /// detect this in internet explorer by verifying that the mouse is
        /// down during the mousemove event.  Firefox doesn't give us the
        /// button state on the mousemove event.
        /// </summary>
        /// <param name="e"><p>the event</p>
        /// </param>
        private static void handleMouseMove(object e){}
        /// <summary>
        /// Internal function to handle the mouseup event.  Will be invoked
        /// from the context of the document.
        /// </summary>
        /// <param name="e"><p>the event</p>
        /// </param>
        private static void handleMouseUp(object e){}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        private static void hasConfig(object config){}
        /// <summary>
        /// Called the first time an element is registered.
        /// </summary>
        private static void init(){}
        /// <summary>
        /// Initialize configuration for this class. a typical example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.awesome.Class', {
        /// // The default config
        /// config: {
        /// name: 'Awesome',
        /// isAwesome: true
        /// },
        /// constructor: function(config) {
        /// this.initConfig(config);
        /// }
        /// });
        /// var awesome = new My.awesome.Class({
        /// name: 'Super Awesome'
        /// });
        /// alert(awesome.getName()); // 'Super Awesome'
        /// </code>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Base">Ext.Base</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        protected static Ext.Base initConfig(object config){return null;}
        /// <summary>
        /// Utility function to determine if a given element has been
        /// registered as a drag drop item.
        /// </summary>
        /// <param name="id"><p>the element id to check</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true if this element is a DragDrop item,
        /// false otherwise</p>
        /// </div>
        /// </returns>
        public static bool isDragDrop(JsString id){return false;}
        /// <summary>
        /// Utility function to determine if a given element has been
        /// registered as a drag drop handle for the given Drag Drop object.
        /// </summary>
        /// <param name="id"><p>the element id to check</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true if this element is a DragDrop handle, false
        /// otherwise</p>
        /// </div>
        /// </returns>
        public static bool isHandle(JsString id){return false;}
        /// <summary>
        /// Returns true if the specified dd target is a legal target for
        /// the specifice drag obj
        /// </summary>
        /// <param name="oDD"><p>the drag obj</p>
        /// </param>
        /// <param name="oTargetDD"><p>the target</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true if the target is a legal target for the
        /// dd obj</p>
        /// </div>
        /// </returns>
        public static bool isLegalTarget(Ext.dd.DragDrop oDD, Ext.dd.DragDrop oTargetDD){return false;}
        /// <summary>
        /// Is drag and drop locked?
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if drag and drop is locked, false otherwise.</p>
        /// </div>
        /// </returns>
        public static bool isLocked(){return false;}
        /// <summary>
        /// Checks the cursor location to see if it over the target
        /// </summary>
        /// <param name="pt"><p>The point to evaluate</p>
        /// </param>
        /// <param name="oTarget"><p>the DragDrop object we are inspecting</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true if the mouse is over the target</p>
        /// </div>
        /// </returns>
        private static bool isOverTarget(Ext.util.Point pt, Ext.dd.DragDrop oTarget){return false;}
        /// <summary>
        /// My goal is to be able to transparently determine if an object is
        /// typeof DragDrop, and the exact subclass of DragDrop.  typeof
        /// returns "object", oDD.constructor.toString() always returns
        /// "DragDrop" and not the name of the subclass.  So for now it just
        /// evaluates a well-known variable in DragDrop.
        /// </summary>
        /// <param name="the"><p>object to evaluate</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true if typeof oDD = DragDrop</p>
        /// </div>
        /// </returns>
        public static bool isTypeOfDD(object the){return false;}
        /// <summary>
        /// Lock all drag and drop functionality
        /// </summary>
        public static void @lock(){}
        /// <summary>
        /// Parameters<li><span>names</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>callback</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="names">
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="scope">
        /// </param>
        private static void onConfigUpdate(object names, object callback, object scope){}
        /// <summary>
        /// Refreshes the cache of the top-left and bottom-right points of the
        /// drag and drop objects in the specified group(s).  This is in the
        /// format that is stored in the drag and drop instance, so typical
        /// usage is:
        /// <code><see cref="Ext.dd.DragDropManager.refreshCache">Ext.dd.DragDropManager.refreshCache</see>(ddinstance.groups);
        /// </code>
        /// Alternatively:
        /// <code><see cref="Ext.dd.DragDropManager.refreshCache">Ext.dd.DragDropManager.refreshCache</see>({group1:true, group2:true});
        /// </code>
        /// @TODO this really should be an indexed array.  Alternatively this
        /// method could accept both.
        /// </summary>
        /// <param name="groups"><p>an associative array of groups to refresh</p>
        /// </param>
        public static void refreshCache(object groups){}
        /// <summary>
        /// Each DragDrop instance must be registered with the DragDropManager.
        /// This is executed in DragDrop.init()
        /// </summary>
        /// <param name="oDD"><p>the DragDrop object to register</p>
        /// </param>
        /// <param name="sGroup"><p>the name of the group this element belongs to</p>
        /// </param>
        public static void regDragDrop(Ext.dd.DragDrop oDD, JsString sGroup){}
        /// <summary>
        /// Each DragDrop handle element must be registered.  This is done
        /// automatically when executing DragDrop.setHandleElId()
        /// </summary>
        /// <param name="sDDId"><p>the DragDrop id this element is a handle for</p>
        /// </param>
        /// <param name="sHandleId"><p>the id of the element that is the drag
        /// handle</p>
        /// </param>
        public static void regHandle(JsString sDDId, JsString sHandleId){}
        /// <summary>
        /// Removes the supplied dd instance from the supplied group. Executed
        /// by DragDrop.removeFromGroup, so don't call this function directly.
        /// </summary>
        /// <param name="oDD">
        /// </param>
        /// <param name="sGroup">
        /// </param>
        private static void removeDDFromGroup(object oDD, object sGroup){}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>applyIfNotSet</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <param name="applyIfNotSet">
        /// </param>
        private static void setConfig(object config, object applyIfNotSet){}
        /// <summary>
        /// Fired when either the drag pixel threshol or the mousedown hold
        /// time threshold has been met.
        /// </summary>
        /// <param name="x"><p>the X position of the original mousedown</p>
        /// </param>
        /// <param name="y"><p>the Y position of the original mousedown</p>
        /// </param>
        public static void startDrag(JsNumber x, JsNumber y){}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. Note that unlike self,
        /// this.statics() is scope-independent and it always returns the class from which it was called, regardless of what
        /// this points to during run-time
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// totalCreated: 0,
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// var statics = this.statics();
        /// alert(statics.speciesName);     // always equals to 'Cat' no matter what 'this' refers to
        /// // equivalent to: My.Cat.speciesName
        /// alert(this.self.speciesName);   // dependent on 'this'
        /// statics.totalCreated++;
        /// },
        /// clone: function() {
        /// var cloned = new this.self;                      // dependent on 'this'
        /// cloned.groupName = this.statics().speciesName;   // equivalent to: My.Cat.speciesName
        /// return cloned;
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'     // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// },
        /// constructor: function() {
        /// this.callParent();
        /// }
        /// });
        /// var cat = new My.Cat();                 // alerts 'Cat', then alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard(); // alerts 'Cat', then alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));         // alerts 'My.SnowLeopard'
        /// alert(clone.groupName);                 // alerts 'Cat'
        /// alert(My.Cat.totalCreated);             // alerts 3
        /// </code>
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Class">Ext.Class</see></span><div>
        /// </div>
        /// </returns>
        protected static Class statics(){return null;}
        /// <summary>
        /// Internal function to clean up event handlers after the drag
        /// operation is complete
        /// </summary>
        /// <param name="e"><p>the event</p>
        /// </param>
        private static void stopDrag(object e){}
        /// <summary>
        /// Utility to stop event propagation and event default, if these
        /// features are turned on.
        /// </summary>
        /// <param name="e"><p>the event as returned by this.getEvent()</p>
        /// </param>
        public static void stopEvent(object e){}
        /// <summary>
        /// Unlock all drag and drop functionality
        /// </summary>
        public static void unlock(){}
        /// <summary>
        /// Cleans up the drag and drop events and objects.
        /// </summary>
        private static void unregAll(){}
        /// <summary>
        /// This checks to make sure an element exists and is in the DOM.  The
        /// main purpose is to handle cases where innerHTML is used to remove
        /// drag and drop objects from the DOM.  IE provides an 'unspecified
        /// error' when trying to access the offsetParent of such an element
        /// </summary>
        /// <param name="el"><p>the element to check</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true if the element looks usable</p>
        /// </div>
        /// </returns>
        public static bool verifyEl(object el){return false;}
        public DragDropManager(DragDropManagerConfig config){}
        public DragDropManager(){}
        public DragDropManager(params object[] args){}
        /// <summary>
        /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Deprecated inner class for cached elements.</p>
        /// <div>
        /// <p>This class has been <strong>deprecated</strong> </p>
        /// <p>This wrapper isn't that useful</p>
        /// </div>
        /// </summary>
        [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
        public partial class ElementWrapper
        {
            /// <summary>
            /// A reference to the style property
            /// </summary>
            public JsObject css{get;set;}
            /// <summary>
            /// The element
            /// </summary>
            public JsObject el{get;set;}
            /// <summary>
            /// The element id
            /// </summary>
            public JsObject id{get;set;}
            public ElementWrapper(ElementWrapperConfig config){}
            public ElementWrapper(){}
            public ElementWrapper(params object[] args){}
        }
        [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
        public partial class ElementWrapperConfig
        {
            public ElementWrapperConfig(params object[] args){}
        }
        [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
        public partial class ElementWrapperEvents
        {
            public ElementWrapperEvents(params object[] args){}
        }
    }
    #endregion
    #region DragDropManagerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DragDropManagerConfig : Ext.BaseConfig
    {
        public DragDropManagerConfig(params object[] args){}
    }
    #endregion
    #region DragDropManagerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DragDropManagerEvents : Ext.BaseEvents
    {
        public DragDropManagerEvents(params object[] args){}
    }
    #endregion
}