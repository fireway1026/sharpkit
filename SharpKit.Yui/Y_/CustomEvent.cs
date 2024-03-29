//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// The CustomEvent class lets you define events for your application
    /// that can be subscribed to by one or more independent component.
    /// </summary>
    public partial class CustomEvent
    {
        /// <summary>
        /// Notify a single subscriber
        /// </summary>
        protected void _notify(Subscriber s, Y_.Array args){}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn){return null;}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn, Y_.Array args){return null;}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn, Y_.Array args, object when){return null;}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn, object when){return null;}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn, object context, Y_.Array args){return null;}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn, object context, Y_.Array args, object when){return null;}
        /// <summary>
        /// Create the Subscription for subscribing function, context, and bound
        /// arguments.  If this is a fireOnce event, the subscriber is immediately
        /// notified.
        /// </summary>
        protected EventHandle _on(JsAction fn, object context, object when){return null;}
        /// <summary>
        /// Listen for this event after the normal subscribers have been notified and
        /// the default behavior has been applied.  If a normal subscriber prevents the
        /// default behavior, it also prevents after listeners from firing.
        /// </summary>
        public EventHandle after(JsAction fn, object context, object arg){return null;}
        /// <summary>
        /// Apply configuration properties.  Only applies the CONFIG whitelist
        /// </summary>
        public void applyConfig(object o, object force){}
        /// <summary>
        /// Detach listeners.
        /// </summary>
        public object detach(JsAction fn, object context){return null;}
        /// <summary>
        /// Removes all listeners
        /// </summary>
        public object detachAll(){return null;}
        /// <summary>
        /// Notifies the subscribers.  The callback functions will be executed
        /// from the context specified when the event was created, and with the
        /// following parameters:
        /// <ul>
        /// <li>The type of event</li>
        /// <li>All of the arguments fire() was executed with as an array</li>
        /// <li>The custom object (if any) that was passed into the subscribe()
        /// method</li>
        /// </ul>
        /// </summary>
        public object fire(object arguments){return null;}
        /// <summary>
        /// Set up for notifying subscribers of non-emitFacade events.
        /// </summary>
        protected object fireSimple(Y_.Array args){return null;}
        /// <summary>
        /// Get all of the subscribers to this event and any sibling event
        /// </summary>
        public Y_.Array getSubs(){return null;}
        /// <summary>
        /// Stops the event propagation and prevents the default
        /// event behavior.
        /// </summary>
        public void halt(object immediate){}
        /// <summary>
        /// Returns the number of subscribers for this event as the sum of the on()
        /// subscribers and after() subscribers.
        /// </summary>
        public Y_.DataType_.Number hasSubs(){return null;}
        /// <summary>
        /// Logger abstraction to centralize the application of the silent flag
        /// </summary>
        public void log(object msg, object cat){}
        /// <summary>
        /// Monitor the event state for the subscribed event.  The first parameter
        /// is what should be monitored, the rest are the normal parameters when
        /// subscribing to an event.
        /// </summary>
        public EventHandle monitor(object what){return null;}
        /// <summary>
        /// Listen for this event
        /// </summary>
        public EventHandle on(JsAction fn, object context, object arg){return null;}
        /// <summary>
        /// Prevents the execution of this event's defaultFn
        /// </summary>
        public void preventDefault(){}
        /// <summary>
        /// Stops propagation to bubble targets, and prevents any remaining
        /// subscribers on the current target from executing.
        /// </summary>
        public void stopImmediatePropagation(){}
        /// <summary>
        /// Stop propagation to bubble targets
        /// </summary>
        public void stopPropagation(){}
        /// <summary>
        /// Listen for this event
        /// </summary>
        public EventHandle subscribe(JsAction fn){return null;}
        /// <summary>
        /// Detach listeners.
        /// </summary>
        public object unsubscribe(JsAction fn, object context){return null;}
        /// <summary>
        /// Removes all listeners
        /// </summary>
        public object unsubscribeAll(){return null;}
        /// <summary>
        /// If 0, this event does not broadcast.  If 1, the YUI instance is notified
        /// every time this event fires.  If 2, the YUI instance and the YUI global
        /// (if event is enabled on the global) are notified every time this event
        /// fires.
        /// </summary>
        public int broadcast{get;set;}
        /// <summary>
        /// The context the the event will fire from by default.  Defaults to the YUI
        /// instance.
        /// </summary>
        public object context{get;set;}
        /// <summary>
        /// The default function to execute after event listeners
        /// have fire, but only if the default action was not
        /// prevented.
        /// </summary>
        public JsAction defaultFn{get;set;}
        /// <summary>
        /// An array containing the arguments the custom event
        /// was last fired with.
        /// </summary>
        public Y_.Array firedWith{get;set;}
        /// <summary>
        /// Specifies the host for this custom event.  This is used
        /// to enable event bubbling
        /// </summary>
        public Y_.EventTarget host{get;set;}
        /// <summary>
        /// Flag for preventDefault that is modified during fire().
        /// if it is not 0, the default behavior for this event
        /// </summary>
        public int prevented{get;set;}
        /// <summary>
        /// The function to execute if a subscriber calls
        /// preventDefault
        /// </summary>
        public JsAction preventedFn{get;set;}
        /// <summary>
        /// Supports multiple options for listener signatures in order to
        /// port YUI 2 apps.
        /// </summary>
        public int signature{get;set;}
        /// <summary>
        /// Flag for stopPropagation that is modified during fire()
        /// 1 means to stop propagation to bubble targets.  2 means
        /// to also stop additional subscribers on this target.
        /// </summary>
        public int stopped{get;set;}
        /// <summary>
        /// The function to execute if a subscriber calls
        /// stopPropagation or stopImmediatePropagation
        /// </summary>
        public JsAction stoppedFn{get;set;}
        /// <summary>
        /// The type of event, returned to subscribers when the event fires
        /// </summary>
        public string type{get;set;}
    }
}
