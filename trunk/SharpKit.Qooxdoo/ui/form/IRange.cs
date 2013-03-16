// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>Form interface for all widgets which deal with ranges. The spinner is a good
	/// example for a range using widget.</para>
	/// </summary>
	public interface IRange
    {
		#region Methods

		/// <summary>
		/// <para>Return the current set maximum of the range.</para>
		/// </summary>
		/// <returns>The current set maximum.</returns>
		double GetMaximum();

		/// <summary>
		/// <para>Return the current set minimum of the range.</para>
		/// </summary>
		/// <returns>The current set minimum.</returns>
		double GetMinimum();

		/// <summary>
		/// <para>Returns the value which will be stepped in a page step in the range.</para>
		/// </summary>
		/// <returns>The current value for page steps.</returns>
		double GetPageStep();

		/// <summary>
		/// <para>Returns the value which will be stepped in a single step in the range.</para>
		/// </summary>
		/// <returns>The current value for single steps.</returns>
		double GetSingleStep();

		/// <summary>
		/// <para>Set the maximum value of the range.</para>
		/// </summary>
		/// <param name="max">The maximum.</param>
		void SetMaximum(double max);

		/// <summary>
		/// <para>Set the minimum value of the range.</para>
		/// </summary>
		/// <param name="min">The minimum.</param>
		void SetMinimum(double min);

		/// <summary>
		/// <para>Sets the value for page steps in the range.</para>
		/// </summary>
		/// <param name="step">The value of the step.</param>
		void SetPageStep(double step);

		/// <summary>
		/// <para>Sets the value for single steps in the range.</para>
		/// </summary>
		/// <param name="step">The value of the step.</param>
		void SetSingleStep(double step);

		#endregion Methods
    }
}