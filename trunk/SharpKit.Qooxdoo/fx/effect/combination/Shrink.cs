// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.fx.effect.combination
{
    /// <summary>
	/// <para>Combination effect &#8220;Shrink&#8221;</para>
	/// <para>Resizes the element from initial to given dimensions.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.fx.effect.combination.Shrink", OmitOptionalParameters = true, Export = false)]
    public partial class Shrink : qx.fx.Base
    {
		#region Properties

		/// <summary>
		/// <para>Direction in which the element should shrink.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "top-left","top-right","bottom-left","bottom-right","center"
		/// </remarks>
		[JsProperty(Name = "direction", NativeField = true)]
		public object Direction { get; set; }

		/// <summary>
		/// <para>Flag indicating if the CSS attribute &#8220;display&#8221;
		/// should be modified by effect</para>
		/// </summary>
		[JsProperty(Name = "modifyDisplay", NativeField = true)]
		public bool ModifyDisplay { get; set; }

		/// <summary>
		/// <para>Transition function to modify the movement process.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "linear","easeInQuad","easeOutQuad","sinodial","reverse","flicker","wobble","pulse","spring","none","full"
		/// </remarks>
		[JsProperty(Name = "moveTransition", NativeField = true)]
		public object MoveTransition { get; set; }

		/// <summary>
		/// <para>Transition function to modify the scaling process.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "linear","easeInQuad","easeOutQuad","sinodial","reverse","flicker","wobble","pulse","spring","none","full"
		/// </remarks>
		[JsProperty(Name = "scaleTransition", NativeField = true)]
		public object ScaleTransition { get; set; }

		#endregion Properties

		#region Methods

		public Shrink() { throw new NotImplementedException(); }

		/// <param name="element">The DOM element</param>
		public Shrink(object element) { throw new NotImplementedException(); }

		[JsMethod(Name = "afterFinishInternal")]
		public void AfterFinishInternal() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property direction.</para>
		/// </summary>
		[JsMethod(Name = "getDirection")]
		public object GetDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "getModifyDisplay")]
		public bool GetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property moveTransition.</para>
		/// </summary>
		[JsMethod(Name = "getMoveTransition")]
		public object GetMoveTransition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property scaleTransition.</para>
		/// </summary>
		[JsMethod(Name = "getScaleTransition")]
		public object GetScaleTransition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property direction
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property direction.</param>
		[JsMethod(Name = "initDirection")]
		public void InitDirection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property modifyDisplay
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property modifyDisplay.</param>
		[JsMethod(Name = "initModifyDisplay")]
		public void InitModifyDisplay(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property moveTransition
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property moveTransition.</param>
		[JsMethod(Name = "initMoveTransition")]
		public void InitMoveTransition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property scaleTransition
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property scaleTransition.</param>
		[JsMethod(Name = "initScaleTransition")]
		public void InitScaleTransition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property modifyDisplay equals true.</para>
		/// </summary>
		[JsMethod(Name = "isModifyDisplay")]
		public void IsModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property direction.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDirection")]
		public void ResetDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property modifyDisplay.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModifyDisplay")]
		public void ResetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property moveTransition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMoveTransition")]
		public void ResetMoveTransition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property scaleTransition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetScaleTransition")]
		public void ResetScaleTransition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property direction.</para>
		/// </summary>
		/// <param name="value">New value for property direction.</param>
		[JsMethod(Name = "setDirection")]
		public void SetDirection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property modifyDisplay.</para>
		/// </summary>
		/// <param name="value">New value for property modifyDisplay.</param>
		[JsMethod(Name = "setModifyDisplay")]
		public void SetModifyDisplay(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property moveTransition.</para>
		/// </summary>
		/// <param name="value">New value for property moveTransition.</param>
		[JsMethod(Name = "setMoveTransition")]
		public void SetMoveTransition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property scaleTransition.</para>
		/// </summary>
		/// <param name="value">New value for property scaleTransition.</param>
		[JsMethod(Name = "setScaleTransition")]
		public void SetScaleTransition(object value) { throw new NotImplementedException(); }

		[JsMethod(Name = "setup")]
		public void Setup() { throw new NotImplementedException(); }

		[JsMethod(Name = "start")]
		public void Start() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "toggleModifyDisplay")]
		public void ToggleModifyDisplay() { throw new NotImplementedException(); }

		#endregion Methods
    }
}