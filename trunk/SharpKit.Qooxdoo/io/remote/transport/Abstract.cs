// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io.remote.transport
{
    /// <summary>
	/// <para>Abstract for all transport implementations</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.remote.transport.Abstract", OmitOptionalParameters = true, Export = false)]
    public partial class Abstract : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Event when a request is aborted</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> AbortedEvent;

		/// <summary>
		/// Fired on change of the property <see cref="State"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeStateEvent;

		/// <summary>
		/// <para>Event when a request is completed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> CompletedEvent;

		/// <summary>
		/// <para>Event when a request is configured</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> ConfiguredEvent;

		/// <summary>
		/// <para>Event when a request is created</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> CreatedEvent;

		/// <summary>
		/// <para>Event when a request has failed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> FailedEvent;

		/// <summary>
		/// <para>Event when a request is received</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> ReceivingEvent;

		/// <summary>
		/// <para>Event when a request is send</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> SendingEvent;

		/// <summary>
		/// <para>Event when a request has timed out</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> TimeoutEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Set the request to asynchronous</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "asynchronous", NativeField = true)]
		public bool Asynchronous { get; set; }

		/// <summary>
		/// <para>Set the data to be sent via this request</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "data", NativeField = true)]
		public string Data { get; set; }

		/// <summary>
		/// <para>Request form fields to send.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "formFields", NativeField = true)]
		public object FormFields { get; set; }

		/// <summary>
		/// <para>Determines what type of request to issue</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "method", NativeField = true)]
		public string Method { get; set; }

		/// <summary>
		/// <para>Request parameters to send.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "parameters", NativeField = true)]
		public object Parameters { get; set; }

		/// <summary>
		/// <para>Password to use for HTTP authentication</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "password", NativeField = true)]
		public string Password { get; set; }

		/// <summary>
		/// <para>Request headers</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "requestHeaders", NativeField = true)]
		public object RequestHeaders { get; set; }

		/// <summary>
		/// <para>Response Type</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "responseType", NativeField = true)]
		public string ResponseType { get; set; }

		/// <summary>
		/// <para>The state of the current request</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "created","configured","sending","receiving","completed","aborted","timeout","failed"
		/// </remarks>
		[JsProperty(Name = "state", NativeField = true)]
		public object State { get; set; }

		/// <summary>
		/// <para>Target url to issue the request to</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "url", NativeField = true)]
		public string Url { get; set; }

		/// <summary>
		/// <para>Use Basic HTTP Authentication</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "useBasicHttpAuth", NativeField = true)]
		public bool UseBasicHttpAuth { get; set; }

		/// <summary>
		/// <para>Username to use for HTTP authentication</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "username", NativeField = true)]
		public string Username { get; set; }

		#endregion Properties

		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Force the transport into the aborted state (&#8220;aborted&#8221;).</para>
		/// <para>Listeners of the &#8220;aborted&#8221; signal are notified about the event.</para>
		/// </summary>
		[JsMethod(Name = "abort")]
		public void Abort() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Force the transport into the failed state (&#8220;failed&#8221;).</para>
		/// <para>Listeners of the &#8220;failed&#8221; signal are notified about the event.</para>
		/// </summary>
		[JsMethod(Name = "failed")]
		public void Failed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property asynchronous.</para>
		/// </summary>
		[JsMethod(Name = "getAsynchronous")]
		public bool GetAsynchronous() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property data.</para>
		/// </summary>
		[JsMethod(Name = "getData")]
		public string GetData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the length of the content as fetched thus far.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getFetchedLength")]
		public double GetFetchedLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property formFields.</para>
		/// </summary>
		[JsMethod(Name = "getFormFields")]
		public object GetFormFields() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property method.</para>
		/// </summary>
		[JsMethod(Name = "getMethod")]
		public string GetMethod() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property parameters.</para>
		/// </summary>
		[JsMethod(Name = "getParameters")]
		public object GetParameters() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property password.</para>
		/// </summary>
		[JsMethod(Name = "getPassword")]
		public string GetPassword() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property requestHeaders.</para>
		/// </summary>
		[JsMethod(Name = "getRequestHeaders")]
		public object GetRequestHeaders() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the request header of the request.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <param name="vLabel">Response header name</param>
		/// <returns></returns>
		[JsMethod(Name = "getResponseHeader")]
		public object GetResponseHeader(string vLabel) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Provides an hash of all response headers.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getResponseHeaders")]
		public object GetResponseHeaders() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Provides the response text from the request when available and null otherwise.
		/// By passing true as the &#8220;partial&#8221; parameter of this method, incomplete data will
		/// be made available to the caller.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getResponseText")]
		public string GetResponseText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property responseType.</para>
		/// </summary>
		[JsMethod(Name = "getResponseType")]
		public string GetResponseType() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Provides the XML provided by the response if any and null otherwise.
		/// By passing true as the &#8220;partial&#8221; parameter of this method, incomplete data will
		/// be made available to the caller.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getResponseXml")]
		public object GetResponseXml() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property state.</para>
		/// </summary>
		[JsMethod(Name = "getState")]
		public object GetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current status code of the request if available or -1 if not.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getStatusCode")]
		public double GetStatusCode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Provides the status text for the current request if available and null otherwise.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getStatusText")]
		public string GetStatusText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property url.</para>
		/// </summary>
		[JsMethod(Name = "getUrl")]
		public string GetUrl() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property useBasicHttpAuth.</para>
		/// </summary>
		[JsMethod(Name = "getUseBasicHttpAuth")]
		public bool GetUseBasicHttpAuth() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property username.</para>
		/// </summary>
		[JsMethod(Name = "getUsername")]
		public string GetUsername() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property asynchronous
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property asynchronous.</param>
		[JsMethod(Name = "initAsynchronous")]
		public void InitAsynchronous(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property data
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property data.</param>
		[JsMethod(Name = "initData")]
		public void InitData(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property formFields
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property formFields.</param>
		[JsMethod(Name = "initFormFields")]
		public void InitFormFields(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property method
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property method.</param>
		[JsMethod(Name = "initMethod")]
		public void InitMethod(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property parameters
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property parameters.</param>
		[JsMethod(Name = "initParameters")]
		public void InitParameters(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property password
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property password.</param>
		[JsMethod(Name = "initPassword")]
		public void InitPassword(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property requestHeaders
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property requestHeaders.</param>
		[JsMethod(Name = "initRequestHeaders")]
		public void InitRequestHeaders(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property responseType
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property responseType.</param>
		[JsMethod(Name = "initResponseType")]
		public void InitResponseType(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property state
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property state.</param>
		[JsMethod(Name = "initState")]
		public void InitState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property url
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property url.</param>
		[JsMethod(Name = "initUrl")]
		public void InitUrl(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property useBasicHttpAuth
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property useBasicHttpAuth.</param>
		[JsMethod(Name = "initUseBasicHttpAuth")]
		public void InitUseBasicHttpAuth(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property username
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property username.</param>
		[JsMethod(Name = "initUsername")]
		public void InitUsername(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property asynchronous equals true.</para>
		/// </summary>
		[JsMethod(Name = "isAsynchronous")]
		public void IsAsynchronous() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property useBasicHttpAuth equals true.</para>
		/// </summary>
		[JsMethod(Name = "isUseBasicHttpAuth")]
		public void IsUseBasicHttpAuth() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property asynchronous.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAsynchronous")]
		public void ResetAsynchronous() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property data.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetData")]
		public void ResetData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property formFields.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFormFields")]
		public void ResetFormFields() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property method.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMethod")]
		public void ResetMethod() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property parameters.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetParameters")]
		public void ResetParameters() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property password.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPassword")]
		public void ResetPassword() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property requestHeaders.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequestHeaders")]
		public void ResetRequestHeaders() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property responseType.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetResponseType")]
		public void ResetResponseType() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property state.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetState")]
		public void ResetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property url.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUrl")]
		public void ResetUrl() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property useBasicHttpAuth.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUseBasicHttpAuth")]
		public void ResetUseBasicHttpAuth() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property username.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUsername")]
		public void ResetUsername() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sending a request.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		[JsMethod(Name = "send")]
		public void Send() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property asynchronous.</para>
		/// </summary>
		/// <param name="value">New value for property asynchronous.</param>
		[JsMethod(Name = "setAsynchronous")]
		public void SetAsynchronous(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property data.</para>
		/// </summary>
		/// <param name="value">New value for property data.</param>
		[JsMethod(Name = "setData")]
		public void SetData(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property formFields.</para>
		/// </summary>
		/// <param name="value">New value for property formFields.</param>
		[JsMethod(Name = "setFormFields")]
		public void SetFormFields(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property method.</para>
		/// </summary>
		/// <param name="value">New value for property method.</param>
		[JsMethod(Name = "setMethod")]
		public void SetMethod(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property parameters.</para>
		/// </summary>
		/// <param name="value">New value for property parameters.</param>
		[JsMethod(Name = "setParameters")]
		public void SetParameters(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property password.</para>
		/// </summary>
		/// <param name="value">New value for property password.</param>
		[JsMethod(Name = "setPassword")]
		public void SetPassword(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a request header to this transports qx.io.remote.Request.</para>
		/// <para>This method is virtual and concrete subclasses are supposed to
		/// implement it.</para>
		/// </summary>
		/// <param name="vLabel">Request header name</param>
		/// <param name="vValue">Value for the header</param>
		[JsMethod(Name = "setRequestHeader")]
		public void SetRequestHeader(string vLabel, object vValue) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property requestHeaders.</para>
		/// </summary>
		/// <param name="value">New value for property requestHeaders.</param>
		[JsMethod(Name = "setRequestHeaders")]
		public void SetRequestHeaders(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property responseType.</para>
		/// </summary>
		/// <param name="value">New value for property responseType.</param>
		[JsMethod(Name = "setResponseType")]
		public void SetResponseType(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property state.</para>
		/// </summary>
		/// <param name="value">New value for property state.</param>
		[JsMethod(Name = "setState")]
		public void SetState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property url.</para>
		/// </summary>
		/// <param name="value">New value for property url.</param>
		[JsMethod(Name = "setUrl")]
		public void SetUrl(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property useBasicHttpAuth.</para>
		/// </summary>
		/// <param name="value">New value for property useBasicHttpAuth.</param>
		[JsMethod(Name = "setUseBasicHttpAuth")]
		public void SetUseBasicHttpAuth(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property username.</para>
		/// </summary>
		/// <param name="value">New value for property username.</param>
		[JsMethod(Name = "setUsername")]
		public void SetUsername(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Force the transport into the timeout state (&#8220;timeout&#8221;).</para>
		/// <para>Listeners of the &#8220;timeout&#8221; signal are notified about the event.</para>
		/// </summary>
		[JsMethod(Name = "timeout")]
		public void Timeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property asynchronous.</para>
		/// </summary>
		[JsMethod(Name = "toggleAsynchronous")]
		public void ToggleAsynchronous() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property useBasicHttpAuth.</para>
		/// </summary>
		[JsMethod(Name = "toggleUseBasicHttpAuth")]
		public void ToggleUseBasicHttpAuth() { throw new NotImplementedException(); }

		#endregion Methods
    }
}