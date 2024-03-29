//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.header
{
    #region Container
    /// <inheritdocs />
    /// <summary>
    /// <p>Container which holds headers and is docked at the top or bottom of a TablePanel.
    /// The HeaderContainer drives resizing/moving/hiding of columns within the TableView.
    /// As headers are hidden, moved or resized the headercontainer is responsible for
    /// triggering changes within the view.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Container : Ext.container.Container
    {
        /// <summary>
        /// Width of the header if no width or flex is specified.
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber defaultWidth;
        /// <summary>
        /// Specify as true to constrain column dragging so that a column cannot be dragged into or out of this column.
        /// <strong>Note that this config is only valid for column headers which contain child column headers, eg:</strong>
        /// <code>{
        /// sealed: true
        /// text: 'ExtJS',
        /// columns: [{
        /// text: '3.0.4',
        /// dataIndex: 'ext304'
        /// }, {
        /// text: '4.1.0',
        /// dataIndex: 'ext410'
        /// }
        /// }
        /// </code>
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool @sealed;
        /// <summary>
        /// Provides the default sortable state for all Headers within this HeaderContainer.
        /// Also turns on or off the menus in the HeaderContainer. Note that the menu is
        /// shared across every header and therefore turning it off will remove the menu
        /// items for every header.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool sortable;
        /// <summary>
        /// HeaderContainer overrides the default weight of 0 for all docked items to 100.
        /// This is so that it has more priority over things like toolbars.
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber weight;
        /// <summary>
        /// True if this HeaderContainer is in fact a group header which contains sub headers.
        /// </summary>
        public bool isGroupHeader{get;set;}
        /// <summary>
        /// Returns the number of grid columns descended from this HeaderContainer.
        /// Group Columns are HeaderContainers. All grid columns are returned, including hidden ones.
        /// </summary>
        public void getColumnCount(){}
        /// <summary>
        /// Returns an array of menu CheckItems corresponding to all immediate children
        /// of the passed Container which have been configured as hideable.
        /// </summary>
        /// <param name="headerContainer">
        /// </param>
        public void getColumnMenu(object headerContainer){}
        /// <summary>
        /// Get the columns used for generating a template via TableChunker.
        /// Returns an array of all columns and their
        /// <li>dataIndex</li>
        /// <li>align</li>
        /// <li>width</li>
        /// <li>id</li>
        /// <li>columnId - used to create an identifying CSS class</li>
        /// <li>cls The tdCls configuration from the Column object</li>
        /// </summary>
        /// <param name="flushCache">
        /// </param>
        private void getColumnsForTpl(object flushCache){}
        /// <summary>
        /// Gets the full width of all columns that are visible.
        /// </summary>
        /// <param name="flushCache">
        /// </param>
        public void getFullWidth(object flushCache){}
        /// <summary>
        /// Returns an array of all columns which map to Store fields. This goes down to the lowest column header
        /// level, and does not return grouped headers which contain sub headers.
        /// </summary>
        /// <param name="refreshCache"><p>If omitted, the cached set of columns will be returned. Pass true to refresh the cache.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Array">Array</see></span><div>
        /// </div>
        /// </returns>
        public JsArray getGridColumns(bool refreshCache){return null;}
        /// <summary>
        /// Get a leaf level header by index regardless of what the nesting
        /// structure is.
        /// </summary>
        /// <param name="The"><p>column index for which to retrieve the column.</p>
        /// </param>
        public void getHeaderAtIndex(JsNumber The){}
        /// <summary>
        /// Returns the index of a leaf level header regardless of what the nesting
        /// structure is.
        /// If a group header is passed, the index of the first leaf level heder within it is returned.
        /// </summary>
        /// <param name="header"><p>The header to find the index of</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The index of the specified column header</p>
        /// </div>
        /// </returns>
        public JsNumber getHeaderIndex(Ext.grid.column.Column header){return null;}
        /// <summary>
        /// For use by column headers in determining whether there are any hideable columns when deciding whether or not
        /// the header menu should be disabled.
        /// </summary>
        /// <param name="refreshCache">
        /// </param>
        private void getHideableColumns(object refreshCache){}
        /// <summary>
        /// Gets all "leaf" menu nodes and returns the checked count for those leaves.
        /// Only includes columns that are hideable via the menu
        /// </summary>
        private void getLeafMenuItems(){}
        /// <summary>
        /// Gets the menu (and will create it if it doesn't already exist)
        /// </summary>
        private void getMenu(){}
        /// <summary>
        /// Returns an array of menu items to be placed into the shared menu
        /// across all headers in this header container.
        /// </summary>
        /// <returns>
        /// <span><see cref="Array">Array</see></span><div><p>menuItems</p>
        /// </div>
        /// </returns>
        public JsArray getMenuItems(){return null;}
        /// <summary>
        /// Returns an array of the visible columns in the grid. This goes down to the lowest column header
        /// level, and does not return grouped headers which contain sub headers.
        /// </summary>
        /// <param name="refreshCache"><p>If omitted, the cached set of columns will be returned. Pass true to refresh the cache.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Array">Array</see></span><div>
        /// </div>
        /// </returns>
        public JsArray getVisibleGridColumns(bool refreshCache){return null;}
        /// <summary>
        /// When passed a column index, returns the closet visible column to that. If the column at the passed index is visible,
        /// that is returned. If it is hidden, either the next visible, or the previous visible column is returned.
        /// </summary>
        /// <param name="index"><p>Position at which to find the closest visible column.</p>
        /// </param>
        public void getVisibleHeaderClosestToIndex(JsNumber index){}
        /// <summary>
        /// Maps the record data to base it on the header id's.
        /// This correlates to the markup/template generated by
        /// TableChunker.
        /// </summary>
        /// <param name="data">
        /// </param>
        /// <param name="rowIdx">
        /// </param>
        /// <param name="record">
        /// </param>
        /// <param name="view">
        /// </param>
        /// <param name="panel">
        /// </param>
        public void prepareData(object data, object rowIdx, object record, object view, object panel){}
        /// <summary>
        /// Temporarily lock the headerCt. This makes it so that clicking on headers
        /// don't trigger actions like sorting or opening of the header menu. This is
        /// done because extraneous events may be fired on the headers after interacting
        /// with a drag drop operation.
        /// </summary>
        private void tempLock(){}
        public Container(Ext.grid.header.ContainerConfig config){}
        public Container(){}
        public Container(params object[] args){}
    }
    #endregion
    #region ContainerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ContainerConfig : Ext.container.ContainerConfig
    {
        /// <summary>
        /// Width of the header if no width or flex is specified.
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber defaultWidth;
        /// <summary>
        /// Specify as true to constrain column dragging so that a column cannot be dragged into or out of this column.
        /// <strong>Note that this config is only valid for column headers which contain child column headers, eg:</strong>
        /// <code>{
        /// sealed: true
        /// text: 'ExtJS',
        /// columns: [{
        /// text: '3.0.4',
        /// dataIndex: 'ext304'
        /// }, {
        /// text: '4.1.0',
        /// dataIndex: 'ext410'
        /// }
        /// }
        /// </code>
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool @sealed;
        /// <summary>
        /// Provides the default sortable state for all Headers within this HeaderContainer.
        /// Also turns on or off the menus in the HeaderContainer. Note that the menu is
        /// shared across every header and therefore turning it off will remove the menu
        /// items for every header.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool sortable;
        /// <summary>
        /// HeaderContainer overrides the default weight of 0 for all docked items to 100.
        /// This is so that it has more priority over things like toolbars.
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber weight;
        public ContainerConfig(params object[] args){}
    }
    #endregion
    #region ContainerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ContainerEvents : Ext.container.ContainerEvents
    {
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void columnhide(Ext.grid.header.Container ct, Ext.grid.column.Column column, object eOpts){}
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>fromIdx</span> : <see cref="Number">Number</see><div>
        /// </div></li><li><span>toIdx</span> : <see cref="Number">Number</see><div>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="fromIdx">
        /// </param>
        /// <param name="toIdx">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void columnmove(Ext.grid.header.Container ct, Ext.grid.column.Column column, JsNumber fromIdx, JsNumber toIdx, object eOpts){}
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>width</span> : <see cref="Number">Number</see><div>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void columnresize(Ext.grid.header.Container ct, Ext.grid.column.Column column, JsNumber width, object eOpts){}
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void columnshow(Ext.grid.header.Container ct, Ext.grid.column.Column column, object eOpts){}
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>e</span> : <see cref="Ext.EventObject">Ext.EventObject</see><div>
        /// </div></li><li><span>t</span> : HTMLElement<div>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="e">
        /// </param>
        /// <param name="t">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void headerclick(Ext.grid.header.Container ct, Ext.grid.column.Column column, EventObject e, object t, object eOpts){}
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>e</span> : <see cref="Ext.EventObject">Ext.EventObject</see><div>
        /// </div></li><li><span>t</span> : HTMLElement<div>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="e">
        /// </param>
        /// <param name="t">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void headertriggerclick(Ext.grid.header.Container ct, Ext.grid.column.Column column, EventObject e, object t, object eOpts){}
        /// <summary>
        /// Fired immediately after the column header menu is created.
        /// </summary>
        /// <param name="ct"><p>This instance</p>
        /// </param>
        /// <param name="menu"><p>The Menu that was created</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void menucreate(Ext.grid.header.Container ct, Ext.menu.Menu menu, object eOpts){}
        /// <summary>
        /// Parameters<li><span>ct</span> : <see cref="Ext.grid.header.Container">Ext.grid.header.Container</see><div><p>The grid's header Container which encapsulates all column headers.</p>
        /// </div></li><li><span>column</span> : <see cref="Ext.grid.column.Column">Ext.grid.column.Column</see><div><p>The Column header Component which provides the column definition</p>
        /// </div></li><li><span>direction</span> : <see cref="String">String</see><div>
        /// </div></li><li><span>eOpts</span> : <see cref="Object">Object</see><div><p>The options object passed to <see>Ext.util.Observable.addListener</see>.</p>
        /// </div></li>
        /// </summary>
        /// <param name="ct"><p>The grid's header Container which encapsulates all column headers.</p>
        /// </param>
        /// <param name="column"><p>The Column header Component which provides the column definition</p>
        /// </param>
        /// <param name="direction">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void sortchange(Ext.grid.header.Container ct, Ext.grid.column.Column column, JsString direction, object eOpts){}
        public ContainerEvents(params object[] args){}
    }
    #endregion
}
