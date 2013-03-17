// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io
{
    /// <summary>
	/// <para>The part loader knows about all generated packages and parts.</para>
	/// <para>It contains functionality to load parts and to retrieve part instances.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.PartLoader", OmitOptionalParameters = true, Export = false)]
    public partial class PartLoader : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired if a parts was loaded. The data of the event instance point to the
		/// loaded part instance.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> PartLoadedEvent;

		/// <summary>
		/// <para>Fired if a part could not be loaded. The event&#8217;s
		/// <see cref="qx.event.type.Data.GetData"/> method returns the name of the failed
		/// part.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> PartLoadingErrorEvent;

		#endregion Events

		#region Methods

		public PartLoader() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.io.PartLoader GetInstance() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Loads one or more parts asynchronously. The callback is called after all
		/// parts and their dependencies are fully loaded. If the parts are already
		/// loaded the callback is called immediately.</para>
		/// </summary>
		/// <param name="partNames">List of parts names to load as defined in the config file at compile time.</param>
		/// <param name="callback">Function to execute on completion. The function has one parameter which is an array of ready states of the parts specified in the partNames argument.</param>
		/// <param name="self">Context to execute the given function in</param>
		[JsMethod(Name = "require")]
		public static void RequireS(string partNames, Action<object> callback, object self = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the part instance of the part with the given name.</para>
		/// </summary>
		/// <param name="name">Name of the part as defined in the config file at compile time.</param>
		/// <returns>The corresponding part instance</returns>
		[JsMethod(Name = "getPart")]
		public qx.io.part.Part GetPart(string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a map of all known parts.</para>
		/// </summary>
		/// <returns>Map containing all parts.</returns>
		[JsMethod(Name = "getParts")]
		public object GetParts() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if a part with the given name is available.</para>
		/// </summary>
		/// <param name="name">Name of the part as defined in the config file at compile time.</param>
		/// <returns>true, if the part is available</returns>
		[JsMethod(Name = "hasPart")]
		public bool HasPart(string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Loads one or more parts asynchronously. The callback is called after all
		/// parts and their dependencies are fully loaded. If the parts are already
		/// loaded the callback is called immediately.</para>
		/// </summary>
		/// <param name="partNames">List of parts names to load as defined in the config file at compile time. The method also accepts a single string as parameter to only load one part.</param>
		/// <param name="callback">Function to execute on completion</param>
		/// <param name="self">Context to execute the given function in</param>
		[JsMethod(Name = "require")]
		public void Require(object partNames, Action<object> callback, object self = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}