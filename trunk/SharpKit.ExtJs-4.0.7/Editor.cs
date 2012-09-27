//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Editor
    /// <summary>
    /// The Editor class is used to provide inline editing for elements on the page. The editor
    /// is backed by a Ext.form.field.Field that will be displayed to edit the underlying content.
    /// The editor is a floating Component, when the editor is shown it is automatically aligned to
    /// display over the top of the bound element it is editing. The Editor contains several options
    /// for how to handle key presses:
    /// completeOnEnter cancelOnEsc swallowKeys
    /// It also has options for how to use the value once the editor has been activated:
    /// revertInvalid ignoreNoChange updateEl
    /// Sample usage:
    /// var editor = new Ext.Editor({
    /// updateEl: true, // update the innerHTML of the bound element when editing completes
    /// field: {
    /// xtype: &#39;textfield&#39;
    /// }
    /// });
    /// var el = Ext.get(&#39;my-text&#39;); // The element to &#39;edit&#39;
    /// editor.startEdit(el); // The value of the field will be taken as the innerHTML of the element.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Editor : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Cancels the editing process and hides the editor without persisting any changes. ...
        /// </summary>
        public object cancelEdit(bool remainVisible){return null;}
        /// <summary>
        /// Ends the editing process, persists the changed value to the underlying field, and hides the editor. ...
        /// </summary>
        public object completeEdit(bool remainVisible){return null;}
        /// <summary>
        /// Gets the data value of the editor ...
        /// </summary>
        public object getValue(){return null;}
        /// <summary>
        /// Realigns the editor to the bound field based on the current alignment config value. ...
        /// </summary>
        public object realign(bool autoSize=false){return null;}
        /// <summary>
        /// Sets the data value of the editor ...
        /// </summary>
        public object setValue(object value){return null;}
        /// <summary>
        /// Starts the editing process and shows the editor. ...
        /// </summary>
        public object startEdit(object el, JsString value=null){return null;}
        public Editor(EditorConfig config){}
        public Editor(){}
    }
    #endregion
    #region EditorConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class EditorConfig : Ext.ComponentConfig
    {
        public JsString alignment{get;set;}
        /// <summary>
        /// True to complete the editing process if in edit mode when the
        /// field is blurred. ...
        /// </summary>
        public bool allowBlur{get;set;}
        /// <summary>
        /// True for the editor to automatically adopt the size of the underlying field. ...
        /// </summary>
        public object autoSize{get;set;}
        /// <summary>
        /// True to cancel the edit when the escape key is pressed. ...
        /// </summary>
        public bool cancelOnEsc{get;set;}
        /// <summary>
        /// True to complete the edit when the enter key is pressed. ...
        /// </summary>
        public bool completeOnEnter{get;set;}
        public bool constrain{get;set;}
        public Ext.form.field.Field field{get;set;}
        public bool hideEl{get;set;}
        /// <summary>
        /// True to skip the edit completion process (no save, no events fired) if the user completes an edit and
        /// the value has n...
        /// </summary>
        public bool ignoreNoChange{get;set;}
        /// <summary>
        /// The offsets to use when aligning (see Ext.core.Element.alignTo for more details. ...
        /// </summary>
        public JsArray offsets{get;set;}
        /// <summary>
        /// An element to render to. ...
        /// </summary>
        public object parentEl{get;set;}
        /// <summary>
        /// True to automatically revert the field value and cancel the edit when the user completes an edit and the field
        /// valida...
        /// </summary>
        public bool revertInvalid{get;set;}
        public new object shadow{get;set;}
        public bool swallowKeys{get;set;}
        public bool updateEl{get;set;}
        public object value{get;set;}
    }
    #endregion
    #region EditorEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class EditorEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires after a change has been made to the field, but before the change is reflected in the underlying
        /// field. ...
        /// </summary>
        public static JsString beforecomplete="beforecomplete";
        /// <summary>
        /// Fires when editing is initiated, but before the value changes. ...
        /// </summary>
        public static JsString beforestartedit="beforestartedit";
        /// <summary>
        /// Fires after editing has been canceled and the editor's value has been reset. ...
        /// </summary>
        public static JsString canceledit="canceledit";
        /// <summary>
        /// Fires after editing is complete and any changed value has been written to the underlying field. ...
        /// </summary>
        public static JsString complete="complete";
        /// <summary>
        /// Fires when any key related to navigation (arrows, tab, enter, esc, etc.) is pressed. ...
        /// </summary>
        public static JsString specialkey="specialkey";
        /// <summary>
        /// Fires when this editor is displayed ...
        /// </summary>
        public static JsString startedit="startedit";
    }
    #endregion
}
#endregion