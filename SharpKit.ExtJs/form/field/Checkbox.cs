//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region Checkbox
    /// <summary>
    /// Single checkbox field. Can be used as a direct replacement for traditional checkbox fields. Also serves as a
    /// parent class for radio buttons. Labeling: In addition to the standard field labeling options, checkboxes
    /// may be given an optional boxLabel which will be displayed immediately after checkbox. Also see
    /// Ext.form.CheckboxGroup for a convenient method of grouping related checkboxes. Values:
    /// The main value of a checkbox is a boolean, indicating whether or not the checkbox is checked.
    /// The following values will check the checkbox:
    /// true &#39;true&#39; &#39;1&#39; &#39;on&#39; Any other value will uncheck the checkbox. In addition to the main boolean value, you may also specify a separate inputValue. This will be
    /// sent as the parameter value when the form is submitted. You will want to set
    /// this value if you have multiple checkboxes with the same name. If not specified, the value on
    /// will be used.
    /// Example usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// bodyPadding: 10,
    /// width      : 300,
    /// title      : &#39;Pizza Order&#39;,
    /// items: [
    /// {
    /// xtype      : &#39;fieldcontainer&#39;,
    /// fieldLabel : &#39;Toppings&#39;,
    /// defaultType: &#39;checkboxfield&#39;,
    /// items: [
    /// {
    /// boxLabel  : &#39;Anchovies&#39;,
    /// name      : &#39;topping&#39;,
    /// inputValue: &#39;1&#39;,
    /// id        : &#39;checkbox1&#39;
    /// }, {
    /// boxLabel  : &#39;Artichoke Hearts&#39;,
    /// name      : &#39;topping&#39;,
    /// inputValue: &#39;2&#39;,
    /// checked   : true,
    /// id        : &#39;checkbox2&#39;
    /// }, {
    /// boxLabel  : &#39;Bacon&#39;,
    /// name      : &#39;topping&#39;,
    /// inputValue: &#39;3&#39;,
    /// id        : &#39;checkbox3&#39;
    /// }
    /// ]
    /// }
    /// ],
    /// bbar: [
    /// {
    /// text: &#39;Select Bacon&#39;,
    /// handler: function() {
    /// var checkbox = Ext.getCmp(&#39;checkbox3&#39;);
    /// checkbox.setValue(true);
    /// }
    /// },
    /// &#39;-&#39;,
    /// {
    /// text: &#39;Select All&#39;,
    /// handler: function() {
    /// var checkbox1 = Ext.getCmp(&#39;checkbox1&#39;),
    /// checkbox2 = Ext.getCmp(&#39;checkbox2&#39;),
    /// checkbox3 = Ext.getCmp(&#39;checkbox3&#39;);
    /// checkbox1.setValue(true);
    /// checkbox2.setValue(true);
    /// checkbox3.setValue(true);
    /// }
    /// },
    /// {
    /// text: &#39;Deselect All&#39;,
    /// handler: function() {
    /// var checkbox1 = Ext.getCmp(&#39;checkbox1&#39;),
    /// checkbox2 = Ext.getCmp(&#39;checkbox2&#39;),
    /// checkbox3 = Ext.getCmp(&#39;checkbox3&#39;);
    /// checkbox1.setValue(false);
    /// checkbox2.setValue(false);
    /// checkbox3.setValue(false);
    /// }
    /// }
    /// ],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Checkbox : Ext.form.field.Base, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Calculate and return the natural width of the bodyEl. ...
        /// </summary>
        public new object getBodyNaturalWidth(){return null;}
        /// <summary>
        /// Returns the checked state of the checkbox. ...
        /// </summary>
        public new bool getRawValue(){return false;}
        /// <summary>
        /// Returns the submit value for the checkbox which can be used when submitting forms. ...
        /// </summary>
        public new object getSubmitValue(){return null;}
        /// <summary>
        /// Returns the checked state of the checkbox. ...
        /// </summary>
        public new bool getValue(){return false;}
        /// <summary>
        /// Sets the checked state of the checkbox. ...
        /// </summary>
        public new bool setRawValue(object value){return false;}
        /// <summary>
        /// Sets the checked state of the checkbox, and invokes change detection. ...
        /// </summary>
        public new Ext.form.field.Field setValue(object @checked){return null;}
        /// <summary>
        /// A reference to the label element created for the boxLabel. ...
        /// </summary>
        public Ext.core.Element boxLabelEl{get;set;}
        /// <summary>
        /// The original value of the field as configured in the checked configuration, or
        /// as loaded by the last form load operat...
        /// </summary>
        public new object originalValue{get;set;}
        public Checkbox(CheckboxConfig config){}
        public Checkbox(){}
    }
    #endregion
    #region CheckboxConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckboxConfig : Ext.form.field.BaseConfig
    {
        /// <summary>
        /// An optional text label that will appear next to the checkbox. ...
        /// </summary>
        public JsString boxLabel{get;set;}
        /// <summary>
        /// The position relative to the checkbox where the boxLabel should
        /// appear. ...
        /// </summary>
        public JsString boxLabelAlign{get;set;}
        public JsString boxLabelCls{get;set;}
        public bool @checked{get;set;}
        public JsString checkedCls{get;set;}
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to fieldBodyCls. ...
        /// </summary>
        public new JsString fieldBodyCls{get;set;}
        public new JsString fieldCls{get;set;}
        public new JsString focusCls{get;set;}
        /// <summary>
        /// A function called when the checked value changes (can be used instead of
        /// handling the change event). ...
        /// </summary>
        public JsAction handler{get;set;}
        /// <summary>
        /// The value that should go into the generated input element's value attribute and
        /// should be used as the parameter value...
        /// </summary>
        public JsString inputValue{get;set;}
        public object scope{get;set;}
        /// <summary>
        /// If configured, this will be submitted as the checkbox's value during form
        /// submit if the checkbox is unchecked. ...
        /// </summary>
        public JsString uncheckedValue{get;set;}
    }
    #endregion
    #region CheckboxEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CheckboxEvents : Ext.form.field.BaseEvents
    {
    }
    #endregion
}
#endregion
