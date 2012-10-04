//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.field
{
    #region Number
    /// <inheritdocs />
    /// <summary>
    /// <p>A numeric text field that provides automatic keystroke filtering to disallow non-numeric characters,
    /// and numeric validation to limit the value to a range of valid numbers. The range of acceptable number
    /// values can be controlled by setting the <see cref="Ext.form.field.NumberConfig.minValue">minValue</see> and <see cref="Ext.form.field.NumberConfig.maxValue">maxValue</see> configs, and fractional
    /// decimals can be disallowed by setting <see cref="Ext.form.field.NumberConfig.allowDecimals">allowDecimals</see> to <c>false</c>.</p>
    /// <p>By default, the number field is also rendered with a set of up/down spinner buttons and has
    /// up/down arrow key and mouse wheel event listeners attached for incrementing/decrementing the value by the
    /// <see cref="Ext.form.field.NumberConfig.step">step</see> value. To hide the spinner buttons set <c><see cref="Ext.form.field.NumberConfig.hideTrigger">hideTrigger</see>:true</c>; to disable
    /// the arrow key and mouse wheel handlers set <c><see cref="Ext.form.field.NumberConfig.keyNavEnabled">keyNavEnabled</see>:false</c> and
    /// <c><see cref="Ext.form.field.NumberConfig.mouseWheelEnabled">mouseWheelEnabled</see>:false</c>. See the example below.</p>
    /// <h1>Example usage</h1>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// title: 'On The Wall',
    /// width: 300,
    /// bodyPadding: 10,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items: [{
    /// xtype: 'numberfield',
    /// anchor: '100%',
    /// name: 'bottles',
    /// fieldLabel: 'Bottles of Beer',
    /// value: 99,
    /// maxValue: 99,
    /// minValue: 0
    /// }],
    /// buttons: [{
    /// text: 'Take one down, pass it around',
    /// handler: function() {
    /// this.up('form').down('[name=bottles]').spinDown();
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// <h1>Removing UI Enhancements</h1>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// title: 'Personal Info',
    /// width: 300,
    /// bodyPadding: 10,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items: [{
    /// xtype: 'numberfield',
    /// anchor: '100%',
    /// name: 'age',
    /// fieldLabel: 'Age',
    /// minValue: 0, //prevents negative numbers
    /// // Remove spinner buttons, and arrow key and mouse wheel listeners
    /// hideTrigger: true,
    /// keyNavEnabled: false,
    /// mouseWheelEnabled: false
    /// }]
    /// });
    /// </code></pre>
    /// <h1>Using Step</h1>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// title: 'Step',
    /// width: 300,
    /// bodyPadding: 10,
    /// items: [{
    /// xtype: 'numberfield',
    /// anchor: '100%',
    /// name: 'evens',
    /// fieldLabel: 'Even Numbers',
    /// // Set step so it skips every other number
    /// step: 2,
    /// value: 0,
    /// // Add change handler to force user-entered numbers to evens
    /// listeners: {
    /// change: function(field, value) {
    /// value = parseInt(value, 10);
    /// field.setValue(value + value % 2);
    /// }
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Number : Spinner
    {
        /// <summary>
        /// False to disallow decimal values
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowDecimals;
        /// <summary>
        /// True to automatically strip not allowed characters from the field.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool autoStripChars;
        /// <summary>
        /// The base set of characters to evaluate as valid numbers.
        /// Defaults to: <c>&quot;0123456789&quot;</c>
        /// </summary>
        public JsString baseChars;
        /// <summary>
        /// The maximum precision to display after the decimal separator
        /// Defaults to: <c>2</c>
        /// </summary>
        public JsNumber decimalPrecision;
        /// <summary>
        /// Character(s) to allow as the decimal separator
        /// Defaults to: <c>&quot;.&quot;</c>
        /// </summary>
        public JsString decimalSeparator;
        /// <summary>
        /// Error text to display if the maximum value validation fails.
        /// Defaults to: <c>&quot;The maximum value for this field is {0}&quot;</c>
        /// </summary>
        public JsString maxText;
        /// <summary>
        /// The maximum allowed value. Will be used by the field's validation logic, and for
        /// enabling/disabling the up spinner button.
        /// Defaults to Number.MAX_VALUE.
        /// </summary>
        public JsNumber maxValue;
        /// <summary>
        /// Error text to display if the minimum value validation fails.
        /// Defaults to: <c>&quot;The minimum value for this field is {0}&quot;</c>
        /// </summary>
        public JsString minText;
        /// <summary>
        /// The minimum allowed value. Will be used by the field's validation logic,
        /// and for enabling/disabling the down spinner button.
        /// Defaults to Number.NEGATIVE_INFINITY.
        /// </summary>
        public JsNumber minValue;
        /// <summary>
        /// Error text to display if the value is not a valid number. For example, this can happen if a valid character like
        /// '.' or '-' is left in the field with no number.
        /// Defaults to: <c>&quot;{0} is not a valid number&quot;</c>
        /// </summary>
        public JsString nanText;
        /// <summary>
        /// Error text to display if the value is negative and minValue is set to 0. This is used instead of the
        /// minText in that circumstance only.
        /// Defaults to: <c>&quot;The value cannot be negative&quot;</c>
        /// </summary>
        public JsString negativeText;
        /// <summary>
        /// Specifies a numeric interval by which the field's value will be incremented or decremented when the user invokes
        /// the spinner.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber step;
        /// <summary>
        /// False to ensure that the getSubmitValue method strips
        /// always uses . as the separator, regardless of the decimalSeparator
        /// configuration.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitLocaleSeparator;
        /// <summary>
        /// Parameters<li><span>value</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="value">
        /// </param>
        private void fixPrecision(object value){}
        /// <summary>
        /// Replaces any existing maxValue with the new value.
        /// </summary>
        /// <param name="value"><p>The maximum value</p>
        /// </param>
        public void setMaxValue(JsNumber value){}
        /// <summary>
        /// Replaces any existing minValue with the new value.
        /// </summary>
        /// <param name="value"><p>The minimum value</p>
        /// </param>
        public void setMinValue(JsNumber value){}
        public Number(Ext.form.field.NumberConfig config){}
        public Number(){}
        public Number(params object[] args){}
    }
    #endregion
    #region NumberConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NumberConfig : SpinnerConfig
    {
        /// <summary>
        /// False to disallow decimal values
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowDecimals;
        /// <summary>
        /// True to automatically strip not allowed characters from the field.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool autoStripChars;
        /// <summary>
        /// The base set of characters to evaluate as valid numbers.
        /// Defaults to: <c>&quot;0123456789&quot;</c>
        /// </summary>
        public JsString baseChars;
        /// <summary>
        /// The maximum precision to display after the decimal separator
        /// Defaults to: <c>2</c>
        /// </summary>
        public JsNumber decimalPrecision;
        /// <summary>
        /// Character(s) to allow as the decimal separator
        /// Defaults to: <c>&quot;.&quot;</c>
        /// </summary>
        public JsString decimalSeparator;
        /// <summary>
        /// Error text to display if the maximum value validation fails.
        /// Defaults to: <c>&quot;The maximum value for this field is {0}&quot;</c>
        /// </summary>
        public JsString maxText;
        /// <summary>
        /// The maximum allowed value. Will be used by the field's validation logic, and for
        /// enabling/disabling the up spinner button.
        /// Defaults to Number.MAX_VALUE.
        /// </summary>
        public JsNumber maxValue;
        /// <summary>
        /// Error text to display if the minimum value validation fails.
        /// Defaults to: <c>&quot;The minimum value for this field is {0}&quot;</c>
        /// </summary>
        public JsString minText;
        /// <summary>
        /// The minimum allowed value. Will be used by the field's validation logic,
        /// and for enabling/disabling the down spinner button.
        /// Defaults to Number.NEGATIVE_INFINITY.
        /// </summary>
        public JsNumber minValue;
        /// <summary>
        /// Error text to display if the value is not a valid number. For example, this can happen if a valid character like
        /// '.' or '-' is left in the field with no number.
        /// Defaults to: <c>&quot;{0} is not a valid number&quot;</c>
        /// </summary>
        public JsString nanText;
        /// <summary>
        /// Error text to display if the value is negative and minValue is set to 0. This is used instead of the
        /// minText in that circumstance only.
        /// Defaults to: <c>&quot;The value cannot be negative&quot;</c>
        /// </summary>
        public JsString negativeText;
        /// <summary>
        /// Specifies a numeric interval by which the field's value will be incremented or decremented when the user invokes
        /// the spinner.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber step;
        /// <summary>
        /// False to ensure that the getSubmitValue method strips
        /// always uses . as the separator, regardless of the decimalSeparator
        /// configuration.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool submitLocaleSeparator;
        public NumberConfig(params object[] args){}
    }
    #endregion
    #region NumberEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NumberEvents : SpinnerEvents
    {
        public NumberEvents(params object[] args){}
    }
    #endregion
}