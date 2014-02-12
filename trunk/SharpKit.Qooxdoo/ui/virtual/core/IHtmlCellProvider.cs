// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.core
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>A HTML cell provider provides the <see cref="qx.ui.virtual.layer.HtmlCell"/>
	/// with HTML fragments to render the cells.</para>
	/// </summary>
	public interface IHtmlCellProvider
    {
		#region Methods

		/// <summary>
		/// <para>Returns all relevant properties of the cell:
		/// <list type="bullet">
		/// <item>classes (String): Space separated class names</item>
		/// <item>style (String): CSS styles</item>
		/// <item>attributes (String): Space separated attributes</item>
		/// <item>content (String): HTML fragment of the innerHTML of the cell</item>
		/// <item>insets (Array): insets (padding + border) of the cell as
		/// two-dimensional array.</item>
		/// </list</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row index.</param>
		/// <param name="column">The cell&#8217;s column index.</param>
		/// <returns>Cell properties (see above.)</returns>
		object GetCellProperties(double row, double column);

		#endregion Methods
    }
}