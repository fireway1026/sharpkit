// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.handler
{
    /// <summary>
	/// <para>This handler provides an &#8220;change&#8221; event for all form fields and an
	/// &#8220;input&#8221; event for form fields of type &#8220;text&#8221; and &#8220;textarea&#8221;.</para>
	/// <para>To let these events work it is needed to create the elements using
	/// <see cref="qx.bom.Input"/></para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.handler.Input", OmitOptionalParameters = true, Export = false)]
    public partial class Input : qx.core.Object, qx.eventx.IEventHandler
    {
		#region Methods

		public Input() { throw new NotImplementedException(); }

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