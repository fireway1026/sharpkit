﻿using SharpKit.JavaScript;
namespace SharpKit.jQuery
{
	#region Accordion
	///<summary>
	///Make the selected elements Accordion widgets. Semantic requirements:
	///The markup of your accordion container needs pairs of headers and content panels. By default, the header elements are anchors, assuming the following structure:
	///<div id="accordion">
	///    <a href="#">First header</a>
	///    <div>First content</div>
	///    <a href="#">Second header</a>
	///    <div>Second content</div>
	///</div>If you use a different element for the header, specify the header-option with an appropriate selector, eg. header: 'h3'. The content element must be always next to its header.
	///If you have links inside the accordion content and use a-elements as headers, add a class to them and use that as the header, eg. header: 'a.header'.
	///Use activate(Number) to change the active content programmatically.
	///[edit]NOTE: If you want multiple sections open at once, don't use an accordion
	///An accordion doesn't allow more than one content panel to be open at the same time, and it takes a lot of effort to do that. If you are looking for a widget that allows more than one content panel to be open, don't use this. Usually it can be written with a few lines of jQuery instead, something like this:
	///jQuery(document).ready(function(){
	///	$('.accordion .head').click(function() {
	///		$(this).next().toggle();
	///		return false;
	///	}).next().hide();
	///});Or animated:
	///jQuery(document).ready(function(){
	///	$('.accordion .head').click(function() {
	///		$(this).next().toggle('slow');
	///		return false;
	///	}).next().hide();
	///});
	///</summary>
	public static partial class AccordionExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery accordion(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery accordion(this jQuery query, AccordionOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery accordion(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region AccordionOptions
	///<summary>
	///Options JSON object for Accordion
	///</summary>
	[JsType(JsMode.Json)]
	public partial class AccordionOptions
	{
		///<summary>
		///Selector for the active element. Set to false to display none at start. Needs collapsible: true.
		///Default: first child
		///Types: Selector, Element, jQuery, Boolean, Number
		///</summary>
		public object active { get; set; }
		///<summary>
		///Choose your favorite animation, or disable them (set to false). In addition to the default, 'bounceslide' and all defined easing methods are supported ('bounceslide' requires UI Effects Core).
		///Default: 'slide'
		///Types: Boolean, String
		///</summary>
		public object animated { get; set; }
		///<summary>
		///If set, the highest content part is used as height reference for all other parts. Provides more consistent animations.
		///Default: true
		///</summary>
		public bool autoHeight { get; set; }
		///<summary>
		///If set, clears height and overflow styles after finishing animations. This enables accordions to work with dynamic content. Won't work together with autoHeight.
		///Default: false
		///</summary>
		public bool clearStyle { get; set; }
		///<summary>
		///Whether all the sections can be closed at once. Allows collapsing the active section by the triggering event (click is the default).
		///Default: false
		///</summary>
		public bool collapsible { get; set; }
		///<summary>
		///The event on which to trigger the accordion.
		///Default: 'click'
		///</summary>
		public string @event { get; set; }
		///<summary>
		///If set, the accordion completely fills the height of the parent element. Overrides autoheight.
		///Default: false
		///</summary>
		public bool fillSpace { get; set; }
		///<summary>
		///Selector for the header element.
		///Default: '> li > :first-child,> :not(li):even'
		///Types: Selector, jQuery
		///</summary>
		public object header { get; set; }
		///<summary>
		///Icons to use for headers. Icons may be specified for 'header' and 'headerSelected', and we recommend using the icons native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
		///Default: { 'header': 'ui-icon-triangle-1-e', 'headerSelected': 'ui-icon-triangle-1-s' }
		///</summary>
		public object icons { get; set; }
		///<summary>
		///If set, looks for the anchor that matches location.href and activates it. Great for href-based state-saving. Use navigationFilter to implement your own matcher.
		///Default: false
		///</summary>
		public bool navigation { get; set; }
		///<summary>
		///Overwrite the default location.href-matching with your own matcher.
		///Default: 
		///</summary>
		public jQueryUIEvent navigationFilter { get; set; }
		///<summary>
		///This event is triggered every time the accordion changes. If the accordion is animated, the event will be triggered upon completion of the animation; otherwise, it is triggered immediately. 
		///$('.ui-accordion').bind('accordionchange', function(event, ui) {
		///  ui.newHeader // jQuery object, activated header
		///  ui.oldHeader // jQuery object, previous header
		///  ui.newContent // jQuery object, activated content
		///  ui.oldContent // jQuery object, previous content
		///});
		///Default: null
		///</summary>
		public jQueryUIEvent change { get; set; }
		///<summary>
		///This event is triggered every time the accordion starts to change. 
		///$('.ui-accordion').bind('accordionchangestart', function(event, ui) {
		///  ui.newHeader // jQuery object, activated header
		///  ui.oldHeader // jQuery object, previous header
		///  ui.newContent // jQuery object, activated content
		///  ui.oldContent // jQuery object, previous content
		///});
		///Default: null
		///</summary>
		public jQueryUIEvent changestart { get; set; }
	}
	#endregion
	#region AddClass
	///<summary>
	///[edit]addClass( class, [duration] )
	///Adds the specified class to each of the set of matched elements with an optional transition between the states.
	///</summary>
	public static partial class AddClassExtension
	{
		//[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		//public static jQuery addclass(this jQuery query) { return default(jQuery); }
		//[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		//public static jQuery addclass(this jQuery query, AddClassOptions options) { return default(jQuery); }
		//[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		//public static jQuery addclass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery addClass(this jQuery query, string className, object duration) { return default(jQuery); }
	}
	#endregion
	#region AddClassOptions
	/////<summary>
	/////Options JSON object for AddClass
	/////</summary>
	//[JsType(JsMode.Json)]
	//public partial class AddClassOptions
	//{
	//  ///<summary>
	//  ///One CSS class to add to the elements.
	//  ///Default: null
	//  ///</summary>
	//  public string @class { get; set; }
	//  ///<summary>
	//  ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
	//  ///Default: null
	//  ///Types: String, Number
	//  ///</summary>
	//  public object duration { get; set; }
	//}
	#endregion
	#region Button
	public static partial class Button
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery button(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery button(this jQuery query, ButtonOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery button(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery buttonset(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery buttonset(this jQuery query, ButtonOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery buttonset(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region ButtonOptions
	///<summary>
	///Options JSON object for Button
	///</summary>
	[JsType(JsMode.Json)]
	public partial class ButtonOptions
	{
		public bool disabled { get; set; }
		public bool text { get; set; }
		public object icons { get; set; }
		public JsString label { get; set; }
	}
	#endregion
	#region Datepicker
	///<summary>
	///The jQuery UI Datepicker is a highly configurable plugin that adds datepicker functionality to your pages. You can customize the date format and language, restrict the selectable date ranges and add in buttons and other navigation options easily.
	///By default, the datepicker calendar opens in a small overlay onFocus and closes automatically onBlur or when a date if selected. For an inline calendar, simply attach the datepicker to a div or span. 
	///You can use keyboard shortcuts to drive the datepicker: 
	///page up/down - previous/next month
	///ctrl+page up/down - previous/next year
	///ctrl+home - current month or open when closed
	///ctrl+left/right - previous/next day
	///ctrl+up/down - previous/next week
	///enter - accept the selected date
	///ctrl+end - close and erase the date
	///escape - close the datepicker without selection
	///[edit]Utility functions
	///$.datepicker.setDefaults( settings ) - Set settings for all datepicker instances.
	///$.datepicker.formatDate( format, date, settings ) - Format a date into a string value with a specified format.
	///$.datepicker.iso8601Week( date ) - Determine the week of the year for a given date: 1 to 53.
	///$.datepicker.parseDate( format, value, settings ) - Extract a date from a string value with a specified format.
	///</summary>
	public static partial class DatepickerExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery datepicker(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery datepicker(this jQuery query, DatepickerOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery datepicker(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region DatepickerOptions
	///<summary>
	///Options JSON object for Datepicker
	///</summary>
	[JsType(JsMode.Json)]
	public partial class DatepickerOptions
	{
		///<summary>
		///The jQuery selector for another field that is to be updated with the selected date from the datepicker. Use the altFormat setting below to change the format of the date within this field. Leave as blank for no alternate field.
		///Default: ''
		///</summary>
		public string altField { get; set; }
		///<summary>
		///The dateFormat to be used for the altField option. This allows one date format to be shown to the user for selection purposes, while a different format is actually sent behind the scenes. For a full list of the possible formats see the formatDate function
		///Default: ''
		///</summary>
		public string altFormat { get; set; }
		///<summary>
		///The text to display after each date field, e.g. to show the required format.
		///Default: ''
		///</summary>
		public string appendText { get; set; }
		///<summary>
		///The URL for the popup button image. If set, button text becomes the alt value and is not directly displayed.
		///Default: ''
		///</summary>
		public string buttonImage { get; set; }
		///<summary>
		///Set to true to place an image after the field to use as the trigger without it appearing on a button.
		///Default: false
		///</summary>
		public bool buttonImageOnly { get; set; }
		///<summary>
		///The text to display on the trigger button. Use in conjunction with showOn equal to 'button' or 'both'.
		///Default: '...'
		///</summary>
		public string buttonText { get; set; }
		///<summary>
		///Allows you to change the month by selecting from a drop-down list. You can enable this feature by setting the attribute to true.
		///Default: false
		///</summary>
		public bool changeMonth { get; set; }
		///<summary>
		///Allows you to change the year by selecting from a drop-down list. You can enable this feature by setting the attribute to true.
		///Default: false
		///</summary>
		public bool changeYear { get; set; }
		///<summary>
		///The text to display for the close link. This attribute is one of the regionalisation attributes. Use the showButtonPanel to display this button.
		///Default: 'Done'
		///</summary>
		public string closeText { get; set; }
		///<summary>
		///True if the input field is constrained to the current date format.
		///Default: true
		///</summary>
		public bool constrainInput { get; set; }
		///<summary>
		///The text to display for the current day link. This attribute is one of the regionalisation attributes. Use the showButtonPanel to display this button.
		///Default: 'Today'
		///</summary>
		public string currentText { get; set; }
		///<summary>
		///The format for parsed and displayed dates. This attribute is one of the regionalisation attributes. For a full list of the possible formats see the formatDate function.
		///Default: 'mm/dd/yy'
		///</summary>
		public string dateFormat { get; set; }
		///<summary>
		///The list of long day names, starting from Sunday, for use as requested via the dateFormat setting. They also appear as popup hints when hovering over the corresponding column headings. This attribute is one of the regionalisation attributes.
		///Default: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday']
		///</summary>
		public JsArray dayNames { get; set; }
		///<summary>
		///The list of minimised day names, starting from Sunday, for use as column headers within the datepicker. This attribute is one of the regionalisation attributes.
		///Default: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa']
		///</summary>
		public JsArray dayNamesMin { get; set; }
		///<summary>
		///The list of abbreviated day names, starting from Sunday, for use as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
		///Default: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
		///</summary>
		public JsArray dayNamesShort { get; set; }
		///<summary>
		///Set the date to highlight on first opening if the field is blank. Specify either an actual date via a Date object, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		///Default: null
		///Types: Date, Number, String
		///</summary>
		public object defaultDate { get; set; }
		///<summary>
		///Control the speed at which the datepicker appears, it may be a time in milliseconds, a string representing one of the three predefined speeds ("slow", "normal", "fast"), or '' for immediately.
		///Default: 'normal'
		///Types: String, Number
		///</summary>
		public object duration { get; set; }
		///<summary>
		///Set the first day of the week: Sunday is 0, Monday is 1, ... This attribute is one of the regionalisation attributes.
		///Default: 0
		///</summary>
		public int firstDay { get; set; }
		///<summary>
		///If true, the current day link moves to the currently selected date instead of today.
		///Default: false
		///</summary>
		public bool gotoCurrent { get; set; }
		///<summary>
		///Normally the previous and next links are disabled when not applicable (see minDate/maxDate). You can hide them altogether by setting this attribute to true.
		///Default: false
		///</summary>
		public bool hideIfNoPrevNext { get; set; }
		///<summary>
		///True if the current language is drawn from right to left. This attribute is one of the regionalisation attributes.
		///Default: false
		///</summary>
		public bool isRTL { get; set; }
		///<summary>
		///Set a maximum selectable date via a Date object, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +1w'), or null for no limit.
		///Default: null
		///Types: Date, Number, String
		///</summary>
		public object maxDate { get; set; }
		///<summary>
		///Set a minimum selectable date via a Date object, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '-1y -1m'), or null for no limit.
		///Default: null
		///Types: Date, Number, String
		///</summary>
		public object minDate { get; set; }
		///<summary>
		///The list of full month names, as used in the month header on each datepicker and as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
		///Default: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']
		///</summary>
		public JsArray monthNames { get; set; }
		///<summary>
		///The list of abbreviated month names, for use as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
		///Default: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
		///</summary>
		public JsArray monthNamesShort { get; set; }
		///<summary>
		///When true the formatDate function is applied to the prevText, nextText, and currentText values before display, allowing them to display the target month names for example.
		///Default: false
		///</summary>
		public bool navigationAsDateFormat { get; set; }
		///<summary>
		///The text to display for the next month link. This attribute is one of the regionalisation attributes. With the standard ThemeRoller styling, this value is replaced by an icon.
		///Default: 'Next'
		///</summary>
		public string nextText { get; set; }
		///<summary>
		///Set how many months to show at once. The value can be a straight integer, or can be a two-element array to define the number of rows and columns to display.
		///Default: 1
		///Types: Number, Array
		///</summary>
		public object numberOfMonths { get; set; }
		///<summary>
		///The text to display for the previous month link. This attribute is one of the regionalisation attributes. With the standard ThemeRoller styling, this value is replaced by an icon.
		///Default: 'Prev'
		///</summary>
		public string prevText { get; set; }
		///<summary>
		///Set the cutoff year for determining the century for a date (used in conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then this value is used directly. If a string value is provided then it is converted to a number and added to the current year. Once the cutoff year is calculated, any dates entered with a year value less than or equal to it are considered to be in the current century, while those greater than it are deemed to be in the previous century.
		///Default: '+10'
		///Types: String, Number
		///</summary>
		public object shortYearCutoff { get; set; }
		///<summary>
		///Set the name of the animation used to show/hide the datepicker. Use 'show' (the default), 'slideDown', 'fadeIn', or any of the show/hide jQuery UI effects.
		///Default: 'show'
		///</summary>
		public string showAnim { get; set; }
		///<summary>
		///Whether to show the button panel.
		///Default: false
		///</summary>
		public bool showButtonPanel { get; set; }
		///<summary>
		///Specify where in a multi-month display the current month shows, starting from 0 at the top/left.
		///Default: 0
		///</summary>
		public int showCurrentAtPos { get; set; }
		///<summary>
		///Whether to show the month after the year in the header.
		///Default: false
		///</summary>
		public bool showMonthAfterYear { get; set; }
		///<summary>
		///Have the datepicker appear automatically when the field receives focus ('focus'), appear only when a button is clicked ('button'), or appear when either event takes place ('both').
		///Default: 'focus'
		///</summary>
		public string showOn { get; set; }
		///<summary>
		///If using one of the jQuery UI effects for showAnim, you can provide additional settings for that animation via this option.
		///Default: {}
		///</summary>
		public JsObject showOptions { get; set; }
		///<summary>
		///Display dates in other months (non-selectable) at the start or end of the current month.
		///Default: false
		///</summary>
		public bool showOtherMonths { get; set; }
		///<summary>
		///Set how many months to move when clicking the Previous/Next links.
		///Default: 1
		///</summary>
		public int stepMonths { get; set; }
		///<summary>
		///Control the range of years displayed in the year drop-down: either relative to current year (-nn:+nn) or absolute (nnnn:nnnn).
		///Default: '-10:+10'
		///</summary>
		public string yearRange { get; set; }
		///<summary>
		///Can be a function that takes an input field and current datepicker instance and returns an options object to update the datepicker with. It is called just before the datepicker is displayed.
		///Default: null
		///</summary>
		public jQueryUIEvent beforeShow { get; set; }
		///<summary>
		///The function takes a date as a parameter and must return an array with [0] equal to true/false indicating whether or not this date is selectable, [1] equal to a CSS class name(s) or '' for the default presentation and [2] an optional popup tooltip for this date. It is called for each day in the datepicker before is it displayed.
		///Default: null
		///</summary>
		public jQueryUIEvent beforeShowDay { get; set; }
		///<summary>
		///Allows you to define your own event when the datepicker moves to a new month and/or year. The function receives the selected year, month (1-12), and the datepicker instance as parameters. this refers to the associated input field.
		///Default: null
		///Types: function(year, month, inst)
		///</summary>
		public jQueryUIEvent onChangeMonthYear { get; set; }
		///<summary>
		///Allows you to define your own event when the datepicker is closed, whether or not a date is selected. The function receives the selected date as text and the datepicker instance as parameters. this refers to the associated input field.
		///Default: null
		///Types: function(dateText, inst)
		///</summary>
		public jQueryUIEvent onClose { get; set; }
		///<summary>
		///Allows you to define your own event when the datepicker is selected. The function receives the selected date as text and the datepicker instance as parameters. this refers to the associated input field.
		///Default: null
		///Types: function(dateText, inst)
		///</summary>
		public jQueryUIEvent onSelect { get; set; }
	}
	#endregion
	#region Dialog
	///<summary>
	///A dialog is a floating window that contains a title bar and a content area. The dialog window can be moved, resized and closed with the 'x' icon by default. 
	///If the content length exceeds the maximum height, a scrollbar will automatically appear. 
	///A bottom button bar and semi-transparent modal overlay layer are common options that can be added. 
	///A call to $(foo).dialog() initializes a dialog. If you want a click to open a dialog, use $(foo).dialog('open'), but if the dialog hasn't been destroyed, the $(foo).dialog() init call is only required once, not on each click. 
	///</summary>
	public static partial class DialogExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery dialog(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery dialog(this jQuery query, DialogOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery dialog(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region DialogOptions
	///<summary>
	///Options JSON object for Dialog
	///</summary>
	[JsType(JsMode.Json)]
	public partial class DialogOptions
	{
		///<summary>
		///When autoOpen is true the dialog will open automatically when dialog is called. If false it will stay hidden until .dialog("open") is called on it.
		///Default: true
		///</summary>
		public bool autoOpen { get; set; }
		///<summary>
		///When true, the bgiframe plugin will be used, to fix the issue in IE6 where select boxes show on top of other elements, regardless of zIndex. Requires including the bgiframe plugin. Future versions may not require a separate plugin.
		///Default: false
		///</summary>
		public bool bgiframe { get; set; }
		///<summary>
		///Specifies which buttons should be displayed on the dialog. The property key is the text of the button. The value is the callback function for when the button is clicked. The context of the callback is the dialog element; if you need access to the button, it is available as the target of the event object. 
		///Default: { }
		///</summary>
		public object buttons { get; set; }
		///<summary>
		///Specifies whether the dialog should close when it has focus and the user presses the esacpe (ESC) key.
		///Default: true
		///</summary>
		public bool closeOnEscape { get; set; }
		///<summary>
		///The specified class name(s) will be added to the dialog, for additional theming.
		///Default: ''
		///</summary>
		public string dialogClass { get; set; }
		///<summary>
		///If set to true, the dialog will be draggable will be draggable by the titlebar.
		///Default: true
		///</summary>
		public bool draggable { get; set; }
		///<summary>
		///The height of the dialog, in pixels.
		///Default: 'auto'
		///</summary>
		public int height { get; set; }
		///<summary>
		///The effect to be used when the dialog is closed.
		///Default: null
		///</summary>
		public string hide { get; set; }
		///<summary>
		///The maximum height to which the dialog can be resized, in pixels.
		///Default: false
		///</summary>
		public int maxHeight { get; set; }
		///<summary>
		///The maximum width to which the dialog can be resized, in pixels.
		///Default: false
		///</summary>
		public int maxWidth { get; set; }
		///<summary>
		///The minimum height to which the dialog can be resized, in pixels.
		///Default: 150
		///</summary>
		public int minHeight { get; set; }
		///<summary>
		///The minimum width to which the dialog can be resized, in pixels.
		///Default: 150
		///</summary>
		public int minWidth { get; set; }
		///<summary>
		///If set to true, the dialog will have modal behavior; other items on the page will be disabled (i.e. cannot be interacted with). Modal dialogs create an overlay below the dialog but above other page elements.
		///Default: false
		///</summary>
		public bool modal { get; set; }
		///<summary>
		///Specifies where the dialog should be displayed. Possible values: 'center', 'left', 'right', 'top', 'bottom', or an array containing a coordinate pair (in pixel offset from top left of viewport) or the possible string values (e.g. ['right','top'] for top right corner).
		///Default: 'center'
		///Types: String, Array
		///</summary>
		public object position { get; set; }
		///<summary>
		///If set to true, the dialog will be resizeable.
		///Default: true
		///</summary>
		public bool resizable { get; set; }
		///<summary>
		///The effect to be used when the dialog is opened.
		///Default: null
		///</summary>
		public string show { get; set; }
		///<summary>
		///Specifies whether the dialog will stack on top of other dialogs. This will cause the dialog to move to the front of other dialogs when it gains focus.
		///Default: true
		///</summary>
		public bool stack { get; set; }
		///<summary>
		///Specifies the title of the dialog. The title can also be specified by the title attribute on the dialog source element.
		///Default: ''
		///</summary>
		public string title { get; set; }
		///<summary>
		///The width of the dialog, in pixels.
		///Default: 300
		///</summary>
		public int width { get; set; }
		///<summary>
		///The starting z-index for the dialog.
		///Default: 1000
		///</summary>
		public int zIndex { get; set; }
		///<summary>
		///This event is triggered when a dialog attempts to close. If the beforeclose event handler (callback function) returns false, the close will be prevented.
		///Default: null
		///</summary>
		public jQueryUIEvent beforeclose { get; set; }
		///<summary>
		///This event is triggered when dialog is opened.
		///Default: null
		///</summary>
		public jQueryUIEvent open { get; set; }
		///<summary>
		///This event is triggered when the dialog gains focus.
		///Default: null
		///</summary>
		public jQueryUIEvent focus { get; set; }
		///<summary>
		///This event is triggered at the beginning of the dialog being dragged.
		///Default: null
		///</summary>
		public jQueryUIEvent dragStart { get; set; }
		///<summary>
		///This event is triggered when the dialog is dragged.
		///Default: null
		///</summary>
		public jQueryUIEvent drag { get; set; }
		///<summary>
		///This event is triggered after the dialog has been dragged.
		///Default: null
		///</summary>
		public jQueryUIEvent dragStop { get; set; }
		///<summary>
		///This event is triggered at the beginning of the dialog being resized.
		///Default: null
		///</summary>
		public jQueryUIEvent resizeStart { get; set; }
		///<summary>
		///This event is triggered when the dialog is resized.
		///Default: null
		///</summary>
		public jQueryUIEvent resize { get; set; }
		///<summary>
		///This event is triggered after the dialog has been resized.
		///Default: null
		///</summary>
		public jQueryUIEvent resizeStop { get; set; }
		///<summary>
		///This event is triggered when the dialog is closed.
		///Default: null
		///</summary>
		public jQueryUIEvent close { get; set; }
	}
	#endregion
	#region Draggable
	///<summary>
	///The jQuery UI Draggable plugin makes selected elements draggable by mouse.
	///Draggable elements gets a class of ui-draggable. During drag the element also gets a class of ui-draggable-dragging. If you want not just drag, but drag-and-drop, see the jQuery UI Droppable plugin, which provides a drop target for draggables.
	///All callbacks (start, stop, drag) receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
	///ui.helper - the jQuery object representing the helper that's being dragged
	///ui.position - current position of the helper as { top, left } object, relative to the offset element
	///ui.offset - current absolute position of the helper as { top, left } object, relative to page
	///</summary>
	public static partial class DraggableExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery draggable(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery draggable(this jQuery query, DraggableOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery draggable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region DraggableOptions
	///<summary>
	///Options JSON object for Draggable
	///</summary>
	[JsType(JsMode.Json)]
	public partial class DraggableOptions
	{
		///<summary>
		///If set to false, will prevent the ui-draggable class from being added. This may be desired as a performance optimization when calling .draggable() init on many hundreds of elements.
		///Default: true
		///</summary>
		public bool addClasses { get; set; }
		///<summary>
		///The element passed to or selected by the appendTo option will be used as the draggable helper's container during dragging. By default, the helper is appended to the same container as the draggable.
		///Default: 'parent'
		///Types: Element, Selector
		///</summary>
		public object appendTo { get; set; }
		///<summary>
		///Constrains dragging to either the horizontal (x) or vertical (y) axis. Possible values: 'x', 'y'.
		///Default: false
		///</summary>
		public string axis { get; set; }
		///<summary>
		///Prevents dragging from starting on specified elements.
		///Default: ':input,option'
		///</summary>
		public string cancel { get; set; }
		///<summary>
		///Allows the draggable to be dropped onto the specified sortables. If this option is used (helper must be set to 'clone' in order to work flawlessly), a draggable can be dropped onto a sortable list and then becomes part of it. 
		///Note: Specifying this option as an array of selectors has been removed.
		///Default: false
		///</summary>
		public string connectToSortable { get; set; }
		///<summary>
		///Constrains dragging to within the bounds of the specified element or region. Possible string values: 'parent', 'document', 'window', [x1, y1, x2, y2].
		///Default: false
		///Types: Selector, Element, String, Array
		///</summary>
		public object containment { get; set; }
		///<summary>
		///The css cursor during the drag operation.
		///Default: 'auto'
		///</summary>
		public string cursor { get; set; }
		///<summary>
		///Moves the dragging helper so the cursor always appears to drag from the same position. Coordinates can be given as a hash using a combination of one or two keys: { top, left, right, bottom }.
		///Default: false
		///</summary>
		public object cursorAt { get; set; }
		///<summary>
		///Time in milliseconds after mousedown until dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
		///Default: 0
		///</summary>
		public int delay { get; set; }
		///<summary>
		///Distance in pixels after mousedown the mouse must move before dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
		///Default: 1
		///</summary>
		public int distance { get; set; }
		///<summary>
		///Snaps the dragging helper to a grid, every x and y pixels. Array values: [x, y]
		///Default: false
		///</summary>
		public JsArray grid { get; set; }
		///<summary>
		///If specified, restricts drag start click to the specified element(s).
		///Default: false
		///Types: Element, Selector
		///</summary>
		public object handle { get; set; }
		///<summary>
		///Allows for a helper element to be used for dragging display. Possible values: 'original', 'clone', Function. If a function is specified, it must return a DOMElement.
		///Default: 'original'
		///Types: String, Function
		///</summary>
		public object helper { get; set; }
		///<summary>
		///Prevent iframes from capturing the mousemove events during a drag. Useful in combination with cursorAt, or in any case, if the mouse cursor is not over the helper. If set to true, transparent overlays will be placed over all iframes on the page. If a selector is supplied, the matched iframes will have an overlay placed over them.
		///Default: false
		///Types: Boolean, Selector
		///</summary>
		public object iframeFix { get; set; }
		///<summary>
		///Opacity for the helper while being dragged.
		///Default: false
		///</summary>
		public float opacity { get; set; }
		///<summary>
		///If set to true, all droppable positions are calculated on every mousemove. Caution: This solves issues on highly dynamic pages, but dramatically decreases performance.
		///Default: false
		///</summary>
		public bool refreshPositions { get; set; }
		///<summary>
		///If set to true, the element will return to its start position when dragging stops. Possible string values: 'valid', 'invalid'. If set to invalid, revert will only occur if the draggable has not been dropped on a droppable. For valid, it's the other way around.
		///Default: false
		///Types: Boolean, String
		///</summary>
		public object revert { get; set; }
		///<summary>
		///The duration of the revert animation, in milliseconds. Ignored if revert is false.
		///Default: 500
		///</summary>
		public int revertDuration { get; set; }
		///<summary>
		///Used to group sets of draggable and droppable items, in addition to droppable's accept option. A draggable with the same scope value as a droppable will be accepted by the droppable.
		///Default: 'default'
		///</summary>
		public string scope { get; set; }
		///<summary>
		///If set to true, container auto-scrolls while dragging.
		///Default: true
		///</summary>
		public bool scroll { get; set; }
		///<summary>
		///Distance in pixels from the edge of the viewport after which the viewport should scroll. Distance is relative to pointer, not the draggable.
		///Default: 20
		///</summary>
		public int scrollSensitivity { get; set; }
		///<summary>
		///The speed at which the window should scroll once the mouse pointer gets within the scrollSensitivity distance.
		///Default: 20
		///</summary>
		public int scrollSpeed { get; set; }
		///<summary>
		///If set to a selector or to true (equivalent to '.ui-draggable'), the draggable will snap to the edges of the selected elements when near an edge of the element.
		///Default: false
		///Types: Boolean, Selector
		///</summary>
		public object snap { get; set; }
		///<summary>
		///Determines which edges of snap elements the draggable will snap to. Ignored if snap is false. Possible values: 'inner', 'outer', 'both'
		///Default: 'both'
		///</summary>
		public string snapMode { get; set; }
		///<summary>
		///The distance in pixels from the snap element edges at which snapping should occur. Ignored if snap is false.
		///Default: 20
		///</summary>
		public int snapTolerance { get; set; }
		///<summary>
		///Controls the z-Index of the defined group (key 'group' in the hash, accepts jQuery selector) automatically, always brings to front the dragged item. Very useful in things like window managers. Optionally, a 'min' key can be set, so the zIndex cannot go below that value.
		///Default: false
		///</summary>
		public object stack { get; set; }
		///<summary>
		///z-index for the helper while being dragged.
		///Default: false
		///</summary>
		public int zIndex { get; set; }
		///<summary>
		///This event is triggered when dragging starts.
		///Default: null
		///</summary>
		public DraggableEvent start { get; set; }
		///<summary>
		///This event is triggered when the mouse is moved during the dragging.
		///Default: null
		///</summary>
		public DraggableEvent drag { get; set; }
		///<summary>
		///This event is triggered when dragging stops.
		///Default: null
		///</summary>
		public DraggableEvent stop { get; set; }
	}
	#endregion
	#region Droppable
	///<summary>
	///The jQuery UI Droppable plugin makes selected elements droppable (meaning they accept being dropped on by draggables). You can specify which (individually) or which kind of draggables each will accept.
	///All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
	///ui.draggable - current draggable element, a jQuery object.
	///ui.helper - current draggable helper, a jQuery object
	///ui.position - current position of the draggable helper { top: , left: }
	///ui.offset - current absolute position of the draggable helper { top: , left: }
	///</summary>
	public static partial class DroppableExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery droppable(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery droppable(this jQuery query, DroppableOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery droppable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region DroppableOptions
	///<summary>
	///Options JSON object for Droppable
	///</summary>
	[JsType(JsMode.Json)]
	public partial class DroppableOptions
	{
		///<summary>
		///All draggables that match the selector will be accepted. If a function is specified, the function will be called for each draggable on the page (passed as the first argument to the function), to provide a custom filter. The function should return true if the draggable should be accepted.
		///Default: '*'
		///Types: Selector, Function
		///</summary>
		public object accept { get; set; }
		///<summary>
		///If specified, the class will be added to the droppable while an acceptable draggable is being dragged.
		///Default: false
		///</summary>
		public string activeClass { get; set; }
		///<summary>
		///If set to false, will prevent the ui-droppable class from being added. This may be desired as a performance optimization when calling .droppable() init on many hundreds of elements.
		///Default: true
		///</summary>
		public bool addClasses { get; set; }
		///<summary>
		///If true, will prevent event propagation on nested droppables.
		///Default: false
		///</summary>
		public bool greedy { get; set; }
		///<summary>
		///If specified, the class will be added to the droppable while an acceptable draggable is being hovered.
		///Default: false
		///</summary>
		public string hoverClass { get; set; }
		///<summary>
		///Used to group sets of draggable and droppable items, in addition to droppable's accept option. A draggable with the same scope value as a droppable will be accepted.
		///Default: 'default'
		///</summary>
		public string scope { get; set; }
		///<summary>
		///Specifies which mode to use for testing whether a draggable is 'over' a droppable. Possible values: 'fit', 'intersect', 'pointer', 'touch'. 
		///fit: draggable overlaps the droppable entirely
		///intersect: draggable overlaps the droppable at least 50%
		///pointer: mouse pointer overlaps the droppable
		///touch: draggable overlaps the droppable any amount
		///Default: 'intersect'
		///</summary>
		public string tolerance { get; set; }
		///<summary>
		///This event is triggered any time an accepted draggable starts dragging. This can be useful if you want to make the droppable 'light up' when it can be dropped on.
		///Default: null
		///</summary>
		public DroppableEvent activate { get; set; }
		///<summary>
		///This event is triggered any time an accepted draggable stops dragging.
		///Default: null
		///</summary>
		public DroppableEvent deactivate { get; set; }
		///<summary>
		///This event is triggered as an accepted draggable is dragged 'over' (within the tolerance of) this droppable.
		///Default: null
		///</summary>
		public DroppableEvent over { get; set; }
		///<summary>
		///This event is triggered when an accepted draggable is dragged out (within the tolerance of) this droppable.
		///Default: null
		///</summary>
		public DroppableEvent @out { get; set; }
		///<summary>
		///This event is triggered when an accepted draggable is dropped 'over' (within the tolerance of) this droppable. In the callback, $(this) represents the droppable the draggable is dropped on. ui.draggable represents the draggable.
		///Default: null
		///</summary>
		public DroppableEvent drop { get; set; }
	}
	#endregion
	#region Effect
	///<summary>
	///[edit]effect( effect, [options], [speed], [callback] )
	///Uses a specific effect on an element (without the show/hide logic).
	///</summary>
	public static partial class EffectExtension
	{
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <param name="options">A object/hash including specific options for the effect.</param>
		/// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
		/// <param name="callback">A function that is called after the effect is completed.</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, string effect, object options, object speed, jQueryUIEvent callback) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <param name="options">A object/hash including specific options for the effect.</param>
		/// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, string effect, object options, object speed) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <param name="options">A object/hash including specific options for the effect.</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, string effect, object options) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, string effect) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <param name="options">A object/hash including specific options for the effect.</param>
		/// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
		/// <param name="callback">A function that is called after the effect is completed.</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, EffectType effect, object options, object speed, jQueryUIEvent callback) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <param name="options">A object/hash including specific options for the effect.</param>
		/// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, EffectType effect, object options, object speed) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <param name="options">A object/hash including specific options for the effect.</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, EffectType effect, object options) { return default(jQuery); }
		/// <summary>
		/// Uses a specific effect on an element (without the show/hide logic).
		/// </summary>
		/// <param name="query"></param>
		/// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
		/// <returns>jQuery</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery effect(this jQuery query, EffectType effect) { return default(jQuery); }
	}

	[JsType(JsMode.Json)]
	[JsEnum(ValuesAsNames = true)]
	public enum EffectType
	{
		blind,
		bounce,
		clip,
		drop,
		explode,
		fade,
		fold,
		highlight,
		puff,
		pulsate,
		scale,
		shake,
		size,
		slide,
		transfer,
	}
	#endregion
	#region Hide
	///<summary>
	///[edit]hide( effect, [options], [speed], [callback] )
	///The enhanced hide method optionally accepts jQuery UI advanced effects.
	///Uses a specific effect on an element to hide the element if the first argument is an effect string.
	///</summary>
	public static partial class HideExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery hide(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery hide(this jQuery query, HideOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery hide(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region HideOptions
	///<summary>
	///Options JSON object for Hide
	///</summary>
	[JsType(JsMode.Json)]
	public partial class HideOptions
	{
		///<summary>
		///The effect to be used. Possible values: 'blind', 'clip', 'drop', 'explode', 'fold', 'puff', 'slide', 'scale', 'size', 'pulsate'.
		///Default: null
		///</summary>
		public string effect { get; set; }
		///<summary>
		///A object/hash including specific options for the effect.
		///Default: null
		///</summary>
		public object options { get; set; }
		///<summary>
		///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
		///Default: null
		///Types: String, Number
		///</summary>
		public object speed { get; set; }
		///<summary>
		///A function that is called after the effect is completed.
		///Default: null
		///</summary>
		public jQueryUIEvent callback { get; set; }
	}
	#endregion
	#region Progressbar
	///<summary>
	///The progress bar is designed to simply display the current % complete for a process. The bar is coded to be flexibly sized through CSS and will scale to fit inside it's parent container by default. 
	///This is a determinate progress bar, meaning that it should only be used in situations where the system can accurately update the current status complete. A determinate progress bar should never fill from left to right, then loop back to empty for a single process -- if the actual percent complete status cannot be calculated, an indeterminate progress bar (coming soon) or spinner animation is a better way to provide user feedback. 
	///</summary>
	public static partial class ProgressbarExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery progressbar(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery progressbar(this jQuery query, ProgressbarOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery progressbar(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region ProgressbarOptions
	///<summary>
	///Options JSON object for Progressbar
	///</summary>
	[JsType(JsMode.Json)]
	public partial class ProgressbarOptions
	{
		///<summary>
		///The value of the progressbar.
		///Default: 0
		///</summary>
		public int value { get; set; }
		///<summary>
		///This event is triggered when the value of the progressbar changes.
		///Default: null
		///</summary>
		public jQueryUIEvent change { get; set; }
	}
	#endregion
	#region RemoveClass
	///<summary>
	///[edit]removeClass( [class], [duration] )
	///Removes all or specified class from each of the set of matched elements with an optional transition between the states.
	///</summary>
	public static partial class RemoveClassExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery removeclass(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery removeclass(this jQuery query, RemoveClassOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery removeclass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region RemoveClassOptions
	///<summary>
	///Options JSON object for RemoveClass
	///</summary>
	[JsType(JsMode.Json)]
	public partial class RemoveClassOptions
	{
		///<summary>
		///CSS classes to remove from the elements.
		///Default: null
		///</summary>
		public string @class { get; set; }
		///<summary>
		///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
		///Default: null
		///Types: String, Number
		///</summary>
		public object duration { get; set; }
	}
	#endregion
	#region Resizable
	///<summary>
	///The jQuery UI Resizable plugin makes selected elements resizable (meaning they have draggable resize handles). You can specify one or more handles as well as min and max width and height.
	///All callbacks (start,stop,resize) receive two arguments: The original browser event and a prepared ui object. The ui object has the following fields:
	///ui.helper - a jQuery object containing the helper element
	///ui.originalPosition - {top, left} before resizing started
	///ui.originalSize - {width, height} before resizing started
	///ui.position - {top, left} current position
	///ui.size - {width, height} current size
	///</summary>
	public static partial class ResizableExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery resizable(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery resizable(this jQuery query, ResizableOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery resizable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region ResizableOptions
	///<summary>
	///Options JSON object for Resizable
	///</summary>
	[JsType(JsMode.Json)]
	public partial class ResizableOptions
	{
		///<summary>
		///Resize these elements synchronous when resizing.
		///Default: false
		///Types: Selector, jQuery, Element
		///</summary>
		public object alsoResize { get; set; }
		///<summary>
		///Animates to the final size after resizing.
		///Default: false
		///</summary>
		public bool animate { get; set; }
		///<summary>
		///Duration time for animating, in milliseconds. Other possible values: 'slow', 'normal', 'fast'.
		///Default: 'slow'
		///Types: Integer, String
		///</summary>
		public object animateDuration { get; set; }
		///<summary>
		///Easing effect for animating.
		///Default: 'swing'
		///</summary>
		public string animateEasing { get; set; }
		///<summary>
		///If set to true, resizing is constrained by the original aspect ratio. Otherwise a custom aspect ratio can be specified, such as 9 / 16, or 0.5.
		///Default: false
		///Types: Boolean, Float
		///</summary>
		public object aspectRatio { get; set; }
		///<summary>
		///If set to true, automatically hides the handles except when the mouse hovers over the element.
		///Default: false
		///</summary>
		public bool autoHide { get; set; }
		///<summary>
		///Prevents resizing if you start on elements matching the selector.
		///Default: ':input,option'
		///</summary>
		public string cancel { get; set; }
		///<summary>
		///Constrains resizing to within the bounds of the specified element. Possible values: 'parent', 'document', a DOMElement, or a Selector.
		///Default: false
		///Types: String, Element, Selector
		///</summary>
		public object containment { get; set; }
		///<summary>
		///Tolerance, in milliseconds, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond duration. This can help prevent unintended resizing when clicking on an element.
		///Default: 0
		///</summary>
		public int delay { get; set; }
		///<summary>
		///Tolerance, in pixels, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond distance. This can help prevent unintended resizing when clicking on an element.
		///Default: 1
		///</summary>
		public int distance { get; set; }
		///<summary>
		///If set to true, a semi-transparent helper element is shown for resizing.
		///Default: false
		///</summary>
		public bool ghost { get; set; }
		///<summary>
		///Snaps the resizing element to a grid, every x and y pixels. Array values: [x, y]
		///Default: false
		///</summary>
		public JsArray grid { get; set; }
		///<summary>
		///If specified as a string, should be a comma-split list of any of the following: 'n, e, s, w, ne, se, sw, nw, all'. The necessary handles will be auto-generated by the plugin. 
		///If specified as an object, the following keys are supported: { n, e, s, w, ne, se, sw, nw }. The value of any specified should be a jQuery selector matching the child element of the resizable to use as that handle. If the handle is not a child of the resizable, you can pass in the DOMElement or a valid jQuery object directly.
		///Default: 'e, s, se'
		///Types: String, Object
		///</summary>
		public object handles { get; set; }
		///<summary>
		///This is the css class that will be added to a proxy element to outline the resize during the drag of the resize handle. Once the resize is complete, the original element is sized.
		///Default: false
		///</summary>
		public string helper { get; set; }
		///<summary>
		///This is the maximum height the resizable should be allowed to resize to.
		///Default: null
		///</summary>
		public int maxHeight { get; set; }
		///<summary>
		///This is the maximum width the resizable should be allowed to resize to.
		///Default: null
		///</summary>
		public int maxWidth { get; set; }
		///<summary>
		///This is the minimum height the resizable should be allowed to resize to.
		///Default: 10
		///</summary>
		public int minHeight { get; set; }
		///<summary>
		///This is the minimum width the resizable should be allowed to resize to.
		///Default: 10
		///</summary>
		public int minWidth { get; set; }
		///<summary>
		///This event is triggered at the start of a resize operation.
		///Default: null
		///</summary>
		public jQueryUIEvent start { get; set; }
		///<summary>
		///This event is triggered during the resize, on the drag of the resize handler.
		///Default: null
		///</summary>
		public jQueryUIEvent resize { get; set; }
		///<summary>
		///This event is triggered at the end of a resize operation.
		///Default: null
		///</summary>
		public jQueryUIEvent stop { get; set; }
	}
	#endregion
	#region Selectable
	///<summary>
	///The jQuery UI Selectable plugin allows for elements to be selected by dragging a box (sometimes called a lasso) with the mouse over the elements. Also, elements can be selected by click or drag while holding the Ctrl/Meta key, allowing for multiple (non-contiguous) selections.
	///</summary>
	public static partial class SelectableExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery selectable(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery selectable(this jQuery query, SelectableOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery selectable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region SelectableOptions
	///<summary>
	///Options JSON object for Selectable
	///</summary>
	[JsType(JsMode.Json)]
	public partial class SelectableOptions
	{
		///<summary>
		///This determines whether to refresh (recalculate) the position and size of each selectee at the beginning of each select operation. If you have many many items, you may want to set this to false and call the refresh method manually.
		///Default: true
		///</summary>
		public bool autoRefresh { get; set; }
		///<summary>
		///Prevents selecting if you start on elements matching the selector.
		///Default: ':input,option'
		///</summary>
		public string cancel { get; set; }
		///<summary>
		///Time in milliseconds to define when the selecting should start. It helps preventing unwanted selections when clicking on an element.
		///Default: 0
		///</summary>
		public int delay { get; set; }
		///<summary>
		///Tolerance, in pixels, for when selecting should start. If specified, selecting will not start until after mouse is dragged beyond distance.
		///Default: 0
		///</summary>
		public int distance { get; set; }
		///<summary>
		///The matching child elements will be made selectees (able to be selected).
		///Default: '*'
		///</summary>
		public string filter { get; set; }
		///<summary>
		///Possible values: 'touch', 'fit'. 
		///fit: draggable overlaps the droppable entirely
		///touch: draggable overlaps the droppable any amount
		///Default: 'touch'
		///</summary>
		public string tolerance { get; set; }
		///<summary>
		///This event is triggered at the end of the select operation, on each element added to the selection.
		///Default: null
		///</summary>
		public jQueryUIEvent selected { get; set; }
		///<summary>
		///This event is triggered during the select operation, on each element added to the selection.
		///Default: null
		///</summary>
		public jQueryUIEvent selecting { get; set; }
		///<summary>
		///This event is triggered at the beginning of the select operation.
		///Default: null
		///</summary>
		public jQueryUIEvent start { get; set; }
		///<summary>
		///This event is triggered at the end of the select operation.
		///Default: null
		///</summary>
		public jQueryUIEvent stop { get; set; }
		///<summary>
		///This event is triggered at the end of the select operation, on each element removed from the selection.
		///Default: null
		///</summary>
		public jQueryUIEvent unselected { get; set; }
		///<summary>
		///This event is triggered during the select operation, on each element removed from the selection.
		///Default: null
		///</summary>
		public jQueryUIEvent unselecting { get; set; }
	}
	#endregion
	#region Show
	///<summary>
	///[edit]show( effect, [options], [speed], [callback] )
	///The enhanced show method optionally accepts jQuery UI advanced effects.
	///Uses a specific effect on an element to show the element if the first argument is a effect string.
	///</summary>
	public static partial class ShowExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery show(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery show(this jQuery query, ShowOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery show(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region ShowOptions
	///<summary>
	///Options JSON object for Show
	///</summary>
	[JsType(JsMode.Json)]
	public partial class ShowOptions
	{
		///<summary>
		///The effect to be used. Possible values: 'blind', 'clip', 'drop', 'explode', 'fold', 'puff', 'slide', 'scale', 'size', 'pulsate'.
		///Default: null
		///</summary>
		public string effect { get; set; }
		///<summary>
		///A object/hash including specific options for the effect.
		///Default: null
		///</summary>
		public object options { get; set; }
		///<summary>
		///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
		///Default: null
		///Types: String, Number
		///</summary>
		public object speed { get; set; }
		///<summary>
		///A function that is called after the effect is completed.
		///Default: null
		///</summary>
		public jQueryUIEvent callback { get; set; }
	}
	#endregion
	#region Slider
	///<summary>
	///The jQuery UI Slider plugin makes selected elements into sliders. There are various options such as multiple handles, and ranges. The handle can be moved with the mouse or the arrow keys.
	///All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'): 
	///ui.handle: DOMElement - the current focused handle 
	///ui.value: Integer - the current handle's value 
	///</summary>
	public static partial class SliderExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery slider(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery slider(this jQuery query, SliderOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery slider(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region SliderOptions
	///<summary>
	///Options JSON object for Slider
	///</summary>
	[JsType(JsMode.Json)]
	public partial class SliderOptions
	{
		///<summary>
		///Whether to slide handle smoothly when user click outside handle on the bar.
		///Default: false
		///</summary>
		public bool animate { get; set; }
		///<summary>
		///The maximum value of the slider.
		///Default: 100
		///</summary>
		public JsNumber max { get; set; }
		///<summary>
		///The minimum value of the slider.
		///Default: 0
		///</summary>
		public JsNumber min { get; set; }
		///<summary>
		///Normally you don't need to set this option because the plugin detects the slider orientation automatically. If the orientation is not correctly detected you can set this option to 'horizontal' or 'vertical'.
		///Default: 'auto'
		///</summary>
		public string orientation { get; set; }
		///<summary>
		///If set to true, the slider will detect if you have two handles and create a stylable range element between these two. Two other possible values are 'min' and 'max'. A min range goes from the slider min to one handle. A max range goes from one handle to the slider max.
		///Default: false
		///Types: Boolean, String
		///</summary>
		public object range { get; set; }
		///<summary>
		///Determines the size or amount of each interval or step the slider takes between min and max. The full specified value range of the slider (max - min) needs to be evenly divisible by the step.
		///Default: 1
		///</summary>
		public JsNumber step { get; set; }
		///<summary>
		///Determines the value of the slider, if there's only one handle. If there is more than one handle, determines the value of the first handle.
		///Default: 0
		///</summary>
		public JsNumber value { get; set; }
		///<summary>
		///This option can be used to specify multiple handles. If range is set to true, the length of 'values' should be 2.
		///Default: null
		///</summary>
		public JsArray values { get; set; }
		///<summary>
		///This event is triggered when the user starts sliding.
		///Default: null
		///</summary>
		public jQueryUIEvent start { get; set; }
		///<summary>
		///This event is triggered on every mouse move during slide. Use ui.value (single-handled sliders) to obtain the value of the current handle, $(..).slider('value', index) to get another handles' value. 
		///Return false in order to prevent a slide, based on ui.value.
		///Default: null
		///</summary>
		public jQueryUIEvent slide { get; set; }
		///<summary>
		///This event is triggered on slide stop, or if the value is changed programmatically (by the value method). Takes arguments event and ui. Use event.orginalEvent to detect whether the value changed by mouse, keyboard, or programmatically. Use ui.value (single-handled sliders) to obtain the value of the current handle, $(this).slider('values', index) to get another handle's value.
		///Default: null
		///</summary>
		public jQueryUIEvent change { get; set; }
		///<summary>
		///This event is triggered when the user stops sliding.
		///Default: null
		///</summary>
		public jQueryUIEvent stop { get; set; }
	}
	#endregion
	#region Sortable
	///<summary>
	///The jQuery UI Sortable plugin makes selected elements sortable by dragging with the mouse.
	///All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
	///ui.helper - the current helper element (most often a clone of the item)
	///ui.position - current position of the helper
	///ui.offset - current absolute position of the helper
	///ui.item - the current dragged element
	///ui.placeholder - the placeholder (if you defined one)
	///ui.sender - the sortable where the item comes from (only exists if you move from one connected list to another)
	///</summary>
	public static partial class SortableExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery sortable(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery sortable(this jQuery query, SortableOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery sortable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region SortableOptions
	///<summary>
	///Options JSON object for Sortable
	///</summary>
	[JsType(JsMode.Json)]
	public partial class SortableOptions
	{
		///<summary>
		///Defines where the helper that moves with the mouse is being appended to during the drag (for example, to resolve overlap/zIndex issues).
		///Default: 'parent'
		///</summary>
		public string appendTo { get; set; }
		///<summary>
		///If defined, the items can be dragged only horizontally or vertically. Possible values:'x', 'y'.
		///Default: false
		///</summary>
		public string axis { get; set; }
		///<summary>
		///Prevents sorting if you start on elements matching the selector.
		///Default: ':input,button'
		///</summary>
		public string cancel { get; set; }
		///<summary>
		///Takes a jQuery selector with items that also have sortables applied. If used, the sortable is now connected to the other one-way, so you can drag from this sortable to the other.
		///Default: false
		///</summary>
		public string connectWith { get; set; }
		///<summary>
		///Constrains dragging to within the bounds of the specified element - can be a DOM element, 'parent', 'document', 'window', or a jQuery selector.
		///Default: false
		///Types: Element, String, Selector
		///</summary>
		public object containment { get; set; }
		///<summary>
		///Defines the cursor that is being shown while sorting.
		///Default: 'auto'
		///</summary>
		public string cursor { get; set; }
		///<summary>
		///Moves the sorting element or helper so the cursor always appears to drag from the same position. Coordinates can be given as a hash using a combination of one or two keys: { top, left, right, bottom }.
		///Default: false
		///</summary>
		public object cursorAt { get; set; }
		///<summary>
		///Time in milliseconds to define when the sorting should start. It helps preventing unwanted drags when clicking on an element.
		///Default: 0
		///</summary>
		public int delay { get; set; }
		///<summary>
		///Tolerance, in pixels, for when sorting should start. If specified, sorting will not start until after mouse is dragged beyond distance. Can be used to allow for clicks on elements within a handle.
		///Default: 1
		///</summary>
		public int distance { get; set; }
		///<summary>
		///If empty allows for an item to be dropped from a linked selectable.
		///Default: true
		///</summary>
		public bool dropOnEmpty { get; set; }
		///<summary>
		///If true, forces the helper to have a size.
		///Default: false
		///</summary>
		public bool forceHelperSize { get; set; }
		///<summary>
		///If true, forces the placeholder to have a size.
		///Default: false
		///</summary>
		public bool forcePlaceholderSize { get; set; }
		///<summary>
		///Snaps the sorting element or helper to a grid, every x and y pixels. Array values: [x, y]
		///Default: false
		///</summary>
		public JsArray grid { get; set; }
		///<summary>
		///Restricts sort start click to the specified element.
		///Default: false
		///Types: Selector, Element
		///</summary>
		public object handle { get; set; }
		///<summary>
		///Allows for a helper element to be used for dragging display. The supplied function receives the event and the element being sorted, and should return a DOMElement to be used as a custom proxy helper. Possible values: 'original', 'clone'
		///Default: 'original'
		///Types: String, Function
		///</summary>
		public object helper { get; set; }
		///<summary>
		///Specifies which items inside the element should be sortable.
		///Default: '> *'
		///</summary>
		public string items { get; set; }
		///<summary>
		///Defines the opacity of the helper while sorting. From 0.01 to 1
		///Default: false
		///</summary>
		public float opacity { get; set; }
		///<summary>
		///Class that gets applied to the otherwise white space.
		///Default: false
		///</summary>
		public string placeholder { get; set; }
		///<summary>
		///If set to true, the item will be reverted to its new DOM position with a smooth animation.
		///Default: false
		///</summary>
		public bool revert { get; set; }
		///<summary>
		///If set to true, the page scrolls when coming to an edge.
		///Default: true
		///</summary>
		public bool scroll { get; set; }
		///<summary>
		///Defines how near the mouse must be to an edge to start scrolling.
		///Default: 20
		///</summary>
		public int scrollSensitivity { get; set; }
		///<summary>
		///The speed at which the window should scroll once the mouse pointer gets within the scrollSensitivity distance.
		///Default: 20
		///</summary>
		public int scrollSpeed { get; set; }
		///<summary>
		///This is the way the reordering behaves during drag. Possible values: 'intersect', 'pointer'. In some setups, 'pointer' is more natural. 
		///intersect: draggable overlaps the droppable at least 50%
		///pointer: mouse pointer overlaps the droppable
		///Default: 'intersect'
		///</summary>
		public string tolerance { get; set; }
		///<summary>
		///Z-index for element/helper while being sorted.
		///Default: 1000
		///</summary>
		public int zIndex { get; set; }
		///<summary>
		///This event is triggered when sorting starts.
		///Default: null
		///</summary>
		public jQueryUIEvent start { get; set; }
		///<summary>
		///This event is triggered during sorting.
		///Default: null
		///</summary>
		public jQueryUIEvent sort { get; set; }
		///<summary>
		///This event is triggered during sorting, but only when the DOM position has changed.
		///Default: null
		///</summary>
		public jQueryUIEvent change { get; set; }
		///<summary>
		///This event is triggered when sorting stops, but when the placeholder/helper is still available.
		///Default: null
		///</summary>
		public jQueryUIEvent beforeStop { get; set; }
		///<summary>
		///This event is triggered when sorting has stopped.
		///Default: null
		///</summary>
		public jQueryUIEvent stop { get; set; }
		///<summary>
		///This event is triggered when the user stopped sorting and the DOM position has changed.
		///Default: null
		///</summary>
		public jQueryUIEvent update { get; set; }
		///<summary>
		///This event is triggered when a connected sortable list has received an item from another list.
		///Default: null
		///</summary>
		public jQueryUIEvent receive { get; set; }
		///<summary>
		///This event is triggered when a sortable item has been dragged out from the list and into another.
		///Default: null
		///</summary>
		public jQueryUIEvent remove { get; set; }
		///<summary>
		///This event is triggered when a sortable item is moved into a connected list.
		///Default: null
		///</summary>
		public jQueryUIEvent over { get; set; }
		///<summary>
		///This event is triggered when a sortable item is moved away from a connected list.
		///Default: null
		///</summary>
		public jQueryUIEvent @out { get; set; }
		///<summary>
		///This event is triggered when using connected lists, every connected list on drag start receives it.
		///Default: null
		///</summary>
		public jQueryUIEvent activate { get; set; }
		///<summary>
		///This event is triggered when sorting was stopped, is propagated to all possible connected lists.
		///Default: null
		///</summary>
		public jQueryUIEvent deactivate { get; set; }
	}
	#endregion
	#region SwitchClass
	///<summary>
	///[edit]switchClass( remove, add, [duration] )
	///Switches from the class defined in the first argument to the class defined as second argument, using an optional transition.
	///</summary>
	public static partial class SwitchClassExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery switchclass(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery switchclass(this jQuery query, SwitchClassOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery switchclass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region SwitchClassOptions
	///<summary>
	///Options JSON object for SwitchClass
	///</summary>
	[JsType(JsMode.Json)]
	public partial class SwitchClassOptions
	{
		///<summary>
		///The CSS class that will be removed.
		///Default: null
		///</summary>
		public string remove { get; set; }
		///<summary>
		///The CSS class that will be added.
		///Default: null
		///</summary>
		public string add { get; set; }
		///<summary>
		///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
		///Default: null
		///Types: String, Number
		///</summary>
		public object duration { get; set; }
	}
	#endregion
	#region Tabs
	///<summary>
	///Tabs are generally used to break content into multiple sections that can be swapped to save space, much like an accordion.
	///By default a tab widget will swap between tabbed sections onClick, but the events can be changed to onHover through an option. Tab content can be loaded via Ajax by setting an href on a tab.
	///Contents
	///1 Events
	///2 Ajax mode 
	///2.1 Back button and bookmarking
	///3 How to... 
	///3.1 ...retrieve the index of the currently selected tab
	///3.2 ...open links in the current tab instead of leaving the page
	///3.3 ...select a tab from a text link instead of clicking a tab itself
	///3.4 ...prevent switching to the tab on click depending on form validation
	///3.5 ...immediately select a just added tab
	///3.6 ...follow a tab's URL instead of loading its content via ajax
	///3.7 ...prevent a FOUC (Flash of Unstyled Content) before tabs are initialized
	///4 Why does... 
	///4.1 ...my slider, Google Map, sIFR etc. not work when placed in a hidden (inactive) tab?
	///[edit]Events
	///A series of events fire when interacting with a tabs interface: 
	///tabsselect, tabsload, tabsshow (in that order) 
	///tabsadd, tabsremove 
	///tabsenable, tabsdisable 
	///Event binding example: 
	///$('#example').bind('tabsselect', function(event, ui) {
	///    // Objects available in the function context:
	///    ui.tab     // anchor element of the selected (clicked) tab
	///    ui.panel   // element, that contains the selected/clicked tab contents
	///    ui.index   // zero-based index of the selected (clicked) tab
	///});Note that if a handler for the tabsselect event returns false, the clicked tab will not become selected (useful for example if switching to the next tab requires a form validation). 
	///[edit]Ajax mode 
	///Tabs supports loading tab content via Ajax in an unobtrusive manner. 
	///The HTML you need is slightly different from the one that is used for static tabs: A list of links pointing to existing resources (from where the content gets loaded) and no additional containers at all (unobtrusive!). The containers' markup is going to be created on the fly: 
	///<div id="example">
	///     <ul>
	///         <li><a href="ahah_1.html"><span>Content 1</span></a></li>
	///         <li><a href="ahah_2.html"><span>Content 2</span></a></li>
	///         <li><a href="ahah_3.html"><span>Content 3</span></a></li>
	///     </ul>
	///</div>
	///Obviously this degrades gracefully - the links, e.g. the content, will still be accessible with JavaScript disabled. 
	///Note that if you wish to reuse an existing container, you could do so by matching a title attribute and the container's id: 
	///<li><a href="hello/world.html" title="Todo Overview"> ... </a></li>
	///and a container like: 
	///<div id="Todo_Overview"> ... </div>
	///(Note how white space is replaced with an underscore) 
	///This is useful if you want a human readable hash in the URL instead of a cryptic generated one. 
	///[edit]Back button and bookmarking
	///Tabs 2 already supported this functionality, although the history plugin needs a rewrite first (it doesn't support Safari 3 and is in general a little inflexible) before it can be build back into the tabs. It is planned and Klaus is working on it whenever he finds the time. Actual bugs in the UI Tabs plugin itself always have higher priority though. 
	///[edit]How to...
	///[edit]...retrieve the index of the currently selected tab
	///var $tabs = $('#example').tabs();
	///var selected = $tabs.tabs('option', 'selected'); // => 0[edit]...open links in the current tab instead of leaving the page
	///"Hijax" links after tab content has been loaded: 
	///$('#example').tabs({
	///    load: function(event, ui) {
	///        $('a', ui.panel).click(function() {
	///            $(ui.panel).load(this.href);
	///            return false;
	///        });
	///    }
	///});[edit]...select a tab from a text link instead of clicking a tab itself
	///var $tabs = $('#example').tabs(); // first tab selected
	///$('#my-text-link').click(function() { // bind click event to link
	///    $tabs.tabs('select', 2); // switch to third tab
	///    return false;
	///});[edit]...prevent switching to the tab on click depending on form validation
	///Returning false in the tabs select handler prevents the clicked tab from becoming selected. 
	///$('#example').tabs({
	///    select: function(event, ui) {
	///        var isValid = ... // form validation returning true or false
	///        return isValid;
	///    }
	///});[edit]...immediately select a just added tab
	///var $tabs = $('#example').tabs({
	///    add: function(event, ui) {
	///        $tabs.tabs('select', '#' + ui.panel.id);
	///    }
	///});[edit]...follow a tab's URL instead of loading its content via ajax
	///Note that opening a tab in a new window is unexpected, e.g. inconsistent behaviour exposing a usablity problem (http://www.useit.com/alertbox/tabs.html). 
	///$('#example').tabs({
	///    select: function(event, ui) {
	///        var url = $.data(ui.tab, 'load.tabs');
	///        if( url ) {
	///            location.href = url;
	///            return false;
	///        }
	///        return true;
	///    }
	///});
	///[edit]...prevent a FOUC (Flash of Unstyled Content) before tabs are initialized
	///Add the necessary classes to hide an inactive tab panel to the HTML right away - note that this will not degrade gracefully with JavaScript being disabled: 
	///<div id="example" class="ui-tabs">
	///  ...
	///  <div id="a-tab-panel" class="ui-tabs-hide"> </div>
	///  ...
	///</div>[edit]Why does...
	///[edit]...my slider, Google Map, sIFR etc. not work when placed in a hidden (inactive) tab?
	///Any component that requires some dimensional computation for its initialization won't work in a hidden tab, because the tab panel itself is hidden via display: none so that any elements inside won't report their actual width and height (0 in most browsers). 
	///There's an easy workaround. Use the off-left technique for hiding inactive tab panels. E.g. in your style sheet replace the rule for the class selector ".ui-tabs .ui-tabs-hide" with 
	///.ui-tabs .ui-tabs-hide {
	///    position: absolute;
	///    left: -10000px;
	///}For Google maps you can also resize the map once the tab is displayed like this: 
	///$('#example').bind('tabsshow', function(event, ui) {
	///    if (ui.panel.id == "map-tab") {
	///        resizeMap();
	///    }
	///});resizeMap() will call Google Maps' checkResize() on the particular map. 
	///</summary>
	public static partial class TabsExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery tabs(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery tabs(this jQuery query, TabsOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery tabs(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region TabsOptions
	///<summary>
	///Options JSON object for Tabs
	///</summary>
	[JsType(JsMode.Json)]
	public partial class TabsOptions
	{
		///<summary>
		///Additional Ajax options to consider when loading tab content (see $.ajax).
		///Default: null
		///</summary>
		public JsObject ajaxOptions { get; set; }
		///<summary>
		///Whether or not to cache remote tabs content, e.g. load only once or with every click. Cached content is being lazy loaded, e.g once and only once for the first click. Note that to prevent the actual Ajax requests from being cached by the browser you need to provide an extra cache: false flag to ajaxOptions.
		///Default: false
		///</summary>
		public bool cache { get; set; }
		///<summary>
		///Set to true to allow an already selected tab to become unselected again upon reselection.
		///Default: false
		///</summary>
		public bool collapsible { get; set; }
		///<summary>
		///Store the latest selected tab in a cookie. The cookie is then used to determine the initially selected tab if the selected option is not defined. Requires cookie plugin. The object needs to have key/value pairs of the form the cookie plugin expects as options. Available options (example): { expires: 7, path: '/', domain: 'jquery.com', secure: true }. Since jQuery UI 1.7 it is also possible to define the cookie name being used via name property.
		///Default: null
		///</summary>
		public object cookie { get; set; }
		///<summary>
		///deprecated in jQuery UI 1.7, use collapsible.
		///Default: false
		///</summary>
		public bool deselectable { get; set; }
		///<summary>
		///An array containing the position of the tabs (zero-based index) that should be disabled on initialization.
		///Default: []
		///</summary>
		public JsArray<int> disabled { get; set; }
		///<summary>
		///The type of event to be used for selecting a tab.
		///Default: 'click'
		///</summary>
		public string @event { get; set; }
		///<summary>
		///Enable animations for hiding and showing tab panels. The duration option can be a string representing one of the three predefined speeds ("slow", "normal", "fast") or the duration in milliseconds to run an animation (default is "normal").
		///Default: null
		///Types: Options, Array&lt;Options&gt;
		///</summary>
		public object fx { get; set; }
		///<summary>
		///If the remote tab, its anchor element that is, has no title attribute to generate an id from, an id/fragment identifier is created from this prefix and a unique id returned by $.data(el), for example "ui-tabs-54".
		///Default: 'ui-tabs-'
		///</summary>
		public string idPrefix { get; set; }
		///<summary>
		///HTML template from which a new tab panel is created in case of adding a tab with the add method or when creating a panel for a remote tab on the fly.
		///Default: '<div></div>'
		///</summary>
		public string panelTemplate { get; set; }
		///<summary>
		///Zero-based index of the tab to be selected on initialization. To set all tabs to unselected pass -1 as value.
		///Default: 0
		///</summary>
		public int selected { get; set; }
		///<summary>
		///The HTML content of this string is shown in a tab title while remote content is loading. Pass in empty string to deactivate that behavior.
		///Default: '<em>Loading&#8230;</em>'
		///</summary>
		public string spinner { get; set; }
		///<summary>
		///HTML template from which a new tab is created and added. The placeholders #{href} and #{label} are replaced with the url and tab label that are passed as arguments to the add method.
		///Default: '<li><a href="#{href}"><span>#{label}</span></a></li>'
		///</summary>
		public string tabTemplate { get; set; }
	}
	#endregion
	#region Toggle
	///<summary>
	///[edit]toggle( effect, [options], [speed], [callback] )
	///The enhanced toggle method optionally accepts jQuery UI advanced effects.
	///Uses a specific effect on an element to toggle the element if the first argument is an effect string.
	///</summary>
	public static partial class ToggleExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery toggle(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery toggle(this jQuery query, ToggleOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery toggle(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region ToggleOptions
	///<summary>
	///Options JSON object for Toggle
	///</summary>
	[JsType(JsMode.Json)]
	public partial class ToggleOptions
	{
		///<summary>
		///The effect to be used. Possible values: 'blind', 'clip', 'drop', 'explode', 'fold', 'puff', 'slide', 'scale', 'size', 'pulsate'.
		///Default: null
		///</summary>
		public string effect { get; set; }
		///<summary>
		///A object/hash including specific options for the effect.
		///Default: null
		///</summary>
		public object options { get; set; }
		///<summary>
		///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
		///Default: null
		///Types: String, Number
		///</summary>
		public object speed { get; set; }
		///<summary>
		///A function that is called after the effect is completed.
		///Default: null
		///</summary>
		public jQueryUIEvent callback { get; set; }
	}
	#endregion
	#region ToggleClass
	///<summary>
	///[edit]toggleClass( class, [duration] )
	///Adds the specified class if it is not present, and removes the specified class if it is present, using an optional transition.
	///</summary>
	public static partial class ToggleClassExtension
	{
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery toggleclass(this jQuery query) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery toggleclass(this jQuery query, ToggleClassOptions options) { return default(jQuery); }
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static jQuery toggleclass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
	}
	#endregion
	#region ToggleClassOptions
	///<summary>
	///Options JSON object for ToggleClass
	///</summary>
	[JsType(JsMode.Json)]
	public partial class ToggleClassOptions
	{
		///<summary>
		///A CSS class to toggle on the elements.
		///Default: null
		///</summary>
		public string @class { get; set; }
		///<summary>
		///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
		///Default: null
		///Types: String, Number
		///</summary>
		public object duration { get; set; }
	}
	#endregion

	[JsDelegate(NativeDelegates = true)]
	[JsType(JsMode.Json, OmitCasts = true, Export = false)]
	public delegate void jQueryUIEvent(Event e, object ui);

	[JsDelegate(NativeDelegates = true)]
	[JsType(JsMode.Json, OmitCasts = true, Export = false)]
	public delegate void DraggableEvent(Event e, DraggableUIObject ui);

	[JsDelegate(NativeDelegates = true)]
	[JsType(JsMode.Json, OmitCasts = true, Export = false)]
	public delegate void DroppableEvent(Event e, DroppableUIObject ui);

	[JsType(JsMode.Json)]
	public partial class DroppableUIObject
	{
		public jQuery draggable;
		public jQuery helper;
		public TopLeft position;
		public TopLeft offset;
	}

	[JsType(JsMode.Json)]
	public partial class DraggableUIObject
	{
		public jQuery helper;
		public TopLeft position;
		public TopLeft offset;
	}

}



/// <summary>
/// SharpKit interface for jQuery UI.
/// jQuery UI provides abstractions for low-level interaction and animation, advanced effects and high-level, themeable widgets, built on top of the jQuery JavaScript Library, that you can use to build highly interactive web applications.
/// </summary>
class AssemblyDoc : SharpKit.jQuery.jQueryContext
{
}