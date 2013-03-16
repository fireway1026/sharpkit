// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>The TextField is a multi-line text input field.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.TextArea", OmitOptionalParameters = true, Export = false)]
    public partial class TextArea : qx.ui.form.AbstractField
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Whether the TextArea should automatically adjust to
		/// the height of the content.</para>
		/// <para>To set the initial height, modify <see cref="MinHeight"/>. If you wish
		/// to set a minHeight below four lines of text, also set
		/// <see cref="MinimalLineHeight"/>. In order to limit growing to a certain
		/// height, set <see cref="MaxHeight"/> respectively. Please note that
		/// autoSize is ignored when the <see cref="Height"/> property is in use.</para>
		/// </summary>
		[JsProperty(Name = "autoSize", NativeField = true)]
		public bool AutoSize { get; set; }

		/// <summary>
		/// <para>Minimal line height. On default this is set to four lines.</para>
		/// </summary>
		[JsProperty(Name = "minimalLineHeight", NativeField = true)]
		public double MinimalLineHeight { get; set; }

		/// <summary>
		/// <para>Factor for scrolling the TextArea with the mouse wheel.</para>
		/// </summary>
		[JsProperty(Name = "singleStep", NativeField = true)]
		public double SingleStep { get; set; }

		/// <summary>
		/// <para>Controls whether text wrap is activated or not.</para>
		/// </summary>
		[JsProperty(Name = "wrap", NativeField = true)]
		public bool Wrap { get; set; }

		#endregion Properties

		#region Methods

		public TextArea() { throw new NotImplementedException(); }

		/// <param name="value">The text area&#8217;s initial value</param>
		public TextArea(string value = "") { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property autoSize.</para>
		/// </summary>
		[JsMethod(Name = "getAutoSize")]
		public bool GetAutoSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property minimalLineHeight.</para>
		/// </summary>
		[JsMethod(Name = "getMinimalLineHeight")]
		public double GetMinimalLineHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property singleStep.</para>
		/// </summary>
		[JsMethod(Name = "getSingleStep")]
		public double GetSingleStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property wrap.</para>
		/// </summary>
		[JsMethod(Name = "getWrap")]
		public bool GetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property autoSize
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property autoSize.</param>
		[JsMethod(Name = "initAutoSize")]
		public void InitAutoSize(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property minimalLineHeight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property minimalLineHeight.</param>
		[JsMethod(Name = "initMinimalLineHeight")]
		public void InitMinimalLineHeight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property singleStep
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property singleStep.</param>
		[JsMethod(Name = "initSingleStep")]
		public void InitSingleStep(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property wrap
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property wrap.</param>
		[JsMethod(Name = "initWrap")]
		public void InitWrap(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property autoSize equals true.</para>
		/// </summary>
		[JsMethod(Name = "isAutoSize")]
		public void IsAutoSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property wrap equals true.</para>
		/// </summary>
		[JsMethod(Name = "isWrap")]
		public void IsWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property autoSize.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAutoSize")]
		public void ResetAutoSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property minimalLineHeight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMinimalLineHeight")]
		public void ResetMinimalLineHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property singleStep.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSingleStep")]
		public void ResetSingleStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property wrap.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetWrap")]
		public void ResetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property autoSize.</para>
		/// </summary>
		/// <param name="value">New value for property autoSize.</param>
		[JsMethod(Name = "setAutoSize")]
		public void SetAutoSize(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property minimalLineHeight.</para>
		/// </summary>
		/// <param name="value">New value for property minimalLineHeight.</param>
		[JsMethod(Name = "setMinimalLineHeight")]
		public void SetMinimalLineHeight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property singleStep.</para>
		/// </summary>
		/// <param name="value">New value for property singleStep.</param>
		[JsMethod(Name = "setSingleStep")]
		public void SetSingleStep(double value) { throw new NotImplementedException(); }

		[JsMethod(Name = "setValue")]
		public void SetValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property wrap.</para>
		/// </summary>
		/// <param name="value">New value for property wrap.</param>
		[JsMethod(Name = "setWrap")]
		public void SetWrap(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property autoSize.</para>
		/// </summary>
		[JsMethod(Name = "toggleAutoSize")]
		public void ToggleAutoSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property wrap.</para>
		/// </summary>
		[JsMethod(Name = "toggleWrap")]
		public void ToggleWrap() { throw new NotImplementedException(); }

		#endregion Methods
    }
}