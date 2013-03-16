// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.list.renderer
{
    /// <summary>
	/// <para>The default list item renderer. Used as the default renderer by the
	/// <see cref="qx.ui.mobile.list.provider.Provider"/>. Configure the renderer
	/// by setting the <see cref="qx.ui.mobile.list.List.Delegate"/> property.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// // Create the list with a delegate that
	/// // configures the list item.
	/// var list = new qx.ui.mobile.list.List({
	/// configureItem : function(item, data, row)
	/// {
	/// item.setImage("path/to/image.png");
	/// item.setTitle(data.title);
	/// item.setSubtitle(data.subtitle);
	/// }
	/// });
	/// </code>
	/// <para>This example creates a list with a delegate that configures the list item with
	/// the given data.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.list.renderer.Default", OmitOptionalParameters = true, Export = false)]
    public partial class Default : qx.ui.mobile.list.renderer.Abstract
    {
		#region Methods

		public Default() { throw new NotImplementedException(); }

		public Default(object layout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the image widget which is used for this renderer.</para>
		/// </summary>
		/// <returns>The image widget</returns>
		[JsMethod(Name = "getImageWidget")]
		public qx.ui.mobile.basic.Image GetImageWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the subtitle widget which is used for this renderer.</para>
		/// </summary>
		/// <returns>The subtitle widget</returns>
		[JsMethod(Name = "getSubtitleWidget")]
		public qx.ui.mobile.basic.Label GetSubtitleWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the title widget which is used for this renderer.</para>
		/// </summary>
		/// <returns>The title widget</returns>
		[JsMethod(Name = "getTitleWidget")]
		public qx.ui.mobile.basic.Label GetTitleWidget() { throw new NotImplementedException(); }

		[JsMethod(Name = "reset")]
		public void Reset() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the source of the image widget.</para>
		/// </summary>
		/// <param name="source">The source to set</param>
		[JsMethod(Name = "setImage")]
		public void SetImage(string source) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value of the subtitle widget.</para>
		/// </summary>
		/// <param name="subtitle">The value to set</param>
		[JsMethod(Name = "setSubtitle")]
		public void SetSubtitle(string subtitle) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value of the title widget.</para>
		/// </summary>
		/// <param name="title">The value to set</param>
		[JsMethod(Name = "setTitle")]
		public void SetTitle(string title) { throw new NotImplementedException(); }

		#endregion Methods
    }
}