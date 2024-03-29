//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.field
{
    #region Date
    /// <inheritdocs />
    /// <summary>
    /// <p>Provides a date input field with a <see cref="Ext.picker.Date">date picker</see> dropdown and automatic date
    /// validation.</p>
    /// <p>This field recognizes and uses the JavaScript Date object as its main <see cref="Ext.form.field.DateConfig.value">value</see> type. In addition,
    /// it recognizes string values which are parsed according to the <see cref="Ext.form.field.DateConfig.format">format</see> and/or <see cref="Ext.form.field.DateConfig.altFormats">altFormats</see>
    /// configs. These may be reconfigured to use date formats appropriate for the user's locale.</p>
    /// <p>The field may be limited to a certain range of dates by using the <see cref="Ext.form.field.DateConfig.minValue">minValue</see>, <see cref="Ext.form.field.DateConfig.maxValue">maxValue</see>,
    /// <see cref="Ext.form.field.DateConfig.disabledDays">disabledDays</see>, and <see cref="Ext.form.field.DateConfig.disabledDates">disabledDates</see> config parameters. These configurations will be used both
    /// in the field's validation, and in the date picker dropdown by preventing invalid dates from being selected.</p>
    /// <h1>Example usage</h1>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// width: 300,
    /// bodyPadding: 10,
    /// title: 'Dates',
    /// items: [{
    /// xtype: 'datefield',
    /// anchor: '100%',
    /// fieldLabel: 'From',
    /// name: 'from_date',
    /// maxValue: new Date()  // limited to the current date or prior
    /// }, {
    /// xtype: 'datefield',
    /// anchor: '100%',
    /// fieldLabel: 'To',
    /// name: 'to_date',
    /// value: new Date()  // defaults to today
    /// }]
    /// });
    /// </code></pre>
    /// <h1>Date Formats Examples</h1>
    /// <p>This example shows a couple of different date format parsing scenarios. Both use custom date format
    /// configurations; the first one matches the configured <c>format</c> while the second matches the <c>altFormats</c>.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// width: 300,
    /// bodyPadding: 10,
    /// title: 'Dates',
    /// items: [{
    /// xtype: 'datefield',
    /// anchor: '100%',
    /// fieldLabel: 'Date',
    /// name: 'date',
    /// // The value matches the format; will be parsed and displayed using that format.
    /// format: 'm d Y',
    /// value: '2 4 1978'
    /// }, {
    /// xtype: 'datefield',
    /// anchor: '100%',
    /// fieldLabel: 'Date',
    /// name: 'date',
    /// // The value does not match the format, but does match an altFormat; will be parsed
    /// // using the altFormat and displayed using the format.
    /// format: 'm d Y',
    /// altFormats: 'm,d,Y|m.d.Y',
    /// value: '2.4.1978'
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Date : Picker
    {
        /// <summary>
        /// Multiple date formats separated by "|" to try when parsing a user input value and it does not match the defined
        /// format.
        /// Defaults to: <c>&quot;m/d/Y|n/j/Y|n/j/y|m/j/y|n/d/y|m/j/Y|n/d/Y|m-d-y|m-d-Y|m/d|m-d|md|mdy|mdY|d|Y-m-d|n-j|n/j&quot;</c>
        /// </summary>
        public JsString altFormats;
        /// <summary>
        /// An array of "dates" to disable, as strings. These strings will be used to build a dynamic regular expression so
        /// they are very powerful. Some examples:
        /// <code>// disable these exact dates:
        /// disabledDates: ["03/08/2003", "09/16/2003"]
        /// // disable these days for every year:
        /// disabledDates: ["03/08", "09/16"]
        /// // only match the beginning (useful if you are using short years):
        /// disabledDates: ["^03/08"]
        /// // disable every day in March 2006:
        /// disabledDates: ["03/../2006"]
        /// // disable every day in every March:
        /// disabledDates: ["^03"]
        /// </code>
        /// Note that the format of the dates included in the array should exactly match the <see cref="Ext.form.field.DateConfig.format">format</see> config. In order
        /// to support regular expressions, if you are using a <see cref="Ext.form.field.DateConfig.format">date format</see> that has "." in it, you will have
        /// to escape the dot when restricting dates. For example: <c>["03\\.08\\.03"]</c>.
        /// </summary>
        public JsString disabledDates;
        /// <summary>
        /// The tooltip text to display when the date falls on a disabled date.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDatesText;
        /// <summary>
        /// An array of days to disable, 0 based. Some examples:
        /// <code>// disable Sunday and Saturday:
        /// disabledDays:  [0, 6]
        /// // disable weekdays:
        /// disabledDays: [1,2,3,4,5]
        /// </code>
        /// </summary>
        public JsNumber disabledDays;
        /// <summary>
        /// The tooltip to display when the date falls on a disabled day.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDaysText;
        /// <summary>
        /// The default date format string which can be overriden for localization support. The format must be valid
        /// according to Ext.Date.parse.
        /// Defaults to: <c>&quot;m/d/Y&quot;</c>
        /// </summary>
        public JsString format;
        /// <summary>
        /// The error text to display when the date in the cell is after maxValue.
        /// Defaults to: <c>&quot;The date in this field must be equal to or before {0}&quot;</c>
        /// </summary>
        public JsString maxText;
        /// <summary>
        /// The maximum allowed date. Can be either a Javascript date object or a string date in a valid format.
        /// </summary>
        public object maxValue;
        /// <summary>
        /// The error text to display when the date in the cell is before minValue.
        /// Defaults to: <c>&quot;The date in this field must be equal to or after {0}&quot;</c>
        /// </summary>
        public JsString minText;
        /// <summary>
        /// The minimum allowed date. Can be either a Javascript date object or a string date in a valid format.
        /// </summary>
        public object minValue;
        /// <summary>
        /// false to hide the footer area of the Date picker containing the Today button and disable the keyboard handler for
        /// spacebar that selects the current date.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool showToday;
        /// <summary>
        /// Day index at which the week should begin, 0-based.
        /// Defaults to <c>0</c> (Sunday).
        /// </summary>
        public JsNumber startDay;
        /// <summary>
        /// The date format string which will be submitted to the server. The format must be valid according to
        /// Ext.Date.parse.
        /// Defaults to <see cref="Ext.form.field.DateConfig.format">format</see>.
        /// </summary>
        public JsString submitFormat;
        /// <summary>
        /// True to enforce strict date parsing to prevent the default Javascript "date rollover".
        /// Defaults to the useStrict parameter set on Ext.Date
        /// See Ext.Date.parse.
        /// </summary>
        public bool useStrict;
        /// <summary>
        /// Focuses the field when collapsing the Date picker.
        /// </summary>
        private void onCollapse(){}
        /// <summary>
        /// Sets the Date picker's value to match the current field value when expanding.
        /// </summary>
        private void onExpand(){}
        /// <summary>
        /// Parameters<li><span>value</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="value">
        /// </param>
        private void parseDate(object value){}
        /// <summary>
        /// Attempts to parse a given string value using a given date format.
        /// </summary>
        /// <param name="value"><p>The value to attempt to parse</p>
        /// </param>
        /// <param name="format"><p>A valid date format (see <see cref="Ext.Date.parse">Ext.Date.parse</see>)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Date">Date</see></span><div><p>The parsed Date object, or null if the value could not be successfully parsed.</p>
        /// </div>
        /// </returns>
        public JsDate safeParse(JsString value, JsString format){return null;}
        /// <summary>
        /// Replaces any existing disabled dates with new values and refreshes the Date picker.
        /// </summary>
        /// <param name="disabledDates"><p>An array of date strings (see the <see cref="Ext.form.field.DateConfig.disabledDates">disabledDates</see> config for details on
        /// supported values) used to disable a pattern of dates.</p>
        /// </param>
        public void setDisabledDates(JsArray<String> disabledDates){}
        /// <summary>
        /// Replaces any existing disabled days (by index, 0-6) with new values and refreshes the Date picker.
        /// </summary>
        /// <param name="disabledDays"><p>An array of disabled day indexes. See the <see cref="Ext.form.field.DateConfig.disabledDays">disabledDays</see> config for details on
        /// supported values.</p>
        /// </param>
        public void setDisabledDays(JsArray<Number> disabledDays){}
        /// <summary>
        /// Replaces any existing maxValue with the new value and refreshes the Date picker.
        /// </summary>
        /// <param name="value"><p>The maximum date that can be selected</p>
        /// </param>
        public void setMaxValue(JsDate value){}
        /// <summary>
        /// Replaces any existing minValue with the new value and refreshes the Date picker.
        /// </summary>
        /// <param name="value"><p>The minimum date that can be selected</p>
        /// </param>
        public void setMinValue(JsDate value){}
        public Date(Ext.form.field.DateConfig config){}
        public Date(){}
        public Date(params object[] args){}
    }
    #endregion
    #region DateConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateConfig : PickerConfig
    {
        /// <summary>
        /// Multiple date formats separated by "|" to try when parsing a user input value and it does not match the defined
        /// format.
        /// Defaults to: <c>&quot;m/d/Y|n/j/Y|n/j/y|m/j/y|n/d/y|m/j/Y|n/d/Y|m-d-y|m-d-Y|m/d|m-d|md|mdy|mdY|d|Y-m-d|n-j|n/j&quot;</c>
        /// </summary>
        public JsString altFormats;
        /// <summary>
        /// An array of "dates" to disable, as strings. These strings will be used to build a dynamic regular expression so
        /// they are very powerful. Some examples:
        /// <code>// disable these exact dates:
        /// disabledDates: ["03/08/2003", "09/16/2003"]
        /// // disable these days for every year:
        /// disabledDates: ["03/08", "09/16"]
        /// // only match the beginning (useful if you are using short years):
        /// disabledDates: ["^03/08"]
        /// // disable every day in March 2006:
        /// disabledDates: ["03/../2006"]
        /// // disable every day in every March:
        /// disabledDates: ["^03"]
        /// </code>
        /// Note that the format of the dates included in the array should exactly match the <see cref="Ext.form.field.DateConfig.format">format</see> config. In order
        /// to support regular expressions, if you are using a <see cref="Ext.form.field.DateConfig.format">date format</see> that has "." in it, you will have
        /// to escape the dot when restricting dates. For example: <c>["03\\.08\\.03"]</c>.
        /// </summary>
        public JsString disabledDates;
        /// <summary>
        /// The tooltip text to display when the date falls on a disabled date.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDatesText;
        /// <summary>
        /// An array of days to disable, 0 based. Some examples:
        /// <code>// disable Sunday and Saturday:
        /// disabledDays:  [0, 6]
        /// // disable weekdays:
        /// disabledDays: [1,2,3,4,5]
        /// </code>
        /// </summary>
        public JsNumber disabledDays;
        /// <summary>
        /// The tooltip to display when the date falls on a disabled day.
        /// Defaults to: <c>&quot;Disabled&quot;</c>
        /// </summary>
        public JsString disabledDaysText;
        /// <summary>
        /// The default date format string which can be overriden for localization support. The format must be valid
        /// according to Ext.Date.parse.
        /// Defaults to: <c>&quot;m/d/Y&quot;</c>
        /// </summary>
        public JsString format;
        /// <summary>
        /// The error text to display when the date in the cell is after maxValue.
        /// Defaults to: <c>&quot;The date in this field must be equal to or before {0}&quot;</c>
        /// </summary>
        public JsString maxText;
        /// <summary>
        /// The maximum allowed date. Can be either a Javascript date object or a string date in a valid format.
        /// </summary>
        public object maxValue;
        /// <summary>
        /// The error text to display when the date in the cell is before minValue.
        /// Defaults to: <c>&quot;The date in this field must be equal to or after {0}&quot;</c>
        /// </summary>
        public JsString minText;
        /// <summary>
        /// The minimum allowed date. Can be either a Javascript date object or a string date in a valid format.
        /// </summary>
        public object minValue;
        /// <summary>
        /// false to hide the footer area of the Date picker containing the Today button and disable the keyboard handler for
        /// spacebar that selects the current date.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool showToday;
        /// <summary>
        /// Day index at which the week should begin, 0-based.
        /// Defaults to <c>0</c> (Sunday).
        /// </summary>
        public JsNumber startDay;
        /// <summary>
        /// The date format string which will be submitted to the server. The format must be valid according to
        /// Ext.Date.parse.
        /// Defaults to <see cref="Ext.form.field.DateConfig.format">format</see>.
        /// </summary>
        public JsString submitFormat;
        /// <summary>
        /// True to enforce strict date parsing to prevent the default Javascript "date rollover".
        /// Defaults to the useStrict parameter set on Ext.Date
        /// See Ext.Date.parse.
        /// </summary>
        public bool useStrict;
        public DateConfig(params object[] args){}
    }
    #endregion
    #region DateEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateEvents : PickerEvents
    {
        public DateEvents(params object[] args){}
    }
    #endregion
}
