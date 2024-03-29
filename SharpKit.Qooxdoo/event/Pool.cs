// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>Central instance pool for event objects. All event objects dispatched by the
	/// event loader are pooled using this class.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.Pool", OmitOptionalParameters = true, Export = false)]
    public partial class Pool : qx.util.ObjectPool
    {
		#region Methods

		public Pool() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.eventx.Pool GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}