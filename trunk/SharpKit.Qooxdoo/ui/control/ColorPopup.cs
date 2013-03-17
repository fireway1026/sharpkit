// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.control
{
    /// <summary>
	/// <para>A popup which contains palettes of colors and the possibility to open the
	/// Colorselector to choose a color.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.control.ColorPopup", OmitOptionalParameters = true, Export = false)]
    public partial class ColorPopup : qx.ui.popup.Popup, qx.ui.form.IColorForm
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Blue"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeBlueEvent;

		/// <summary>
		/// Fired on change of the property <see cref="Green"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeGreenEvent;

		/// <summary>
		/// Fired on change of the property <see cref="Red"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeRedEvent;

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeValueEvent;

		#endregion Events

		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>The numeric blue value of the selected color.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "blue", NativeField = true)]
		public double Blue { get; set; }

		/// <summary>
		/// <para>The numeric green value of the selected color.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "green", NativeField = true)]
		public double Green { get; set; }

		/// <summary>
		/// <para>The numeric red value of the selected color.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "red", NativeField = true)]
		public double Red { get; set; }

		/// <summary>
		/// <para>The hex value of the selected color.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "value", NativeField = true)]
		public object Value { get; set; }

		#endregion Properties

		#region Methods

		public ColorPopup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blue.</para>
		/// </summary>
		[JsMethod(Name = "getBlue")]
		public double GetBlue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property green.</para>
		/// </summary>
		[JsMethod(Name = "getGreen")]
		public double GetGreen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property red.</para>
		/// </summary>
		[JsMethod(Name = "getRed")]
		public double GetRed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public string GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blue
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blue.</param>
		[JsMethod(Name = "initBlue")]
		public void InitBlue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property green
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property green.</param>
		[JsMethod(Name = "initGreen")]
		public void InitGreen(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property red
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property red.</param>
		[JsMethod(Name = "initRed")]
		public void InitRed(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property value
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property value.</param>
		[JsMethod(Name = "initValue")]
		public void InitValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blue.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlue")]
		public void ResetBlue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property green.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGreen")]
		public void ResetGreen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property red.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRed")]
		public void ResetRed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blue.</para>
		/// </summary>
		/// <param name="value">New value for property blue.</param>
		[JsMethod(Name = "setBlue")]
		public void SetBlue(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property green.</para>
		/// </summary>
		/// <param name="value">New value for property green.</param>
		[JsMethod(Name = "setGreen")]
		public void SetGreen(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property red.</para>
		/// </summary>
		/// <param name="value">New value for property red.</param>
		[JsMethod(Name = "setRed")]
		public void SetRed(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}