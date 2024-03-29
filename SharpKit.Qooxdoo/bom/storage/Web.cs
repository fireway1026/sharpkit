// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.storage
{
    /// <summary>
	/// <para>Storage implementation using HTML web storage:
	/// http://www.w3.org/TR/webstorage/</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.storage.Web", OmitOptionalParameters = true, Export = false)]
    public partial class Web 
    {
		#region Methods

		public Web() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Static accessor for the local storage.</para>
		/// </summary>
		/// <returns>An instance of a local storage.</returns>
		[JsMethod(Name = "getLocal")]
		public static qx.bom.storage.Web GetLocal() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Static accessor for the session storage.</para>
		/// </summary>
		/// <returns>An instance of a session storage.</returns>
		[JsMethod(Name = "getSession")]
		public static qx.bom.storage.Web GetSession() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a new instance. Usually, you should take the static
		/// accessors to get your instance.</para>
		/// </summary>
		/// <param name="type">type of storage, either local or session.</param>
		public Web(string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Deletes every stored item in the storage.</para>
		/// </summary>
		[JsMethod(Name = "clear")]
		public void Clear() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper to access every stored item.</para>
		/// </summary>
		/// <param name="callback">A function which will be called for every item. The function will have two arguments, first the key and second the value of the stored data.</param>
		/// <param name="scope">The scope of the function.</param>
		[JsMethod(Name = "forEach")]
		public void ForEach(Action<object> callback, object scope) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the stored item.</para>
		/// </summary>
		/// <param name="key">The identifier to get the data.</param>
		/// <returns>The stored data.</returns>
		[JsMethod(Name = "getItem")]
		public object GetItem(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the named key at the given index.</para>
		/// </summary>
		/// <param name="index">The index in the storage.</param>
		/// <returns>The key stored at the given index.</returns>
		[JsMethod(Name = "getKey")]
		public string GetKey(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the amount of key-value pairs stored.</para>
		/// </summary>
		/// <returns>The length of the storage.</returns>
		[JsMethod(Name = "getLength")]
		public double GetLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes an item form the storage.</para>
		/// </summary>
		/// <param name="key">The identifier.</param>
		[JsMethod(Name = "removeItem")]
		public void RemoveItem(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Store an item in the storage.</para>
		/// </summary>
		/// <param name="key">The identifier key.</param>
		/// <param name="value">The data, which will be stored as JSON.</param>
		[JsMethod(Name = "setItem")]
		public void SetItem(string key, object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}