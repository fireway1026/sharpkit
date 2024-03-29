// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.virtualx.layer
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>An extended WidgetCell layer, which adds the possibility to specify row and
	/// column spans for specific cells.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.layer.WidgetCellSpan", OmitOptionalParameters = true, Export = false)]
    public partial class WidgetCellSpan : qx.ui.virtualx.layer.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Whether the widget is anonymous.</para>
		/// <para>Anonymous widgets are ignored in the event hierarchy. This is useful
		/// for combined widgets where the internal structure do not have a custom
		/// appearance with a different styling from the element around. This is
		/// especially true for widgets like checkboxes or buttons where the text
		/// or icon are handled synchronously for state changes to the outer widget.</para>
		/// </summary>
		[JsProperty(Name = "anonymous", NativeField = true)]
		public bool Anonymous { get; set; }

		#endregion Properties

		#region Methods

		public WidgetCellSpan() { throw new NotImplementedException(); }

		/// <param name="widgetCellProvider">This class manages the life cycle of the cell widgets.</param>
		/// <param name="rowConfig">The row configuration of the pane in which the cells will be rendered</param>
		/// <param name="columnConfig">The column configuration of the pane in which the cells will be rendered</param>
		public WidgetCellSpan(qx.ui.virtualx.core.IWidgetCellProvider widgetCellProvider, qx.ui.virtualx.core.Axis rowConfig, qx.ui.virtualx.core.Axis columnConfig) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the widget used to render the given cell. May return null if the
		/// cell isn&#8217;t rendered currently rendered.</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row index</param>
		/// <param name="column">The cell&#8217;s column index</param>
		/// <returns>the widget used to render the given cell or null</returns>
		[JsMethod(Name = "getRenderedCellWidget")]
		public qx.ui.core.LayoutItem GetRenderedCellWidget(double row, double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the row and column span for a specific cell</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row</param>
		/// <param name="column">The cell&#8217;s column</param>
		/// <param name="rowSpan">The number of rows the cells spans</param>
		/// <param name="columnSpan">The number of columns the cells spans</param>
		[JsMethod(Name = "setCellSpan")]
		public void SetCellSpan(double row, double column, double rowSpan, double columnSpan) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// <para>The supported keys of the layout options map depend on the layout manager
		/// used to position the widget. The options are documented in the class
		/// documentation of each layout manager <see cref="qx.ui.layout"/>.</para>
		/// </summary>
		/// <param name="child">the widget to add.</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "add")]
		public void Add(LayoutItem child, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget after another already inserted widget</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="after">Widget, after which the new widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(LayoutItem child, LayoutItem after, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child widget at the specified index</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="index">Index, at which the widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(LayoutItem child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget before another already inserted widget</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="before">Widget before the new widget will be inserted.</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(LayoutItem child, LayoutItem before, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public LayoutItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given widget if it is
		/// a child widget. Otherwise it returns -1.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">the widget to query for</param>
		/// <returns>The index position or -1 when the given widget is no child of this layout.</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(Widget child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child widget.</para>
		/// </summary>
		/// <param name="child">the widget to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		/// <returns>An array of the removed children.</returns>
		[JsMethod(Name = "removeAll")]
		public JsArray RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the widget at the specified index.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="index">Index of the widget to remove.</param>
		/// <returns>The child removed.</returns>
		[JsMethod(Name = "removeAt")]
		public LayoutItem RemoveAt(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mapping of protected methods to public.
		/// This omits an additional function call when using these methods. Call
		/// this methods in the defer block of the including class.</para>
		/// </summary>
		/// <param name="members">The including classes members map</param>
		[JsMethod(Name = "remap")]
		public static void Remap(object members) { throw new NotImplementedException(); }

		#endregion Methods
    }
}