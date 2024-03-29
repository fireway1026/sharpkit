// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Includes library functions to work with the client&#8217;s viewport (window).
	/// Orientation related functions are point to window.top as default.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Viewport", OmitOptionalParameters = true, Export = false)]
    public partial class Viewport 
    {
		#region Methods

		public Viewport() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current height of the viewport (excluding the horizontal scrollbar
		/// if present).</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>The Height of the viewable area of the page (excluding scrollbars).</returns>
		[JsMethod(Name = "getHeight")]
		public static double GetHeight(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current orientation of the viewport in degree.</para>
		/// <para>All possible values and their meaning:</para>
		/// <list type="bullet">
		/// <item>-90: &#8220;Landscape&#8221;</item>
		/// <item>0: &#8220;Portrait&#8221;</item>
		/// <item>90: &#8220;Landscape&#8221;</item>
		/// <item>180: &#8220;Portrait&#8221;</item>
		/// </list
		/// </summary>
		/// <param name="win">The window to query. (Default = top window)</param>
		/// <returns>The current orientation in degree</returns>
		[JsMethod(Name = "getOrientation")]
		public static double GetOrientation(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the scroll position of the viewport</para>
		/// <para>All clients except IE pageXOffset.
		/// As this is easier to evaluate we prefer this property over scrollLeft.
		/// Since the window could differ from the one the application is running in, we can&#8217;t
		/// use a one-time environment check to decide which property to use.</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>Scroll position in pixels from left edge, always a positive integer or zero</returns>
		[JsMethod(Name = "getScrollLeft")]
		public static double GetScrollLeft(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the scroll position of the viewport</para>
		/// <para>All clients except MSHTML support the non-standard property pageYOffset.
		/// As this is easier to evaluate we prefer this property over scrollTop.
		/// Since the window could differ from the one the application is running in, we can&#8217;t
		/// use a one-time environment check to decide which property to use.</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>Scroll position in pixels from top edge, always a positive integer or zero</returns>
		[JsMethod(Name = "getScrollTop")]
		public static double GetScrollTop(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current width of the viewport (excluding the vertical scrollbar
		/// if present).</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>The width of the viewable area of the page (excluding scrollbars).</returns>
		[JsMethod(Name = "getWidth")]
		public static double GetWidth(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the viewport orientation is currently in landscape mode.</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>true when the viewport orientation is currently in landscape mode.</returns>
		[JsMethod(Name = "isLandscape")]
		public static bool IsLandscape(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the viewport orientation is currently in portrait mode.</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>true when the viewport orientation is currently in portrait mode.</returns>
		[JsMethod(Name = "isPortrait")]
		public static bool IsPortrait(Window win = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}