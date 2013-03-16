// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.headerrenderer
{
    /// <summary>
	/// <para>The default header cell widget</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.headerrenderer.HeaderCell", OmitOptionalParameters = true, Export = false)]
    public partial class HeaderCell : qx.ui.container.Composite
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Icon URL</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "icon", NativeField = true)]
		public string Icon { get; set; }

		/// <summary>
		/// <para>header cell label</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "label", NativeField = true)]
		public string Label { get; set; }

		/// <summary>
		/// <para>The icon URL of the sorting indicator</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sortIcon", NativeField = true)]
		public string SortIcon { get; set; }

		#endregion Properties

		#region Methods

		public HeaderCell() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property icon.</para>
		/// </summary>
		[JsMethod(Name = "getIcon")]
		public string GetIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property label.</para>
		/// </summary>
		[JsMethod(Name = "getLabel")]
		public string GetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sortIcon.</para>
		/// </summary>
		[JsMethod(Name = "getSortIcon")]
		public string GetSortIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property icon
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property icon.</param>
		[JsMethod(Name = "initIcon")]
		public void InitIcon(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property label
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property label.</param>
		[JsMethod(Name = "initLabel")]
		public void InitLabel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sortIcon
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sortIcon.</param>
		[JsMethod(Name = "initSortIcon")]
		public void InitSortIcon(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property icon.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIcon")]
		public void ResetIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property label.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabel")]
		public void ResetLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sortIcon.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSortIcon")]
		public void ResetSortIcon() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property icon.</para>
		/// </summary>
		/// <param name="value">New value for property icon.</param>
		[JsMethod(Name = "setIcon")]
		public void SetIcon(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property label.</para>
		/// </summary>
		/// <param name="value">New value for property label.</param>
		[JsMethod(Name = "setLabel")]
		public void SetLabel(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sortIcon.</para>
		/// </summary>
		/// <param name="value">New value for property sortIcon.</param>
		[JsMethod(Name = "setSortIcon")]
		public void SetSortIcon(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}