// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.handler
{
    /// <summary>
	/// <para>This class provides a handler for the online event.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.handler.Offline", OmitOptionalParameters = true, Export = false)]
    public partial class Offline : qx.core.Object, qx.eventx.IEventHandler
    {
		#region Methods

		public Offline() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a new instance</para>
		/// </summary>
		/// <param name="manager">Event manager for the window to use</param>
		public Offline(qx.eventx.Manager manager) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the event handler can handle events of the given type. If the
		/// event handler class has a static variable called IGNORE_CAN_HANDLE
		/// with the value true this function is not called. Whether the
		/// handler can handle the event is them only determined by the static variables
		/// SUPPORTED_TYPES and TARGET_CHECK.</para>
		/// </summary>
		/// <param name="target">The target to, which the event handler should be attached</param>
		/// <param name="type">event type</param>
		/// <returns>Whether the event handler can handle events of the given type.</returns>
		[JsMethod(Name = "canHandleEvent")]
		public bool CanHandleEvent(object target, string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the current window thinks its online or not.</para>
		/// </summary>
		/// <returns>true if its online</returns>
		[JsMethod(Name = "isOnline")]
		public bool IsOnline() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called each time an event listener, for one of the
		/// supported events, is added using <see cref="qx.event.Manager.AddListener"/>.</para>
		/// </summary>
		/// <param name="target">The target to, which the event handler should be attached</param>
		/// <param name="type">event type</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event.</param>
		[JsMethod(Name = "registerEvent")]
		public void RegisterEvent(object target, string type, bool capture) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called each time an event listener, for one of the
		/// supported events, is removed by using <see cref="qx.event.Manager.RemoveListener"/>
		/// and no other event listener is listening on this type.</para>
		/// </summary>
		/// <param name="target">The target from, which the event handler should be removed</param>
		/// <param name="type">event type</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event.</param>
		[JsMethod(Name = "unregisterEvent")]
		public void UnregisterEvent(object target, string type, bool capture) { throw new NotImplementedException(); }

		#endregion Methods
    }
}