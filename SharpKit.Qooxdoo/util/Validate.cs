// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util
{
    /// <summary>
	/// <para>This static class contains a set of default validators.
	/// These validators are listed twice
	/// <list type="bullet">
	/// <item>number</item>
	/// <item>email</item>
	/// <item>string</item>
	/// <item>url</item>
	/// <item>color</item>
	/// </list
	/// All these validators don&#8217;t need an input so the listed function just return a
	/// method fitting for the use in the property system.
	/// The methods with the check prefix are the returned methods and can be used in
	/// other contexts without the property system.</para>
	/// <para>There are three more validators
	/// <list type="bullet">
	/// <item>range</item>
	/// <item>inArray</item>
	/// <item>regExp</item>
	/// </list
	/// These methods do need some addition parameters to specify the validator. So
	/// there is no check function which you can use in other contexts because the
	/// check function for the validation is created based on the given parameter.</para>
	/// <para>Example usage for a property</para>
	/// validate: qx.util.Validate.number()
	/// validate: qx.util.Validate.range(0, 100)
	/// <para>Because the methods without the check prefix return a validation method,
	/// the function must be called at the property definition. So don&#8217;t forget the
	/// ending brackets for those methods without parameters!
	/// For the correct usage, take an additional look at the documentation of the
	/// <see cref="qx.core.Property"/> class.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.Validate", OmitOptionalParameters = true, Export = false)]
    public partial class Validate 
    {
		#region Methods

		public Validate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The function checks the incoming value to see if it is a color.
		/// If not, an ValidationError will be thrown. The check itself will be
		/// delegated to the <see cref="qx.util.ColorUtil.StringToRgb"/> method.
		/// If you want to use the color check in a property definition,
		/// use the <see cref="Color"/> method.</para>
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <param name="formItem">The form item to check if used in a qx.ui.form.Form.</param>
		/// <param name="errorMessage">Custom error message.</param>
		[JsMethod(Name = "checkColor")]
		public static void CheckColor(object value, qx.ui.form.IForm formItem, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The function checks the incoming value to see if it is an email address.
		/// If not, an ValidationError will be thrown.
		/// If you want to use the email check in a property definition,
		/// use the <see cref="Email"/> method.</para>
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <param name="formItem">The form item to check if used in a qx.ui.form.Form.</param>
		/// <param name="errorMessage">Custom error message.</param>
		[JsMethod(Name = "checkEmail")]
		public static void CheckEmail(object value, qx.ui.form.IForm formItem, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The function checks the incoming value to see if it is a number.
		/// If not, an ValidationError will be thrown.
		/// If you want to use the number check in a property definition,
		/// use the <see cref="Number"/> method.</para>
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <param name="formItem">The form item to check if used in a qx.ui.form.Form.</param>
		/// <param name="errorMessage">Custom error message.</param>
		[JsMethod(Name = "checkNumber")]
		public static void CheckNumber(object value, qx.ui.form.IForm formItem, string errorMessage = "undefined") { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The function checks the incoming value to see if it is a string.
		/// If not, an ValidationError will be thrown.
		/// If you want to use the string check in a property definition,
		/// use the <see cref="String"/> method.</para>
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <param name="formItem">The form item to check if used in a qx.ui.form.Form.</param>
		/// <param name="errorMessage">Custom error message.</param>
		[JsMethod(Name = "checkString")]
		public static void CheckString(object value, qx.ui.form.IForm formItem, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The function checks the incoming value to see if it is an url.
		/// If not, an ValidationError will be thrown.
		/// If you want to use the url check in a property definition,
		/// use the <see cref="Url"/> method.</para>
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <param name="formItem">The form item to check if used in a qx.ui.form.Form.</param>
		/// <param name="errorMessage">Custom error message.</param>
		[JsMethod(Name = "checkUrl")]
		public static void CheckUrl(object value, qx.ui.form.IForm formItem, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the function that checks for a color.</para>
		/// </summary>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>The #checkColor Function.</returns>
		[JsMethod(Name = "color")]
		public static Action<object> Color(string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the function that checks for an email address.</para>
		/// </summary>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>The #checkEmail Function.</returns>
		[JsMethod(Name = "email")]
		public static Action<object> Email(string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a function that checks if the given value is in the array.
		/// If the value given to the returned function is not in the array, a
		/// ValidationError will be thrown.</para>
		/// </summary>
		/// <param name="array">The array holding the possibilities.</param>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>A function taking one parameter (value).</returns>
		[JsMethod(Name = "inArray")]
		public static Action<object> InArray(JsArray array, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the function that checks for a number.</para>
		/// </summary>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>The #checkNumber Function.</returns>
		[JsMethod(Name = "number")]
		public static Action<object> Number(string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a function that checks if the number is in the given range.
		/// The range includes the border values.
		/// A range from 1 to 2 accepts the values 1 equally as everything up to 2
		/// including the 2.
		/// If the value given to the returned function is out of the range, a
		/// ValidationError will be thrown.</para>
		/// </summary>
		/// <param name="from">The lower border of the range.</param>
		/// <param name="to">The upper border of the range.</param>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>A function taking one parameter (value).</returns>
		[JsMethod(Name = "range")]
		public static Action<object> Range(double from, double to, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a function that checks if the given value fits the RegExp.
		/// For testing, the function uses the RegExp.test function.
		/// If the value given to the returned function does not fit the RegExp, a
		/// ValidationError will be thrown.
		/// incoming</para>
		/// </summary>
		/// <param name="reg">The RegExp for the check.</param>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>A function taking one parameter (value).</returns>
		[JsMethod(Name = "regExp")]
		public static Action<object> RegExp(JsRegExp reg, string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the function that checks for a string.</para>
		/// </summary>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>The #checkString Function.</returns>
		[JsMethod(Name = "string")]
		public static Action<object> String(string errorMessage = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the function that checks for an url.</para>
		/// </summary>
		/// <param name="errorMessage">Custom error message.</param>
		/// <returns>The #checkUrl Function.</returns>
		[JsMethod(Name = "url")]
		public static Action<object> Url(string errorMessage = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}