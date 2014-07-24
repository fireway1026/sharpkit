// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.fx.effect.core
{
    /// <summary>
	/// <para>A &#8220;empty&#8221; effect based on Base which executes the given function to
	/// performe animation.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.fx.effect.core.Custom", OmitOptionalParameters = true, Export = false)]
    public partial class Custom : qx.fx.Base
    {
		#region Methods

		public Custom() { throw new NotImplementedException(); }

		/// <param name="element">The DOM element</param>
		/// <param name="func">Function to be execute when update() is called.</param>
		public Custom(object element, Action<object> func) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This internal function is called
		/// each time the effect performs an
		/// step of the animation.</para>
		/// <para>Sub classes will overwrite this to
		/// perform the actual changes on element
		/// properties.</para>
		/// </summary>
		/// <param name="position">Animation setup as Number between 0 and 1.</param>
		[JsMethod(Name = "update")]
		public void Update(double position) { throw new NotImplementedException(); }

		#endregion Methods
    }
}