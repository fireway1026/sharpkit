// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive.headfoot
{
    /// <summary>
	/// <para>A header for a standard table.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.headfoot.TableHeading", OmitOptionalParameters = true, Export = false)]
    public partial class TableHeading : qx.ui.progressive.headfoot.Abstract
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		#endregion Properties

		#region Methods

		public TableHeading() { throw new NotImplementedException(); }

		/// <param name="columnWidths">The set of widths, minimum widths, and maximum widths to be used for each of the columns in the table.</param>
		/// <param name="labelArr">Array of labels, one for each of the columns.</param>
		public TableHeading(qx.ui.progressive.renderer.table.Widths columnWidths, JsArray labelArr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is required by the box layout. If returns an array of items
		/// to relayout.</para>
		/// </summary>
		/// <returns>List of child items</returns>
		[JsMethod(Name = "getLayoutChildren")]
		public JsArray GetLayoutChildren() { throw new NotImplementedException(); }

		[JsMethod(Name = "join")]
		public void Join(object progressive) { throw new NotImplementedException(); }

		#endregion Methods
    }
}