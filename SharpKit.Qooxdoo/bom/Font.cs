// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>A wrapper for CSS font styles. Fond objects can be applied to instances
	/// of <see cref="qx.html.Element"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Font", OmitOptionalParameters = true, Export = false)]
    public partial class Font : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>Whether the font is bold</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "bold", NativeField = true)]
		public bool Bold { get; set; }

		/// <summary>
		/// <para>The text color for this font</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "color", NativeField = true)]
		public string Color { get; set; }

		/// <summary>
		/// <para>The text decoration for this font</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "underline","line-through","overline"
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "decoration", NativeField = true)]
		public object Decoration { get; set; }

		/// <summary>
		/// <para>A sorted list of font families</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "family", NativeField = true)]
		public JsArray Family { get; set; }

		/// <summary>
		/// <para>Whether the font is italic</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "italic", NativeField = true)]
		public bool Italic { get; set; }

		/// <summary>
		/// <para>The line height as scaling factor of the default line height. A value
		/// of 1 corresponds to the default line height</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "lineHeight", NativeField = true)]
		public double LineHeight { get; set; }

		/// <summary>
		/// <para>The font size (Unit: pixel)</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "size", NativeField = true)]
		public double Size { get; set; }

		/// <summary>
		/// <para>The text shadow for this font</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "textShadow", NativeField = true)]
		public string TextShadow { get; set; }

		#endregion Properties

		#region Methods

		public Font() { throw new NotImplementedException(); }

		/// <param name="size">The font size (Unit: pixel)</param>
		/// <param name="family">A sorted list of font families</param>
		public Font(string size, string family) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts a map property definition into a font object.</para>
		/// </summary>
		/// <param name="config">map of property values</param>
		/// <returns>the created instance</returns>
		[JsMethod(Name = "fromConfig")]
		public static qx.bom.Font FromConfig(object config) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts a typical CSS font definition string to an font object</para>
		/// <para>Example string: bold italic 20px Arial</para>
		/// </summary>
		/// <param name="str">the CSS string</param>
		/// <returns>the created instance</returns>
		[JsMethod(Name = "fromString")]
		public static qx.bom.Font FromString(string str) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a map of all properties in empty state.</para>
		/// <para>This is useful for resetting previously configured
		/// font styles.</para>
		/// </summary>
		/// <returns>Default styles</returns>
		[JsMethod(Name = "getDefaultStyles")]
		public static object GetDefaultStyles() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property bold.</para>
		/// </summary>
		[JsMethod(Name = "getBold")]
		public bool GetBold() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property color.</para>
		/// </summary>
		[JsMethod(Name = "getColor")]
		public string GetColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property decoration.</para>
		/// </summary>
		[JsMethod(Name = "getDecoration")]
		public object GetDecoration() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property family.</para>
		/// </summary>
		[JsMethod(Name = "getFamily")]
		public JsArray GetFamily() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property italic.</para>
		/// </summary>
		[JsMethod(Name = "getItalic")]
		public bool GetItalic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property lineHeight.</para>
		/// </summary>
		[JsMethod(Name = "getLineHeight")]
		public double GetLineHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property size.</para>
		/// </summary>
		[JsMethod(Name = "getSize")]
		public double GetSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a map of all CSS styles, which will be applied to the widget. Only
		/// the styles which are set are returned.</para>
		/// </summary>
		/// <returns>Map containing the current styles. The keys are property names which can directly be used with the set method of each widget.</returns>
		[JsMethod(Name = "getStyles")]
		public object GetStyles() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property textShadow.</para>
		/// </summary>
		[JsMethod(Name = "getTextShadow")]
		public string GetTextShadow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property bold
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property bold.</param>
		[JsMethod(Name = "initBold")]
		public void InitBold(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property color
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property color.</param>
		[JsMethod(Name = "initColor")]
		public void InitColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property decoration
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property decoration.</param>
		[JsMethod(Name = "initDecoration")]
		public void InitDecoration(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property family
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property family.</param>
		[JsMethod(Name = "initFamily")]
		public void InitFamily(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property italic
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property italic.</param>
		[JsMethod(Name = "initItalic")]
		public void InitItalic(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property lineHeight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property lineHeight.</param>
		[JsMethod(Name = "initLineHeight")]
		public void InitLineHeight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property size
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property size.</param>
		[JsMethod(Name = "initSize")]
		public void InitSize(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property textShadow
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property textShadow.</param>
		[JsMethod(Name = "initTextShadow")]
		public void InitTextShadow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property bold equals true.</para>
		/// </summary>
		[JsMethod(Name = "isBold")]
		public void IsBold() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property italic equals true.</para>
		/// </summary>
		[JsMethod(Name = "isItalic")]
		public void IsItalic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property bold.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBold")]
		public void ResetBold() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property color.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetColor")]
		public void ResetColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property decoration.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDecoration")]
		public void ResetDecoration() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property family.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFamily")]
		public void ResetFamily() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property italic.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetItalic")]
		public void ResetItalic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property lineHeight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLineHeight")]
		public void ResetLineHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property size.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSize")]
		public void ResetSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property textShadow.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTextShadow")]
		public void ResetTextShadow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property bold.</para>
		/// </summary>
		/// <param name="value">New value for property bold.</param>
		[JsMethod(Name = "setBold")]
		public void SetBold(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property color.</para>
		/// </summary>
		/// <param name="value">New value for property color.</param>
		[JsMethod(Name = "setColor")]
		public void SetColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property decoration.</para>
		/// </summary>
		/// <param name="value">New value for property decoration.</param>
		[JsMethod(Name = "setDecoration")]
		public void SetDecoration(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property family.</para>
		/// </summary>
		/// <param name="value">New value for property family.</param>
		[JsMethod(Name = "setFamily")]
		public void SetFamily(JsArray value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property italic.</para>
		/// </summary>
		/// <param name="value">New value for property italic.</param>
		[JsMethod(Name = "setItalic")]
		public void SetItalic(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property lineHeight.</para>
		/// </summary>
		/// <param name="value">New value for property lineHeight.</param>
		[JsMethod(Name = "setLineHeight")]
		public void SetLineHeight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property size.</para>
		/// </summary>
		/// <param name="value">New value for property size.</param>
		[JsMethod(Name = "setSize")]
		public void SetSize(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property textShadow.</para>
		/// </summary>
		/// <param name="value">New value for property textShadow.</param>
		[JsMethod(Name = "setTextShadow")]
		public void SetTextShadow(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property bold.</para>
		/// </summary>
		[JsMethod(Name = "toggleBold")]
		public void ToggleBold() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property italic.</para>
		/// </summary>
		[JsMethod(Name = "toggleItalic")]
		public void ToggleItalic() { throw new NotImplementedException(); }

		#endregion Methods
    }
}