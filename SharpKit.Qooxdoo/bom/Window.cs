// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Includes library functions to work with browser windows</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Window", OmitOptionalParameters = true, Export = false)]
    public partial class Window 
    {
		#region Methods

		public Window() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Closes the given window</para>
		/// </summary>
		/// <param name="win">Native window object</param>
		/// <returns>The return value (if any) of the window&#8217;s native close method</returns>
		[JsMethod(Name = "close")]
		public static object Close(Window win) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>If a modal window is opened with the option</para>
		/// <code>
		/// useNativeModalWindow = false;
		/// </code>
		/// <para>an instance of qx.bom.Blocker is used to fake modality. This method
		/// can be used to get a reference to the blocker to style it.</para>
		/// </summary>
		/// <returns>Blocker instance or null if no blocker is used</returns>
		[JsMethod(Name = "getBlocker")]
		public static qx.bom.Blocker GetBlocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if the window is closed</para>
		/// </summary>
		/// <param name="win">Native window object</param>
		/// <returns>Closed state</returns>
		[JsMethod(Name = "isClosed")]
		public static bool IsClosed(Window win) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Moving an opened window is not allowed in the most browsers anymore.</para>
		/// </summary>
		/// <param name="win">Native window object</param>
		/// <param name="top">Y-coordinate</param>
		/// <param name="left">X-coordinate</param>
		[JsMethod(Name = "moveTo")]
		public static void MoveTo(Window win, double top, double left) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Opens a native window with the given options.</para>
		/// <para>Modal windows can have the following options:</para>
		/// <list type="bullet">
		/// <item>top</item>
		/// </list
		/// <list type="bullet">
		/// <item>left</item>
		/// </list
		/// <list type="bullet">
		/// <item>width</item>
		/// </list
		/// <list type="bullet">
		/// <item>height</item>
		/// </list
		/// <list type="bullet">
		/// <item>scrollbars</item>
		/// </list
		/// <list type="bullet">
		/// <item>resizable</item>
		/// </list
		/// <para>Modeless windows have the following options:</para>
		/// <list type="bullet">
		/// <item>top</item>
		/// </list
		/// <list type="bullet">
		/// <item>left</item>
		/// </list
		/// <list type="bullet">
		/// <item>width</item>
		/// </list
		/// <list type="bullet">
		/// <item>height</item>
		/// </list
		/// <list type="bullet">
		/// <item>dependent</item>
		/// </list
		/// <list type="bullet">
		/// <item>resizable</item>
		/// </list
		/// <list type="bullet">
		/// <item>status</item>
		/// </list
		/// <list type="bullet">
		/// <item>location</item>
		/// </list
		/// <list type="bullet">
		/// <item>menubar</item>
		/// </list
		/// <list type="bullet">
		/// <item>scrollbars</item>
		/// </list
		/// <list type="bullet">
		/// <item>toolbar</item>
		/// </list
		/// <para>Except of dimension and location options all other options are boolean
		/// values.</para>
		/// <para>Important infos for native modal windows</para>
		/// <para>If you want to reference the opened window from within the native modal
		/// window you need to use</para>
		/// <code>
		/// var opener = window.dialogArguments[0];
		/// </code>
		/// <para>since a reference to the opener is passed automatically to the modal window.</para>
		/// <para>Passing window arguments</para>
		/// <para>This is only working if the page of the modal window is from the same origin.
		/// This is at least true for Firefox browsers.</para>
		/// </summary>
		/// <param name="url">URL of the window</param>
		/// <param name="name">Name of the window</param>
		/// <param name="options">Window options</param>
		/// <param name="modal">Whether the window should be opened modal</param>
		/// <param name="useNativeModalDialog">controls if modal windows are opened using the native method or a blocker should be used to fake modality. Default is true</param>
		/// <param name="listener">listener function for onload event on the new window</param>
		/// <param name="self">Reference to the &#8216;this&#8217; variable inside the event listener. When not given, &#8216;this&#8217; variable will be the new window</param>
		/// <returns>native window object</returns>
		[JsMethod(Name = "open")]
		public static Window Open(string url, string name, object options, bool modal, bool useNativeModalDialog, Action<object> listener, object self) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resizing an opened window is not allowed in the most browsers anymore.</para>
		/// </summary>
		/// <param name="win">Native window object</param>
		/// <param name="width">New width</param>
		/// <param name="height">New height</param>
		[JsMethod(Name = "resizeTo")]
		public static void ResizeTo(Window win, double width, double height) { throw new NotImplementedException(); }

		#endregion Methods
    }
}