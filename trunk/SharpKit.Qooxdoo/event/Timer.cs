// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>Global timer support.</para>
	/// <para>This class can be used to periodically fire an event. This event can be
	/// used to simulate e.g. a background task. The static method
	/// <see cref="Once"/> is a special case. It will call a function deferred after a
	/// given timeout.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.Timer", OmitOptionalParameters = true, Export = false)]
    public partial class Timer : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>This event if fired each time the interval time has elapsed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> IntervalEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>With the enabled property the Timer can be started and suspended.
		/// Setting it to &#8220;true&#8221; is equivalent to <see cref="Start"/>, setting it
		/// to &#8220;false&#8221; is equivalent to <see cref="Stop"/>.</para>
		/// </summary>
		[JsProperty(Name = "enabled", NativeField = true)]
		public bool Enabled { get; set; }

		/// <summary>
		/// <para>Time in milliseconds between two callback calls.
		/// This property can be set to modify the interval of
		/// a running timer.</para>
		/// </summary>
		[JsProperty(Name = "interval", NativeField = true)]
		public double Interval { get; set; }

		#endregion Properties

		#region Methods

		public Timer() { throw new NotImplementedException(); }

		/// <param name="interval">initial interval in milliseconds of the timer.</param>
		public Timer(double interval) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Start a function after a given timeout.</para>
		/// </summary>
		/// <param name="func">Function to call</param>
		/// <param name="obj">context (this), the function is called with</param>
		/// <param name="timeout">Number of milliseconds to wait before the function is called.</param>
		/// <returns>The timer object used for the timeout. This object can be used to cancel the timeout. Note that the timer is only valid until the timer has been executed.</returns>
		[JsMethod(Name = "once")]
		public static qx.eventx.Timer Once(Action<object> func, object obj, double timeout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property enabled.</para>
		/// </summary>
		[JsMethod(Name = "getEnabled")]
		public bool GetEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property interval.</para>
		/// </summary>
		[JsMethod(Name = "getInterval")]
		public double GetInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property enabled
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property enabled.</param>
		[JsMethod(Name = "initEnabled")]
		public void InitEnabled(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property interval
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property interval.</param>
		[JsMethod(Name = "initInterval")]
		public void InitInterval(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property enabled equals true.</para>
		/// </summary>
		[JsMethod(Name = "isEnabled")]
		public void IsEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property enabled.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEnabled")]
		public void ResetEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property interval.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInterval")]
		public void ResetInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Restart the timer.
		/// This makes it possible to change the interval of a running timer.</para>
		/// </summary>
		[JsMethod(Name = "restart")]
		public void Restart() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Restart the timer. with a given interval.</para>
		/// </summary>
		/// <param name="interval">Time in milliseconds between two callback calls.</param>
		[JsMethod(Name = "restartWith")]
		public void RestartWith(double interval) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property enabled.</para>
		/// </summary>
		/// <param name="value">New value for property enabled.</param>
		[JsMethod(Name = "setEnabled")]
		public void SetEnabled(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property interval.</para>
		/// </summary>
		/// <param name="value">New value for property interval.</param>
		[JsMethod(Name = "setInterval")]
		public void SetInterval(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Start the timer</para>
		/// </summary>
		[JsMethod(Name = "start")]
		public void Start() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Start the timer with a given interval</para>
		/// </summary>
		/// <param name="interval">Time in milliseconds between two callback calls.</param>
		[JsMethod(Name = "startWith")]
		public void StartWith(double interval) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stop the timer.</para>
		/// </summary>
		[JsMethod(Name = "stop")]
		public void Stop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property enabled.</para>
		/// </summary>
		[JsMethod(Name = "toggleEnabled")]
		public void ToggleEnabled() { throw new NotImplementedException(); }

		#endregion Methods
    }
}