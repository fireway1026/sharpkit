//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.action
{
    #region Action
    /// <inheritdocs />
    /// <summary>
    /// <p>The subclasses of this class provide actions to perform upon <see cref="Ext.form.Basic">Form</see>s.</p>
    /// <p>Instances of this class are only created by a <see cref="Ext.form.Basic">Form</see> when the Form needs to perform an action
    /// such as submit or load. The Configuration options listed for this class are set through the Form's action methods:
    /// <see cref="Ext.form.Basic.submit">submit</see>, <see cref="Ext.form.Basic.load">load</see> and <see cref="Ext.form.Basic.doAction">doAction</see></p>
    /// <p>The instance of Action which performed the action is passed to the success and failure callbacks of the Form's action
    /// methods (<see cref="Ext.form.Basic.submit">submit</see>, <see cref="Ext.form.Basic.load">load</see> and
    /// <see cref="Ext.form.Basic.doAction">doAction</see>), and to the <see cref="Ext.form.BasicEvents.actioncomplete">actioncomplete</see> and
    /// <see cref="Ext.form.BasicEvents.actionfailed">actionfailed</see> event handlers.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Action : Ext.Base
    {
        /// <summary>
        /// The function to call when a failure packet was received, or when an error ocurred in the Ajax communication.
        /// </summary>
        public System.Delegate failure;
        /// <summary>
        /// The BasicForm instance that is invoking this Action. Required.
        /// </summary>
        public Basic form;
        /// <summary>
        /// Extra headers to be sent in the AJAX request for submit and load actions.
        /// See Ext.data.proxy.Ajax.headers.
        /// </summary>
        public JsObject headers;
        /// <summary>
        /// The HTTP method to use to access the requested URL.
        /// Defaults to the BasicForm's method, or 'POST' if not specified.
        /// </summary>
        public JsString method;
        /// <summary>
        /// Extra parameter values to pass. These are added to the Form's Ext.form.Basic.baseParams and passed to the
        /// specified URL along with the Form's input fields.
        /// Parameters are encoded as standard HTTP parameters using <see cref="Ext.ExtContext.urlEncode">Ext.Object.toQueryString</see>.
        /// </summary>
        public object @params;
        /// <summary>
        /// When set to true, causes the Form to be reset on Action success. If specified,
        /// this happens before the success callback is called and before the Form's
        /// actioncomplete event fires.
        /// </summary>
        public bool reset;
        /// <summary>
        /// The scope in which to call the configured success and failure callback functions
        /// (the this reference for the callback functions).
        /// </summary>
        public JsObject scope;
        /// <summary>
        /// If set to true, the emptyText value will be sent with the form when it is submitted.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitEmptyText;
        /// <summary>
        /// The function to call when a valid success return packet is received.
        /// </summary>
        public System.Delegate success;
        /// <summary>
        /// The number of seconds to wait for a server response before failing with the failureType as
        /// CONNECT_FAILURE. If not specified, defaults to the configured
        /// timeout of the form.
        /// </summary>
        public JsNumber timeout;
        /// <summary>
        /// The URL that the Action is to invoke. Will default to the url configured on the
        /// form.
        /// </summary>
        public JsString url;
        /// <summary>
        /// The message to be displayed by a call to Ext.window.MessageBox.wait during the time the action is being
        /// processed.
        /// </summary>
        public JsString waitMsg;
        /// <summary>
        /// The title to be displayed by a call to Ext.window.MessageBox.wait during the time the action is being
        /// processed.
        /// </summary>
        public JsString waitTitle;
        /// <summary>
        /// The type of failure detected will be one of these:
        /// CLIENT_INVALID, SERVER_INVALID, CONNECT_FAILURE, or LOAD_FAILURE.
        /// Usage:
        /// <code>var fp = new <see cref="Ext.form.Panel">Ext.form.Panel</see>({
        /// ...
        /// buttons: [{
        /// text: 'Save',
        /// formBind: true,
        /// handler: function(){
        /// if(fp.getForm().isValid()){
        /// fp.getForm().submit({
        /// url: 'form-submit.php',
        /// waitMsg: 'Submitting your data...',
        /// success: function(form, action){
        /// // server responded with success = true
        /// var result = action.<see cref="Ext.form.action.Action.result">result</see>;
        /// },
        /// failure: function(form, action){
        /// if (action.<see cref="Ext.form.action.Action.failureType">failureType</see> === <see cref="Ext.form.action.Action">Ext.form.action.Action</see>.CONNECT_FAILURE) {
        /// <see cref="Ext.MessageBox.alert">Ext.Msg.alert</see>('Error',
        /// 'Status:'+action.<see cref="Ext.form.action.Action.response">response</see>.status+': '+
        /// action.<see cref="Ext.form.action.Action.response">response</see>.statusText);
        /// }
        /// if (action.failureType === <see cref="Ext.form.action.Action">Ext.form.action.Action</see>.SERVER_INVALID){
        /// // server responded with success = false
        /// <see cref="Ext.MessageBox.alert">Ext.Msg.alert</see>('Invalid', action.<see cref="Ext.form.action.Action.result">result</see>.errormsg);
        /// }
        /// }
        /// });
        /// }
        /// }
        /// },{
        /// text: 'Reset',
        /// handler: function(){
        /// fp.getForm().reset();
        /// }
        /// }]
        /// </code>
        /// </summary>
        public JsString failureType{get;set;}
        /// <summary>
        /// The raw XMLHttpRequest object used to perform the action.
        /// </summary>
        public JsObject response{get;set;}
        /// <summary>
        /// The decoded response object containing a boolean success property and other, action-specific properties.
        /// </summary>
        public JsObject result{get;set;}
        /// <summary>
        /// The type of action this Action instance performs. Currently only "submit" and "load" are supported.
        /// </summary>
        public JsString type{get;set;}
        /// <summary>
        /// Creates new Action.
        /// </summary>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Action(object config=null){}
        /// <summary>
        /// Creates a callback object.
        /// </summary>
        private void createCallback(){}
        /// <summary>
        /// Determine the HTTP method to be used for the request.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The HTTP method</p>
        /// </div>
        /// </returns>
        private JsString getMethod(){return null;}
        /// <summary>
        /// Get the set of parameters specified in the BasicForm's baseParams and/or the params option.
        /// Items in params override items of the same name in baseParams.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>the full set of parameters</p>
        /// </div>
        /// </returns>
        private object getParams(){return null;}
        /// <summary>
        /// Build the URL for the AJAX request. Used by the standard AJAX submit and load actions.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The URL.</p>
        /// </div>
        /// </returns>
        private JsString getUrl(){return null;}
        /// <summary>
        /// Handles the raw response and builds a result object from it. Must be implemented by subclasses.
        /// </summary>
        /// <param name="response">
        /// </param>
        private void handleResponse(object response){}
        /// <summary>
        /// Handles a failure response.
        /// </summary>
        /// <param name="response">
        /// </param>
        private void onFailure(object response){}
        /// <summary>
        /// Callback method that gets invoked when the action completes successfully. Must be implemented by subclasses.
        /// </summary>
        /// <param name="response">
        /// </param>
        private void onSuccess(object response){}
        /// <summary>
        /// Validates that a response contains either responseText or responseXML and invokes
        /// handleResponse to build the result object.
        /// </summary>
        /// <param name="response"><p>The raw response object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/<see cref="bool">Boolean</see></span><div><p>The result object as built by handleResponse, or <c>true</c> if
        /// the response had empty responseText and responseXML.</p>
        /// </div>
        /// </returns>
        private object processResponse(object response){return null;}
        /// <summary>
        /// Invokes this action using the current configuration.
        /// </summary>
        public void run(){}
        /// <summary>
        /// Failure type returned when client side validation of the Form fails thus aborting a submit action. Client
        /// side validation is performed unless Ext.form.action.Submit.clientValidation is explicitly set to
        /// false.
        /// Defaults to: <c>&quot;client&quot;</c>
        /// </summary>
        public static JsString CLIENT_INVALID{get;set;}
        /// <summary>
        /// Failure type returned when a communication error happens when attempting to send a request to the remote
        /// server. The response may be examined to provide further information.
        /// Defaults to: <c>&quot;connect&quot;</c>
        /// </summary>
        public static JsString CONNECT_FAILURE{get;set;}
        /// <summary>
        /// Failure type returned when the response's success property is set to false, or no field values are returned
        /// in the response's data property.
        /// Defaults to: <c>&quot;load&quot;</c>
        /// </summary>
        public static JsString LOAD_FAILURE{get;set;}
        /// <summary>
        /// Failure type returned when server side processing fails and the result's success property is set to
        /// false.
        /// In the case of a form submission, field-specific error messages may be returned in the <see cref="Ext.form.action.Action.result">result</see>'s
        /// errors property.
        /// Defaults to: <c>&quot;server&quot;</c>
        /// </summary>
        public static JsString SERVER_INVALID{get;set;}
        public Action(Ext.form.action.ActionConfig config){}
        public Action(params object[] args){}
    }
    #endregion
    #region ActionConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ActionConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The function to call when a failure packet was received, or when an error ocurred in the Ajax communication.
        /// </summary>
        public System.Delegate failure;
        /// <summary>
        /// The BasicForm instance that is invoking this Action. Required.
        /// </summary>
        public Basic form;
        /// <summary>
        /// Extra headers to be sent in the AJAX request for submit and load actions.
        /// See Ext.data.proxy.Ajax.headers.
        /// </summary>
        public JsObject headers;
        /// <summary>
        /// The HTTP method to use to access the requested URL.
        /// Defaults to the BasicForm's method, or 'POST' if not specified.
        /// </summary>
        public JsString method;
        /// <summary>
        /// Extra parameter values to pass. These are added to the Form's Ext.form.Basic.baseParams and passed to the
        /// specified URL along with the Form's input fields.
        /// Parameters are encoded as standard HTTP parameters using <see cref="Ext.ExtContext.urlEncode">Ext.Object.toQueryString</see>.
        /// </summary>
        public object @params;
        /// <summary>
        /// When set to true, causes the Form to be reset on Action success. If specified,
        /// this happens before the success callback is called and before the Form's
        /// actioncomplete event fires.
        /// </summary>
        public bool reset;
        /// <summary>
        /// The scope in which to call the configured success and failure callback functions
        /// (the this reference for the callback functions).
        /// </summary>
        public JsObject scope;
        /// <summary>
        /// If set to true, the emptyText value will be sent with the form when it is submitted.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitEmptyText;
        /// <summary>
        /// The function to call when a valid success return packet is received.
        /// </summary>
        public System.Delegate success;
        /// <summary>
        /// The number of seconds to wait for a server response before failing with the failureType as
        /// CONNECT_FAILURE. If not specified, defaults to the configured
        /// timeout of the form.
        /// </summary>
        public JsNumber timeout;
        /// <summary>
        /// The URL that the Action is to invoke. Will default to the url configured on the
        /// form.
        /// </summary>
        public JsString url;
        /// <summary>
        /// The message to be displayed by a call to Ext.window.MessageBox.wait during the time the action is being
        /// processed.
        /// </summary>
        public JsString waitMsg;
        /// <summary>
        /// The title to be displayed by a call to Ext.window.MessageBox.wait during the time the action is being
        /// processed.
        /// </summary>
        public JsString waitTitle;
        public ActionConfig(params object[] args){}
    }
    #endregion
    #region ActionEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ActionEvents : Ext.BaseEvents
    {
        public ActionEvents(params object[] args){}
    }
    #endregion
}
