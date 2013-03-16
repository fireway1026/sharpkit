// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.page
{
    /// <summary>
	/// <para>Specialized page. This page includes already a <see cref="qx.ui.mobile.navigationbar.NavigationBar"/>
	/// and and a <see cref="qx.ui.mobile.container.Scroll"/> container.
	/// The NavigationPage can only be used with a page manager <see cref="qx.ui.mobile.page.Manager"/>.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var manager = new qx.ui.mobile.page.Manager();
	/// var page = new qx.ui.mobile.page.NavigationPage();
	/// page.setTitle("Page Title");
	/// page.setShowBackButton(true);
	/// page.setBackButtonText("Back")
	/// page.addListener("initialize", function()
	/// {
	/// var button = new qx.ui.mobile.form.Button("Next Page");
	/// page.getContent().add(button);
	/// },this);
	/// page.addListener("back", function()
	/// {
	/// otherPage.show({animation:"cube", reverse:true});
	/// },this);
	/// manager.addDetail(page);
	/// page.show();
	/// </code>
	/// <para>This example creates a NavigationPage with a title and a back button. In the
	/// initialize lifecycle method a button is added.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.page.NavigationPage", OmitOptionalParameters = true, Export = false)]
    public partial class NavigationPage : qx.ui.mobile.page.Page, qx.ui.mobile.container.INavigation
    {
		#region Events

		/// <summary>
		/// <para>Fired when the user tapped on the navigation button</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> ActionEvent;

		/// <summary>
		/// Fired on change of the property <see cref="Title"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeTitleEvent;

		/// <summary>
		/// <para>Fired when parent portrait container should hide. *</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> HidePortraitContainerEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The back button text</para>
		/// </summary>
		[JsProperty(Name = "backButtonText", NativeField = true)]
		public string BackButtonText { get; set; }

		/// <summary>
		/// <para>The action button text</para>
		/// </summary>
		[JsProperty(Name = "buttonText", NativeField = true)]
		public string ButtonText { get; set; }

		/// <summary>
		/// <para>The CSS class to add to the content per default.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "contentCssClass", NativeField = true)]
		public string ContentCssClass { get; set; }

		/// <summary>
		/// <para>Toggles visibility of NavigationBar in
		/// wrapping container <see cref="qx.ui.mobile.container.Navigation"/></para>
		/// </summary>
		[JsProperty(Name = "navigationBarHidden", NativeField = true)]
		public bool NavigationBarHidden { get; set; }

		/// <summary>
		/// <para>Sets the transition duration (in seconds) for the effect when hiding/showing
		/// the NavigationBar through boolean property navigationBarHidden.</para>
		/// </summary>
		[JsProperty(Name = "navigationBarToggleDuration", NativeField = true)]
		public double NavigationBarToggleDuration { get; set; }

		/// <summary>
		/// <para>Whether to show the back button.</para>
		/// </summary>
		[JsProperty(Name = "showBackButton", NativeField = true)]
		public bool ShowBackButton { get; set; }

		/// <summary>
		/// <para>Indicates whether the back button should be shown on tablet.</para>
		/// </summary>
		[JsProperty(Name = "showBackButtonOnTablet", NativeField = true)]
		public bool ShowBackButtonOnTablet { get; set; }

		/// <summary>
		/// <para>Whether to show the action button.</para>
		/// </summary>
		[JsProperty(Name = "showButton", NativeField = true)]
		public bool ShowButton { get; set; }

		/// <summary>
		/// <para>The title of the page</para>
		/// </summary>
		[JsProperty(Name = "title", NativeField = true)]
		public string Title { get; set; }

		#endregion Properties

		#region Methods

		public NavigationPage() { throw new NotImplementedException(); }

		/// <param name="wrapContentByGroup">Defines whether a group box should wrap the content. This can be used for defining a page margin.</param>
		/// <param name="layout">The layout of this page.</param>
		public NavigationPage(bool wrapContentByGroup, qx.ui.mobile.layout.Abstract layout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a widget, below the NavigationBar.</para>
		/// </summary>
		/// <param name="widget">The widget to add, after NavigationBar.</param>
		[JsMethod(Name = "addAfterNavigationBar")]
		public void AddAfterNavigationBar(qx.ui.mobile.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property backButtonText.</para>
		/// </summary>
		[JsMethod(Name = "getBackButtonText")]
		public string GetBackButtonText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property buttonText.</para>
		/// </summary>
		[JsMethod(Name = "getButtonText")]
		public string GetButtonText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the content container. Add all your widgets to this container.</para>
		/// </summary>
		/// <returns>The content container</returns>
		[JsMethod(Name = "getContent")]
		public qx.ui.mobile.container.Composite GetContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentCssClass.</para>
		/// </summary>
		[JsMethod(Name = "getContentCssClass")]
		public string GetContentCssClass() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the left container that is merged into the navigation bar.</para>
		/// </summary>
		/// <returns>The left container of the navigation bar</returns>
		[JsMethod(Name = "getLeftContainer")]
		public qx.ui.mobile.container.Composite GetLeftContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property navigationBarHidden.</para>
		/// </summary>
		[JsMethod(Name = "getNavigationBarHidden")]
		public bool GetNavigationBarHidden() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property navigationBarToggleDuration.</para>
		/// </summary>
		[JsMethod(Name = "getNavigationBarToggleDuration")]
		public double GetNavigationBarToggleDuration() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the right container that is merged into the navigation bar.</para>
		/// </summary>
		/// <returns>The right container of the navigation bar</returns>
		[JsMethod(Name = "getRightContainer")]
		public qx.ui.mobile.container.Composite GetRightContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showBackButton.</para>
		/// </summary>
		[JsMethod(Name = "getShowBackButton")]
		public bool GetShowBackButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showBackButtonOnTablet.</para>
		/// </summary>
		[JsMethod(Name = "getShowBackButtonOnTablet")]
		public bool GetShowBackButtonOnTablet() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showButton.</para>
		/// </summary>
		[JsMethod(Name = "getShowButton")]
		public bool GetShowButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property title.</para>
		/// </summary>
		[JsMethod(Name = "getTitle")]
		public string GetTitle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the title widget that is merged into the navigation bar.</para>
		/// </summary>
		/// <returns>The title of the navigation bar</returns>
		[JsMethod(Name = "getTitleWidget")]
		public qx.ui.mobile.navigationbar.Title GetTitleWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property backButtonText
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property backButtonText.</param>
		[JsMethod(Name = "initBackButtonText")]
		public void InitBackButtonText(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property buttonText
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property buttonText.</param>
		[JsMethod(Name = "initButtonText")]
		public void InitButtonText(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentCssClass
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentCssClass.</param>
		[JsMethod(Name = "initContentCssClass")]
		public void InitContentCssClass(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property navigationBarHidden
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property navigationBarHidden.</param>
		[JsMethod(Name = "initNavigationBarHidden")]
		public void InitNavigationBarHidden(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property navigationBarToggleDuration
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property navigationBarToggleDuration.</param>
		[JsMethod(Name = "initNavigationBarToggleDuration")]
		public void InitNavigationBarToggleDuration(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showBackButton
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showBackButton.</param>
		[JsMethod(Name = "initShowBackButton")]
		public void InitShowBackButton(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showBackButtonOnTablet
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showBackButtonOnTablet.</param>
		[JsMethod(Name = "initShowBackButtonOnTablet")]
		public void InitShowBackButtonOnTablet(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showButton
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showButton.</param>
		[JsMethod(Name = "initShowButton")]
		public void InitShowButton(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property title
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property title.</param>
		[JsMethod(Name = "initTitle")]
		public void InitTitle(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property navigationBarHidden equals true.</para>
		/// </summary>
		[JsMethod(Name = "isNavigationBarHidden")]
		public void IsNavigationBarHidden() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showBackButton equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowBackButton")]
		public void IsShowBackButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showBackButtonOnTablet equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowBackButtonOnTablet")]
		public void IsShowBackButtonOnTablet() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showButton equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowButton")]
		public void IsShowButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the isTablet flag.</para>
		/// </summary>
		/// <returns>the isTablet flag of this page.</returns>
		[JsMethod(Name = "isTablet")]
		public bool IsTablet() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property backButtonText.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBackButtonText")]
		public void ResetBackButtonText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property buttonText.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetButtonText")]
		public void ResetButtonText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentCssClass.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentCssClass")]
		public void ResetContentCssClass() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property navigationBarHidden.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNavigationBarHidden")]
		public void ResetNavigationBarHidden() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property navigationBarToggleDuration.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNavigationBarToggleDuration")]
		public void ResetNavigationBarToggleDuration() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showBackButton.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowBackButton")]
		public void ResetShowBackButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showBackButtonOnTablet.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowBackButtonOnTablet")]
		public void ResetShowBackButtonOnTablet() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showButton.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowButton")]
		public void ResetShowButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property title.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTitle")]
		public void ResetTitle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the wrapper contents to the x/y coordinates in a given
		/// period.</para>
		/// </summary>
		/// <param name="x">X coordinate to scroll to.</param>
		/// <param name="y">Y coordinate to scroll to.</param>
		/// <param name="time">Time slice in which scrolling should be done.</param>
		[JsMethod(Name = "scrollTo")]
		public void ScrollTo(double x, double y, double time) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the wrapper contents to the widgets coordinates in a given
		/// period.</para>
		/// </summary>
		/// <param name="widget">the widget, the scroll container should scroll to.</param>
		/// <param name="time">Time slice in which scrolling should be done.</param>
		[JsMethod(Name = "scrollToWidget")]
		public void ScrollToWidget(qx.ui.mobile.core.Widget widget, double time) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property backButtonText.</para>
		/// </summary>
		/// <param name="value">New value for property backButtonText.</param>
		[JsMethod(Name = "setBackButtonText")]
		public void SetBackButtonText(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property buttonText.</para>
		/// </summary>
		/// <param name="value">New value for property buttonText.</param>
		[JsMethod(Name = "setButtonText")]
		public void SetButtonText(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentCssClass.</para>
		/// </summary>
		/// <param name="value">New value for property contentCssClass.</param>
		[JsMethod(Name = "setContentCssClass")]
		public void SetContentCssClass(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the isTablet flag.</para>
		/// </summary>
		/// <param name="isTablet">value of the isTablet flag.</param>
		[JsMethod(Name = "setIsTablet")]
		public void SetIsTablet(bool isTablet) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property navigationBarHidden.</para>
		/// </summary>
		/// <param name="value">New value for property navigationBarHidden.</param>
		[JsMethod(Name = "setNavigationBarHidden")]
		public void SetNavigationBarHidden(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property navigationBarToggleDuration.</para>
		/// </summary>
		/// <param name="value">New value for property navigationBarToggleDuration.</param>
		[JsMethod(Name = "setNavigationBarToggleDuration")]
		public void SetNavigationBarToggleDuration(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showBackButton.</para>
		/// </summary>
		/// <param name="value">New value for property showBackButton.</param>
		[JsMethod(Name = "setShowBackButton")]
		public void SetShowBackButton(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showBackButtonOnTablet.</para>
		/// </summary>
		/// <param name="value">New value for property showBackButtonOnTablet.</param>
		[JsMethod(Name = "setShowBackButtonOnTablet")]
		public void SetShowBackButtonOnTablet(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showButton.</para>
		/// </summary>
		/// <param name="value">New value for property showButton.</param>
		[JsMethod(Name = "setShowButton")]
		public void SetShowButton(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property title.</para>
		/// </summary>
		/// <param name="value">New value for property title.</param>
		[JsMethod(Name = "setTitle")]
		public void SetTitle(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property navigationBarHidden.</para>
		/// </summary>
		[JsMethod(Name = "toggleNavigationBarHidden")]
		public void ToggleNavigationBarHidden() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showBackButton.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowBackButton")]
		public void ToggleShowBackButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showBackButtonOnTablet.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowBackButtonOnTablet")]
		public void ToggleShowBackButtonOnTablet() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showButton.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowButton")]
		public void ToggleShowButton() { throw new NotImplementedException(); }

		#endregion Methods
    }
}