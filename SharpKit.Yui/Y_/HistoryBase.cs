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
    /// Provides global state management backed by an object, but with no browser
    /// history integration. For actual browser history integration and back/forward
    /// support, use the history-html5 or history-hash modules.
    /// </summary>
    public partial class HistoryBase
    {
        /// <summary>
        /// Changes the state. This method provides a common implementation shared by
        /// the public methods for changing state.
        /// </summary>
        protected void _change(object src, object state, object options){}
        /// <summary>
        /// Default <code>history:change</code> event handler.
        /// </summary>
        protected void _defChangeFn(EventFacade e){}
        /// <summary>
        /// Fires a dynamic "[key]Change" event.
        /// </summary>
        protected void _fireChangeEvent(object src, object key, object value){}
        /// <summary>
        /// Called by _resolveChanges() when the state has changed. This method takes
        /// care of actually firing the necessary events.
        /// </summary>
        protected void _fireEvents(object src, object changes, object options){}
        /// <summary>
        /// Fires a dynamic "[key]Remove" event.
        /// </summary>
        protected void _fireRemoveEvent(object src, object key, object value){}
        /// <summary>
        /// Initializes this HistoryBase instance. This method is called by the
        /// constructor.
        /// </summary>
        protected void _init(object config){}
        /// <summary>
        /// Resolves the changes (if any) between <i>newState</i> and the current
        /// state and fires appropriate events if things have changed.
        /// </summary>
        protected void _resolveChanges(object src, object newState, object options){}
        /// <summary>
        /// Stores the specified state. Don't call this method directly; go through
        /// _resolveChanges() to ensure that changes are resolved and all events are
        /// fired properly.
        /// </summary>
        protected void _storeState(object src, object newState, object options){}
        /// <summary>
        /// Adds a state entry with new values for the specified keys. By default,
        /// the new state will be merged into the existing state, and new values will
        /// override existing values. Specifying a <code>null</code> or
        /// <code>undefined</code> value will cause that key to be removed from the
        /// new state entry.
        /// </summary>
        public void add(object state, object options){}
        /// <summary>
        /// Adds a state entry with a new value for a single key. By default, the new
        /// value will be merged into the existing state values, and will override an
        /// existing value with the same key if there is one. Specifying a
        /// <code>null</code> or <code>undefined</code> value will cause the key to
        /// be removed from the new state entry.
        /// </summary>
        public void addValue(object key, object value, object options){}
        /// <summary>
        /// Returns the current value of the state parameter specified by <i>key</i>,
        /// or an object hash of key/value pairs for all current state parameters if
        /// no key is specified.
        /// </summary>
        public object get(object key){return null;}
        /// <summary>
        /// Same as <code>add()</code> except that a new browser history entry will
        /// not be created. Instead, the current history entry will be replaced with
        /// the new state.
        /// </summary>
        public void replace(object state, object options){}
        /// <summary>
        /// Same as <code>addValue()</code> except that a new browser history entry
        /// will not be created. Instead, the current history entry will be replaced
        /// with the new state.
        /// </summary>
        public void replaceValue(object key, object value, object options){}
        /// <summary>
        /// Configuration object provided by the user on instantiation, or an
        /// empty object if one wasn't provided.
        /// </summary>
        protected object _config{get;set;}
    }
}
