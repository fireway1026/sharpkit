//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.feature
{
    #region Feature
    /// <summary>
    /// <p>A feature is a type of plugin that is specific to the <see cref="Ext.grid.Panel">Ext.grid.Panel</see>. It provides several
    /// hooks that allows the developer to inject additional functionality at certain points throughout the
    /// grid creation cycle. This class provides the base template methods that are available to the developer,
    /// it should be extended.</p>
    /// <p>There are several built in features that extend this class, for example:</p>
    /// <ul>
    /// <li><see cref="Ext.grid.feature.Grouping">Ext.grid.feature.Grouping</see> - Shows grid rows in groups as specified by the <see cref="Ext.data.Store">Ext.data.Store</see></li>
    /// <li><see cref="Ext.grid.feature.RowBody">Ext.grid.feature.RowBody</see> - Adds a body section for each grid row that can contain markup.</li>
    /// <li><see cref="Ext.grid.feature.Summary">Ext.grid.feature.Summary</see> - Adds a summary row at the bottom of the grid with aggregate totals for a column.</li>
    /// </ul>
    /// <h2>Using Features</h2>
    /// <p>A feature is added to the grid by specifying it an array of features in the configuration:</p>
    /// <pre><code>var groupingFeature = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.feature.Grouping">Ext.grid.feature.Grouping</see>');
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// // other options
    /// features: [groupingFeature]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Feature : Ext.util.Observable
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. This
        /// should be a valid listeners config object as specified in the addListener example for attaching multiple
        /// handlers at once.
        /// <strong>DOM events from Ext JS <see cref="Ext.Component">Components</see></strong>
        /// While <em>some</em> Ext JS Component classes export selected DOM events (e.g. "click", "mouseover" etc), this is usually
        /// only done when extra value can be added. For example the <see cref="Ext.view.View">DataView</see>'s <strong><c><see cref="Ext.view.ViewEvents.itemclick">itemclick</see></c></strong> event passing the node clicked on. To access DOM events directly from a
        /// child element of a Component, we need to specify the <c>element</c> option to identify the Component property to add a
        /// DOM listener to:
        /// <code>new <see cref="Ext.panel.Panel">Ext.panel.Panel</see>({
        /// width: 400,
        /// height: 200,
        /// dockedItems: [{
        /// xtype: 'toolbar'
        /// }],
        /// listeners: {
        /// click: {
        /// element: 'el', //bind to the underlying el property on the panel
        /// fn: function(){ console.log('click el'); }
        /// },
        /// dblclick: {
        /// element: 'body', //bind to the underlying body property on the panel
        /// fn: function(){ console.log('dblclick body'); }
        /// }
        /// }
        /// });
        /// </code>
        /// </summary>
        public JsObject listeners;
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        public JsString @className{get;set;}
        /// <summary>
        /// Most features will not modify the data returned to the view.
        /// This is limited to one feature that manipulates the data per grid view.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool collectData{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject configMap{get;set;}
        /// <summary>
        /// True when feature is disabled.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool disabled{get;set;}
        /// <summary>
        /// Prefix to use when firing events on the view.
        /// For example a prefix of group would expose "groupclick", "groupcontextmenu", "groupdblclick".
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString eventPrefix{get;set;}
        /// <summary>
        /// Selector used to determine when to fire the event with the eventPrefix.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString eventSelector{get;set;}
        /// <summary>
        /// Initial suspended call count. Incremented when suspendEvents is called, decremented when resumeEvents is called.
        /// Defaults to: <c>0</c>
        /// </summary>
        public JsNumber eventsSuspended{get;set;}
        /// <summary>
        /// Reference to the grid panel
        /// Defaults to: <c>null</c>
        /// </summary>
        public Ext.grid.Panel grid{get;set;}
        /// <summary>
        /// Most features will expose additional events, some may not and will
        /// need to change this to false.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool hasFeatureEvent{get;set;}
        /// <summary>
        /// This object holds a key for any event that has a listener. The listener may be set
        /// directly on the instance, or on its class or a super class (via observe) or
        /// on the MVC EventBus. The values of this object are truthy
        /// (a non-zero number) and falsy (0 or undefined). They do not represent an exact count
        /// of listeners. The value for an event is truthy if the event must be fired and is
        /// falsy if there is no need to fire the event.
        /// The intended use of this property is to avoid the expense of fireEvent calls when
        /// there are no listeners. This can be particularly helpful when one would otherwise
        /// have to call fireEvent hundreds or thousands of times. It is used like this:
        /// <code> if (this.hasListeners.foo) {
        /// this.fireEvent('foo', this, arg1);
        /// }
        /// </code>
        /// </summary>
        public JsObject hasListeners{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        public JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isInstance{get;set;}
        /// <summary>
        /// true in this class to identify an object as an instantiated Observable, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isObservable{get;set;}
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
        public Class self{get;set;}
        /// <summary>
        /// Reference to the TableView.
        /// Defaults to: <c>null</c>
        /// </summary>
        public Ext.view.Table view{get;set;}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire.
        /// </summary>
        /// <param name="eventNames"><p>Either an object with event names as properties with
        /// a value of <c>true</c>. For example:</p>
        /// <pre><code>this.addEvents({
        /// storeloaded: true,
        /// storecleared: true
        /// });
        /// </code></pre>
        /// <p>Or any number of event names as separate parameters. For example:</p>
        /// <pre><code>this.addEvents('storeloaded', 'storecleared');
        /// </code></pre>
        /// </param>
        public virtual void addEvents(object eventNames){}
        /// <summary>
        /// Appends an event handler to this object.  For example:
        /// <code>myGridPanel.on("mouseover", this.onMouseOver, this);
        /// </code>
        /// The method also allows for a single argument to be passed which is a config object
        /// containing properties which specify multiple events. For example:
        /// <code>myGridPanel.on({
        /// cellClick: this.onCellClick,
        /// mouseover: this.onMouseOver,
        /// mouseout: this.onMouseOut,
        /// scope: this // Important. Ensure "this" is correct during handler execution
        /// });
        /// </code>
        /// One can also specify options for each event handler separately:
        /// <code>myGridPanel.on({
        /// cellClick: {fn: this.onCellClick, scope: this, single: true},
        /// mouseover: {fn: panel.onMouseOver, scope: panel}
        /// });
        /// </code>
        /// <em>Names</em> of methods in a specified scope may also be used. Note that
        /// <c>scope</c> MUST be specified to use this option:
        /// <code>myGridPanel.on({
        /// cellClick: {fn: 'onCellClick', scope: this, single: true},
        /// mouseover: {fn: 'onMouseOver', scope: panel}
        /// });
        /// </code>
        /// </summary>
        /// <param name="eventName"><p>The name of the event to listen for.
        /// May also be an object who's property names are event names.</p>
        /// </param>
        /// <param name="fn"><p>The method the event invokes, or <em>if <c>scope</c> is specified, the </em>name* of the method within
        /// the specified <c>scope</c>.  Will be called with arguments
        /// given to <see cref="Ext.util.Observable.fireEvent">fireEvent</see> plus the <c>options</c> parameter described below.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the handler function is
        /// executed. <strong>If omitted, defaults to the object which fired the event.</strong></p>
        /// </param>
        /// <param name="options"><p>An object containing handler configuration.</p>
        /// <p><strong>Note:</strong> Unlike in ExtJS 3.x, the options object will also be passed as the last
        /// argument to every event handler.</p>
        /// <p>This object may contain any of the following properties:</p>
        /// <ul><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope (<c>this</c> reference) in which the handler function is executed. <strong>If omitted,
        /// defaults to the object which fired the event.</strong></p>
        /// </div></li><li><span>delay</span> : <see cref="Number">Number</see><div><p>The number of milliseconds to delay the invocation of the handler after the event fires.</p>
        /// </div></li><li><span>single</span> : <see cref="bool">Boolean</see><div><p>True to add a handler to handle just the next firing of the event, and then remove itself.</p>
        /// </div></li><li><span>buffer</span> : <see cref="Number">Number</see><div><p>Causes the handler to be scheduled to run in an <see cref="Ext.util.DelayedTask">Ext.util.DelayedTask</see> delayed
        /// by the specified number of milliseconds. If the event fires again within that time,
        /// the original handler is <em>not</em> invoked, but the new handler is scheduled in its place.</p>
        /// </div></li><li><span>target</span> : <see cref="Ext.util.Observable">Ext.util.Observable</see><div><p>Only call the handler if the event was fired on the target Observable, <em>not</em> if the event
        /// was bubbled up from a child Observable.</p>
        /// </div></li><li><span>element</span> : <see cref="String">String</see><div><p><strong>This option is only valid for listeners bound to <see cref="Ext.Component">Components</see>.</strong>
        /// The name of a Component property which references an element to add a listener to.</p>
        /// <p>  This option is useful during Component construction to add DOM event listeners to elements of
        /// <see cref="Ext.Component">Components</see> which will exist only after the Component is rendered.
        /// For example, to add a click listener to a Panel's body:</p>
        /// <pre><code>  new <see cref="Ext.panel.Panel">Ext.panel.Panel</see>({
        /// title: 'The title',
        /// listeners: {
        /// click: this.handlePanelClick,
        /// element: 'body'
        /// }
        /// });
        /// </code></pre>
        /// <p><strong>Combining Options</strong></p>
        /// <p>Using the options argument, it is possible to combine different types of listeners:</p>
        /// <p>A delayed, one-time listener.</p>
        /// <pre><code>myPanel.on('hide', this.handleClick, this, {
        /// single: true,
        /// delay: 100
        /// });
        /// </code></pre>
        /// </div></li></ul></param>
        public virtual void addListener(object eventName, System.Delegate fn=null, object scope=null, object options=null){}
        /// <summary>
        /// Adds listeners to any Observable object (or Ext.Element) which are automatically removed when this Component is
        /// destroyed.
        /// </summary>
        /// <param name="item"><p>The item to which to add a listener/listeners.</p>
        /// </param>
        /// <param name="ename"><p>The event name, or an object containing event name properties.</p>
        /// </param>
        /// <param name="fn"><p>If the <c>ename</c> parameter was an event name, this is the handler function.</p>
        /// </param>
        /// <param name="scope"><p>If the <c>ename</c> parameter was an event name, this is the scope (<c>this</c> reference)
        /// in which the handler function is executed.</p>
        /// </param>
        /// <param name="opt"><p>If the <c>ename</c> parameter was an event name, this is the
        /// <see cref="Ext.util.Observable.addListener">addListener</see> options.</p>
        /// </param>
        public virtual void addManagedListener(object item, object ename, System.Delegate fn=null, object scope=null, object opt=null){}
        /// <summary>
        /// Approriate place to attach events to the view, selectionmodel, headerCt, etc
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        public virtual void attachEvents(){}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners
        /// </summary>
        public virtual void clearListeners(){}
        /// <summary>
        /// Removes all managed listeners for this object.
        /// </summary>
        public virtual void clearManagedListeners(){}
        /// <summary>
        /// Continue to fire event.
        /// </summary>
        /// <param name="eventName">
        /// </param>
        /// <param name="args">
        /// </param>
        /// <param name="bubbles">
        /// </param>
        public virtual void continueFireEvent(JsString eventName, object args=null, object bubbles=null){}
        /// <summary>
        /// Creates an event handling function which refires the event from this object as the passed event name.
        /// </summary>
        /// <param name="newName">
        /// </param>
        /// <param name="beginEnd"><p>The caller can specify on which indices to slice</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div>
        /// </div>
        /// </returns>
        public virtual System.Delegate createRelayer(object newName, object beginEnd=null){return null;}
        /// <summary>
        /// Disables the feature.
        /// </summary>
        public void disable(){}
        /// <summary>
        /// Enables the feature.
        /// </summary>
        public void enable(){}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. There is no implementation in the Observable base class.
        /// This is commonly used by Ext.Components to bubble events to owner Containers.
        /// See <see cref="Ext.Component.getBubbleTarget">Ext.Component.getBubbleTarget</see>. The default implementation in <see cref="Ext.Component">Ext.Component</see> returns the
        /// Component's immediate owner. But if a known target is required, this can be overridden to access the
        /// required target more quickly.
        /// Example:
        /// <code><see cref="Ext.ExtContext.override">Ext.override</see>(<see cref="Ext.form.field.Base">Ext.form.field.Base</see>, {
        /// //  Add functionality to Field's initComponent to enable the change event to bubble
        /// initComponent : <see cref="Ext.Function.createSequence">Ext.Function.createSequence</see>(Ext.form.field.Base.prototype.initComponent, function() {
        /// this.enableBubble('change');
        /// }),
        /// //  We know that we want Field's events to bubble directly to the FormPanel.
        /// getBubbleTarget : function() {
        /// if (!this.formPanel) {
        /// this.formPanel = this.findParentByType('form');
        /// }
        /// return this.formPanel;
        /// }
        /// });
        /// var myForm = new Ext.formPanel({
        /// title: 'User Details',
        /// items: [{
        /// ...
        /// }],
        /// listeners: {
        /// change: function() {
        /// // Title goes red if form has been modified.
        /// myForm.header.setStyle('color', 'red');
        /// }
        /// }
        /// });
        /// </code>
        /// </summary>
        /// <param name="eventNames"><p>The event name to bubble, or an Array of event names.</p>
        /// </param>
        public virtual void enableBubble(object eventNames){}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addListener).
        /// An event may be set to bubble up an Observable parent hierarchy (See <see cref="Ext.Component.getBubbleTarget">Ext.Component.getBubbleTarget</see>) by
        /// calling <see cref="Ext.util.Observable.enableBubble">enableBubble</see>.
        /// </summary>
        /// <param name="eventName"><p>The name of the event to fire.</p>
        /// </param>
        /// <param name="args"><p>Variable number of parameters are passed to handlers.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>returns false if any of the handlers return false otherwise it returns true.</p>
        /// </div>
        /// </returns>
        public virtual bool fireEvent(JsString eventName, params object[] args){return false;}
        /// <summary>
        /// Provide additional data to the prepareData call within the grid view.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="data"><p>The data for this particular record.</p>
        /// </param>
        /// <param name="idx"><p>The row index for this record.</p>
        /// </param>
        /// <param name="record"><p>The record instance</p>
        /// </param>
        /// <param name="orig"><p>The original result from the prepareData call to massage.</p>
        /// </param>
        public virtual void getAdditionalData(object data, JsNumber idx, Ext.data.Model record, object orig){}
        /// <summary>
        /// Gets the bubbling parent for an Observable
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.util.Observable">Ext.util.Observable</see></span><div><p>The bubble parent. null is returned if no bubble target exists</p>
        /// </div>
        /// </returns>
        public virtual Ext.util.Observable getBubbleParent(){return null;}
        /// <summary>
        /// Abstract method to be overriden when a feature should add additional
        /// arguments to its event signature. By default the event will fire:
        /// <li>view - The underlying <see cref="Ext.view.Table">Ext.view.Table</see></li>
        /// <li>featureTarget - The matched element by the defined <see cref="Ext.grid.feature.Feature.eventSelector">eventSelector</see></li>
        /// The method must also return the eventName as the first index of the array
        /// to be passed to fireEvent.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="eventName">
        /// </param>
        /// <param name="view">
        /// </param>
        /// <param name="featureTarget">
        /// </param>
        /// <param name="e">
        /// </param>
        public virtual void getFireEventArgs(object eventName, object view, object featureTarget, object e){}
        /// <summary>
        /// Allows a feature to inject member methods into the metaRowTpl. This is
        /// important for embedding functionality which will become part of the proper
        /// row tpl.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        public virtual void getMetaRowTplFragments(){}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event, or whether the event bubbles. The answer
        /// indicates whether the event needs firing or not.
        /// </summary>
        /// <param name="eventName"><p>The name of the event to check for</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p><c>true</c> if the event is being listened for or bubbles, else <c>false</c></p>
        /// </div>
        /// </returns>
        public virtual bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener.
        /// Adds listeners to any Observable object (or <see cref="Ext.dom.Element">Ext.Element</see>) which are automatically removed when this Component is
        /// destroyed.
        /// </summary>
        /// <param name="item"><p>The item to which to add a listener/listeners.</p>
        /// </param>
        /// <param name="ename"><p>The event name, or an object containing event name properties.</p>
        /// </param>
        /// <param name="fn"><p>If the <c>ename</c> parameter was an event name, this is the handler function.</p>
        /// </param>
        /// <param name="scope"><p>If the <c>ename</c> parameter was an event name, this is the scope (<c>this</c> reference)
        /// in which the handler function is executed.</p>
        /// </param>
        /// <param name="opt"><p>If the <c>ename</c> parameter was an event name, this is the
        /// <see cref="Ext.util.Observable.addListener">addListener</see> options.</p>
        /// </param>
        public virtual void mon(object item, object ename, System.Delegate fn=null, object scope=null, object opt=null){}
        /// <summary>
        /// Shorthand for removeManagedListener.
        /// Removes listeners that were added by the <see cref="Ext.util.Observable.mon">mon</see> method.
        /// </summary>
        /// <param name="item"><p>The item from which to remove a listener/listeners.</p>
        /// </param>
        /// <param name="ename"><p>The event name, or an object containing event name properties.</p>
        /// </param>
        /// <param name="fn"><p>If the <c>ename</c> parameter was an event name, this is the handler function.</p>
        /// </param>
        /// <param name="scope"><p>If the <c>ename</c> parameter was an event name, this is the scope (<c>this</c> reference)
        /// in which the handler function is executed.</p>
        /// </param>
        public virtual void mun(object item, object ename, System.Delegate fn=null, object scope=null){}
        /// <summary>
        /// Allows a feature to mutate the metaRowTpl.
        /// The array received as a single argument can be manipulated to add things
        /// on the end/begining of a particular row.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="metaRowTplArray"><p>A String array to be used constructing an <see cref="Ext.XTemplate">XTemplate</see>
        /// to render the rows. This Array may be changed to provide extra DOM structure.</p>
        /// </param>
        public virtual void mutateMetaRowTpl(JsArray metaRowTplArray){}
        /// <summary>
        /// Shorthand for addListener.
        /// Appends an event handler to this object.  For example:
        /// <code>myGridPanel.on("mouseover", this.onMouseOver, this);
        /// </code>
        /// The method also allows for a single argument to be passed which is a config object
        /// containing properties which specify multiple events. For example:
        /// <code>myGridPanel.on({
        /// cellClick: this.onCellClick,
        /// mouseover: this.onMouseOver,
        /// mouseout: this.onMouseOut,
        /// scope: this // Important. Ensure "this" is correct during handler execution
        /// });
        /// </code>
        /// One can also specify options for each event handler separately:
        /// <code>myGridPanel.on({
        /// cellClick: {fn: this.onCellClick, scope: this, single: true},
        /// mouseover: {fn: panel.onMouseOver, scope: panel}
        /// });
        /// </code>
        /// <em>Names</em> of methods in a specified scope may also be used. Note that
        /// <c>scope</c> MUST be specified to use this option:
        /// <code>myGridPanel.on({
        /// cellClick: {fn: 'onCellClick', scope: this, single: true},
        /// mouseover: {fn: 'onMouseOver', scope: panel}
        /// });
        /// </code>
        /// </summary>
        /// <param name="eventName"><p>The name of the event to listen for.
        /// May also be an object who's property names are event names.</p>
        /// </param>
        /// <param name="fn"><p>The method the event invokes, or <em>if <c>scope</c> is specified, the </em>name* of the method within
        /// the specified <c>scope</c>.  Will be called with arguments
        /// given to <see cref="Ext.util.Observable.fireEvent">fireEvent</see> plus the <c>options</c> parameter described below.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the handler function is
        /// executed. <strong>If omitted, defaults to the object which fired the event.</strong></p>
        /// </param>
        /// <param name="options"><p>An object containing handler configuration.</p>
        /// <p><strong>Note:</strong> Unlike in ExtJS 3.x, the options object will also be passed as the last
        /// argument to every event handler.</p>
        /// <p>This object may contain any of the following properties:</p>
        /// <ul><li><span>scope</span> : <see cref="Object">Object</see><div><p>The scope (<c>this</c> reference) in which the handler function is executed. <strong>If omitted,
        /// defaults to the object which fired the event.</strong></p>
        /// </div></li><li><span>delay</span> : <see cref="Number">Number</see><div><p>The number of milliseconds to delay the invocation of the handler after the event fires.</p>
        /// </div></li><li><span>single</span> : <see cref="bool">Boolean</see><div><p>True to add a handler to handle just the next firing of the event, and then remove itself.</p>
        /// </div></li><li><span>buffer</span> : <see cref="Number">Number</see><div><p>Causes the handler to be scheduled to run in an <see cref="Ext.util.DelayedTask">Ext.util.DelayedTask</see> delayed
        /// by the specified number of milliseconds. If the event fires again within that time,
        /// the original handler is <em>not</em> invoked, but the new handler is scheduled in its place.</p>
        /// </div></li><li><span>target</span> : <see cref="Ext.util.Observable">Ext.util.Observable</see><div><p>Only call the handler if the event was fired on the target Observable, <em>not</em> if the event
        /// was bubbled up from a child Observable.</p>
        /// </div></li><li><span>element</span> : <see cref="String">String</see><div><p><strong>This option is only valid for listeners bound to <see cref="Ext.Component">Components</see>.</strong>
        /// The name of a Component property which references an element to add a listener to.</p>
        /// <p>  This option is useful during Component construction to add DOM event listeners to elements of
        /// <see cref="Ext.Component">Components</see> which will exist only after the Component is rendered.
        /// For example, to add a click listener to a Panel's body:</p>
        /// <pre><code>  new <see cref="Ext.panel.Panel">Ext.panel.Panel</see>({
        /// title: 'The title',
        /// listeners: {
        /// click: this.handlePanelClick,
        /// element: 'body'
        /// }
        /// });
        /// </code></pre>
        /// <p><strong>Combining Options</strong></p>
        /// <p>Using the options argument, it is possible to combine different types of listeners:</p>
        /// <p>A delayed, one-time listener.</p>
        /// <pre><code>myPanel.on('hide', this.handleClick, this, {
        /// single: true,
        /// delay: 100
        /// });
        /// </code></pre>
        /// </div></li></ul></param>
        public virtual void on(object eventName, System.Delegate fn=null, object scope=null, object options=null){}
        /// <summary>
        /// Prepares a given class for observable instances. This method is called when a
        /// class derives from this class or uses this class as a mixin.
        /// </summary>
        /// <param name="T"><p>The class constructor to prepare.</p>
        /// </param>
        public virtual void prepareClass(System.Delegate T){}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this.
        /// For example if you are extending Grid, you might decide to forward some events from store.
        /// So you can do this inside your initComponent:
        /// <code>this.relayEvents(this.getStore(), ['load']);
        /// </code>
        /// The grid instance will then have an observable 'load' event which will be passed the
        /// parameters of the store's load event and any function fired with the grid's load event
        /// would have access to the grid using the <c>this</c> keyword.
        /// </summary>
        /// <param name="origin"><p>The Observable whose events this object is to relay.</p>
        /// </param>
        /// <param name="events"><p>Array of event names to relay.</p>
        /// </param>
        /// <param name="prefix"><p>A common prefix to prepend to the event names. For example:</p>
        /// <pre><code>this.relayEvents(this.getStore(), ['load', 'clear'], 'store');
        /// </code></pre>
        /// <p>Now the grid will forward 'load' and 'clear' events of store as 'storeload' and 'storeclear'.</p>
        /// </param>
        public virtual void relayEvents(object origin, JsArray<String> events, object prefix=null){}
        /// <summary>
        /// Removes an event handler.
        /// </summary>
        /// <param name="eventName"><p>The type of event the handler was associated with.</p>
        /// </param>
        /// <param name="fn"><p>The handler to remove. <strong>This must be a reference to the function passed into the
        /// <see cref="Ext.util.Observable.addListener">addListener</see> call.</strong></p>
        /// </param>
        /// <param name="scope"><p>The scope originally specified for the handler. It must be the same as the
        /// scope argument specified in the original call to <see cref="Ext.util.Observable.addListener">addListener</see> or the listener will not be removed.</p>
        /// </param>
        public virtual void removeListener(JsString eventName, System.Delegate fn, object scope=null){}
        /// <summary>
        /// Removes listeners that were added by the mon method.
        /// </summary>
        /// <param name="item"><p>The item from which to remove a listener/listeners.</p>
        /// </param>
        /// <param name="ename"><p>The event name, or an object containing event name properties.</p>
        /// </param>
        /// <param name="fn"><p>If the <c>ename</c> parameter was an event name, this is the handler function.</p>
        /// </param>
        /// <param name="scope"><p>If the <c>ename</c> parameter was an event name, this is the scope (<c>this</c> reference)
        /// in which the handler function is executed.</p>
        /// </param>
        public virtual void removeManagedListener(object item, object ename, System.Delegate fn=null, object scope=null){}
        /// <summary>
        /// Remove a single managed listener item
        /// </summary>
        /// <param name="isClear"><p>True if this is being called during a clear</p>
        /// </param>
        /// <param name="managedListener"><p>The managed listener item
        /// See removeManagedListener for other args</p>
        /// </param>
        public virtual void removeManagedListenerItem(bool isClear, object managedListener){}
        /// <summary>
        /// Resumes firing events (see suspendEvents).
        /// If events were suspended using the <c>queueSuspended</c> parameter, then all events fired
        /// during event suspension will be sent to any listeners now.
        /// </summary>
        public virtual void resumeEvents(){}
        /// <summary>
        /// Suspends the firing of all events. (see resumeEvents)
        /// </summary>
        /// <param name="queueSuspended"><p>Pass as true to queue up suspended events to be fired
        /// after the <see cref="Ext.util.Observable.resumeEvents">resumeEvents</see> call instead of discarding all suspended events.</p>
        /// </param>
        public virtual void suspendEvents(bool queueSuspended){}
        /// <summary>
        /// Shorthand for removeListener.
        /// Removes an event handler.
        /// </summary>
        /// <param name="eventName"><p>The type of event the handler was associated with.</p>
        /// </param>
        /// <param name="fn"><p>The handler to remove. <strong>This must be a reference to the function passed into the
        /// <see cref="Ext.util.Observable.addListener">addListener</see> call.</strong></p>
        /// </param>
        /// <param name="scope"><p>The scope originally specified for the handler. It must be the same as the
        /// scope argument specified in the original call to <see cref="Ext.util.Observable.addListener">addListener</see> or the listener will not be removed.</p>
        /// </param>
        public virtual void un(JsString eventName, System.Delegate fn, object scope=null){}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        [JsProperty(Name="$onExtended")]
        private static JsArray @onExtended{get;set;}
        public Feature(FeatureConfig config){}
        public Feature(){}
        public Feature(params object[] args){}
    }
    #endregion
    #region FeatureConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FeatureConfig : Ext.util.ObservableConfig
    {
        public FeatureConfig(params object[] args){}
    }
    #endregion
    #region FeatureEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FeatureEvents : Ext.util.ObservableEvents
    {
        public FeatureEvents(params object[] args){}
    }
    #endregion
}
