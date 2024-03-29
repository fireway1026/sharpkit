// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.tabview
{
    /// <summary>
	/// <para>A TabButton is the clickable part sitting on the <see cref="qx.ui.tabview.Page"/>.
	/// By clicking on the TabButton the user can set a Page active.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tabview.TabButton", OmitOptionalParameters = true, Export = false)]
    public partial class TabButton : qx.ui.form.RadioButton, qx.ui.form.IRadioItem
    {
		#region Events

		/// <summary>
		/// <para>Fired by <see cref="qx.ui.tabview.Page"/> if the close button is clicked.</para>
		/// <para>Event data: The tab button.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnClose;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Indicates if the close button of a TabButton should be shown.</para>
		/// </summary>
		[JsProperty(Name = "showCloseButton", NativeField = true)]
		public bool ShowCloseButton { get; set; }

		#endregion Properties

		#region Methods

		public TabButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showCloseButton.</para>
		/// </summary>
		[JsMethod(Name = "getShowCloseButton")]
		public bool GetShowCloseButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showCloseButton
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showCloseButton.</param>
		[JsMethod(Name = "initShowCloseButton")]
		public void InitShowCloseButton(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showCloseButton equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowCloseButton")]
		public void IsShowCloseButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showCloseButton.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowCloseButton")]
		public void ResetShowCloseButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showCloseButton.</para>
		/// </summary>
		/// <param name="value">New value for property showCloseButton.</param>
		[JsMethod(Name = "setShowCloseButton")]
		public void SetShowCloseButton(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showCloseButton.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowCloseButton")]
		public void ToggleShowCloseButton() { throw new NotImplementedException(); }

		#endregion Methods
    }
}