// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.basic
{
    /// <summary>
	/// <para>The image class displays an image file</para>
	/// <para>This class supports image clipping, which means that multiple images can be combined
	/// into one large image and only the relevant part is shown.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var image = new qx.ui.basic.Image("icon/32/actions/format-justify-left.png");
	/// this.getRoot().add(image);
	/// </code>
	/// <para>This example create a widget to display the image
	/// icon/32/actions/format-justify-left.png.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.basic.Image", OmitOptionalParameters = true, Export = false)]
    public partial class Image : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Source"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeSourceEvent;

		/// <summary>
		/// <para>Fired if the image has been loaded.</para>
		/// <para>Attention: This event is only used for images which are loaded externally
		/// (aka unmanaged images).</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> LoadedEvent;

		/// <summary>
		/// <para>Fired if the image source can not be loaded.</para>
		/// <para>Attention: This event is only used for images which are loaded externally
		/// (aka unmanaged images).</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> LoadingFailedEvent;

		#endregion Events

		#region Properties

		[JsProperty(Name = "allowGrowX", NativeField = true)]
		public object AllowGrowX { get; set; }

		[JsProperty(Name = "allowGrowY", NativeField = true)]
		public object AllowGrowY { get; set; }

		[JsProperty(Name = "allowShrinkX", NativeField = true)]
		public object AllowShrinkX { get; set; }

		[JsProperty(Name = "allowShrinkY", NativeField = true)]
		public object AllowShrinkY { get; set; }

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Whether the image should be scaled to the given dimensions</para>
		/// <para>This is disabled by default because it prevents the usage
		/// of image clipping when enabled.</para>
		/// </summary>
		[JsProperty(Name = "scale", NativeField = true)]
		public bool Scale { get; set; }

		/// <summary>
		/// <para>The URL of the image</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "source", NativeField = true)]
		public string Source { get; set; }

		#endregion Properties

		#region Methods

		public Image() { throw new NotImplementedException(); }

		/// <param name="source">The URL of the image to display.</param>
		public Image(string source = null) { throw new NotImplementedException(); }

		[JsMethod(Name = "getContentElement")]
		public void GetContentElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property scale.</para>
		/// </summary>
		[JsMethod(Name = "getScale")]
		public bool GetScale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property source.</para>
		/// </summary>
		[JsMethod(Name = "getSource")]
		public string GetSource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property scale
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property scale.</param>
		[JsMethod(Name = "initScale")]
		public void InitScale(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property source
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property source.</param>
		[JsMethod(Name = "initSource")]
		public void InitSource(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property scale equals true.</para>
		/// </summary>
		[JsMethod(Name = "isScale")]
		public void IsScale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property scale.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetScale")]
		public void ResetScale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property source.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSource")]
		public void ResetSource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property scale.</para>
		/// </summary>
		/// <param name="value">New value for property scale.</param>
		[JsMethod(Name = "setScale")]
		public void SetScale(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property source.</para>
		/// </summary>
		/// <param name="value">New value for property source.</param>
		[JsMethod(Name = "setSource")]
		public void SetSource(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property scale.</para>
		/// </summary>
		[JsMethod(Name = "toggleScale")]
		public void ToggleScale() { throw new NotImplementedException(); }

		#endregion Methods
    }
}