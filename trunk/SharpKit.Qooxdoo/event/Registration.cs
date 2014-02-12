// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>Wrapper for browser generic event handling.</para>
	/// <para>Supported events differ from target to target. Generally the handlers
	/// in <see cref="qx.event.handler"/> defines the available features.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.Registration", OmitOptionalParameters = true, Export = false)]
    public partial class Registration 
    {
		#region Methods

		public Registration() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Register an event dispatcher.</para>
		/// </summary>
		/// <param name="dispatcher">Event dispatcher to add</param>
		/// <param name="priority">One of qx.event.Registration#PRIORITY_FIRST, qx.event.Registration#PRIORITY_NORMAL or qx.event.Registration#PRIORITY_LAST.</param>
		[JsMethod(Name = "addDispatcher")]
		public static void AddDispatcher(qx.eventx.IEventDispatcher dispatcher, double priority) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Register an event handler.</para>
		/// </summary>
		/// <param name="handler">Event handler to add</param>
		[JsMethod(Name = "addHandler")]
		public static void AddHandler(qx.eventx.IEventHandler handler) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add an event listener to a DOM target. The event listener is passed an
		/// instance of <see cref="qx.event.type.Event"/> containing all relevant information
		/// about the event as parameter.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">Name of the event e.g. &#8220;click&#8221;, &#8220;keydown&#8221;, ...</param>
		/// <param name="listener">Event listener function</param>
		/// <param name="self">Reference to the &#8216;this&#8217; variable inside the event listener. When not given, the corresponding dispatcher usually falls back to a default, which is the target by convention. Note this is not a strict requirement, i.e. custom dispatchers can follow a different strategy.</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event. The default is to attach the event handler to the bubbling phase.</param>
		/// <returns>An opaque id, which can be used to remove the event listener using the #removeListenerById method.</returns>
		[JsMethod(Name = "addListener")]
		public static object AddListener(object target, string type, Action<qx.eventx.type.Data> listener, object self = null, bool? capture = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get an event instance of the given class, which can be dispatched using
		/// an event manager. The created events must be initialized using
		/// <see cref="qx.event.type.Event.Init"/>.</para>
		/// </summary>
		/// <param name="type">The type of the event to create</param>
		/// <param name="clazz">The event class to use</param>
		/// <param name="args">Array which will be passed to the event&#8217;s init method.</param>
		/// <returns>An instance of the given class.</returns>
		[JsMethod(Name = "createEvent")]
		public static qx.eventx.type.Event CreateEvent(string type, object clazz = null, JsArray args = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Dispatch an event object on the given target.</para>
		/// <para>It is normally better to use <see cref="FireEvent"/> because it uses
		/// the event pooling and is quite handy otherwise as well. After dispatching
		/// the event object will be pooled for later reuse or disposed.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="eventx">The event object to dispatch. The event object must be obtained using #createEvent and initialized using qx.event.type.Event#init.</param>
		/// <returns>whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "dispatchEvent")]
		public static bool DispatchEvent(object target, qx.eventx.type.Event eventx) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create an event object and dispatch it on the given target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">Event type to fire</param>
		/// <param name="clazz">The event class</param>
		/// <param name="args">Arguments, which will be passed to the event&#8217;s init method.</param>
		/// <returns>whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "fireEvent")]
		public static bool FireEvent(object target, string type, Class clazz = null, JsArray args = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create an event object and dispatch it on the given target.
		/// The event dispatched with this method does never bubble! Use only if you
		/// are sure that bubbling is not required.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">Event type to fire</param>
		/// <param name="clazz">The event class</param>
		/// <param name="args">Arguments, which will be passed to the event&#8217;s init method.</param>
		/// <returns>whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "fireNonBubblingEvent")]
		public static bool FireNonBubblingEvent(object target, string type, Class clazz = null, JsArray args = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of registered event dispatchers.</para>
		/// </summary>
		/// <returns>all registered event dispatcher</returns>
		[JsMethod(Name = "getDispatchers")]
		public static qx.eventx.IEventDispatcher GetDispatchers() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of registered event handlers.</para>
		/// </summary>
		/// <returns>registered event handlers</returns>
		[JsMethod(Name = "getHandlers")]
		public static qx.eventx.IEventHandler GetHandlers() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get an instance of the event manager, which can handle events for the
		/// given target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <returns>The event manger for the target.</returns>
		[JsMethod(Name = "getManager")]
		public static qx.eventx.Manager GetManager(object target) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether there are one or more listeners for an event type
		/// registered at the target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <param name="type">The event type</param>
		/// <param name="capture">Whether to check for listeners of the bubbling or of the capturing phase.</param>
		/// <returns>Whether the target has event listeners of the given type.</returns>
		[JsMethod(Name = "hasListener")]
		public static bool HasListener(object target, string type, bool capture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all event listeners, which are attached to the given event target.</para>
		/// </summary>
		/// <param name="target">The event target to remove all event listeners from.</param>
		/// <returns>Whether the events were existend and were removed successfully.</returns>
		[JsMethod(Name = "removeAllListeners")]
		public static bool RemoveAllListeners(object target) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an event listener from an event target.</para>
		/// <para>Note: All registered event listeners will automatically at page unload
		/// so it is not necessary to detach events in the destructor.</para>
		/// </summary>
		/// <param name="target">The event target</param>
		/// <param name="type">Name of the event</param>
		/// <param name="listener">The pointer to the event listener</param>
		/// <param name="self">Reference to the &#8216;this&#8217; variable inside the event listener.</param>
		/// <param name="capture">Whether to remove the event listener of the bubbling or of the capturing phase.</param>
		/// <returns>Whether the event was removed. Return false if the event was already removed before.</returns>
		[JsMethod(Name = "removeListener")]
		public static bool RemoveListener(object target, string type, Action<qx.eventx.type.Data> listener, object self = null, bool? capture = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes an event listener from an event target by an id returned by
		/// <see cref="AddListener"/></para>
		/// </summary>
		/// <param name="target">The event target</param>
		/// <param name="id">The id returned by #addListener</param>
		/// <returns>Whether the event was removed. Return false if the event was already removed before.</returns>
		[JsMethod(Name = "removeListenerById")]
		public static bool RemoveListenerById(object target, object id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a manager for a specific window from the list.</para>
		/// <para>Normally only used when the manager gets disposed through
		/// an unload event of the attached window.</para>
		/// </summary>
		/// <param name="mgr">The manager to remove</param>
		[JsMethod(Name = "removeManager")]
		public static void RemoveManager(qx.eventx.Manager mgr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a serialized array of all events attached on the given target.</para>
		/// </summary>
		/// <param name="target">Any valid event target</param>
		/// <returns>Array of maps where everyone contains the keys: handler, self, type and capture.</returns>
		[JsMethod(Name = "serializeListeners")]
		public static object SerializeListeners(object target) { throw new NotImplementedException(); }

		#endregion Methods
    }
}