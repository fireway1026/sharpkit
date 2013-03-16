// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.element
{
    /// <summary>
	/// <para>Contains methods to control and query the element&#8217;s clip property</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.element.Clip", OmitOptionalParameters = true, Export = false)]
    public partial class Clip 
    {
		#region Methods

		public Clip() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Compiles the given clipping into a CSS compatible string. This
		/// is a simple square which describes the visible area of an DOM element.
		/// Changing the clipping does not change the dimensions of
		/// an element.</para>
		/// </summary>
		/// <param name="map">Map which contains left, top width and height of the clipped area.</param>
		/// <returns>CSS compatible string</returns>
		[JsMethod(Name = "compile")]
		public static string Compile(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the clipping of the given element.</para>
		/// </summary>
		/// <param name="element">DOM element to query</param>
		/// <param name="mode">Choose one of the modes qx.bom.element.Style#COMPUTED_MODE, qx.bom.element.Style#CASCADED_MODE, qx.bom.element.Style#LOCAL_MODE. The computed mode is the default one.</param>
		/// <returns>Map which contains left, top width and height of the clipped area. Each one could be null or any integer value.</returns>
		[JsMethod(Name = "get")]
		public static object Get(qx.html.Element element, double mode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the clipping of the given DOM element.</para>
		/// </summary>
		/// <param name="element">DOM element to modify</param>
		[JsMethod(Name = "reset")]
		public static void Reset(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the clipping of the given element. This is a simple
		/// square which describes the visible area of an DOM element.
		/// Changing the clipping does not change the dimensions of
		/// an element.</para>
		/// </summary>
		/// <param name="element">DOM element to modify</param>
		/// <param name="map">A map with one or more of these available keys: left, top, width, height.</param>
		[JsMethod(Name = "set")]
		public static void Set(qx.html.Element element, object map) { throw new NotImplementedException(); }

		#endregion Methods
    }
}