//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.tinymce
{
    /// <summary>
    /// This class is responsible for managing UI control instances.
    /// </summary>
    public  partial class ControlManager
    {
        /// <summary>
        /// Adds a control to the control collection inside the manager.
        /// </summary>
        /// <param name="Control">instance to add to collection.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control add(SharpKit.TinyMCE.tinymce.ui.Control Control){return null;}
        /// <summary>
        /// Constructs a new control manager instance.
        /// Consult the Wiki for more details on this class.
        /// </summary>
        /// <param name="ed">TinyMCE editor instance to add the control to.</param>
        /// <param name="s">Optional settings object for the control manager.</param>
        public ControlManager(SharpKit.TinyMCE.tinymce.Editor ed, object s){}
        /// <summary>
        /// Creates a button control instance by id.
        /// </summary>
        /// <param name="id">Unique id for the new button instance. For example "bold".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createButton(string id, object s, object cc){return null;}
        /// <summary>
        /// Creates a color split button control instance by id.
        /// </summary>
        /// <param name="id">Unique id for the new color split button instance. For example "forecolor".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createColorSplitButton(string id, object s, object cc){return null;}
        /// <summary>
        /// Creates a control by name, when a control is created it will automatically add it to the control collection.
        /// It first ask all plugins for the specified control if the plugins didn't return a control then the default behavior
        /// will be used.
        /// </summary>
        /// <param name="name">Control name to create for example "separator".</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createControl(string name){return null;}
        /// <summary>
        /// Creates a drop menu control instance by id.
        /// </summary>
        /// <param name="id">Unique id for the new dropdown instance. For example "some menu".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createDropMenu(string id, object s, object cc){return null;}
        /// <summary>
        /// Creates a list box control instance by id. A list box is either a native select element or a DOM/JS based list box control. This
        /// depends on the use_native_selects settings state.
        /// </summary>
        /// <param name="id">Unique id for the new listbox instance. For example "styles".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createListBox(string id, object s, object cc){return null;}
        /// <summary>
        /// Creates a menu button control instance by id.
        /// </summary>
        /// <param name="id">Unique id for the new menu button instance. For example "menu1".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createMenuButton(string id, object s, object cc){return null;}
        /// <summary>
        /// Creates a separator control instance.
        /// </summary>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createSeparator(object cc){return null;}
        /// <summary>
        /// Creates a split button control instance by id.
        /// </summary>
        /// <param name="id">Unique id for the new split button instance. For example "spellchecker".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createSplitButton(string id, object s, object cc){return null;}
        /// <summary>
        /// Creates a toolbar container control instance by id.
        /// </summary>
        /// <param name="id">Unique id for the new toolbar container control instance. For example "toolbar1".</param>
        /// <param name="s">Optional settings object for the control.</param>
        /// <param name="cc">Optional control class to use instead of the default one.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control createToolbar(string id, object s, object cc){return null;}
        /// <summary>
        /// Destroy.
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Returns a control by id or undefined it it wasn't found.
        /// </summary>
        /// <param name="id">Control instance name.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control get(string id){return null;}
        /// <summary>
        /// Sets the active state of a control by id.
        /// </summary>
        /// <param name="id">Control id to set state on.</param>
        /// <param name="s">Active state true/false.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control setActive(string id, bool s){return null;}
        /// <summary>
        /// Overrides a specific control type with a custom class.
        /// </summary>
        /// <param name="n">Name of the control to override for example button or dropmenu.</param>
        /// <param name="c">Class reference to use instead of the default one.</param>
        public object setControlType(string n, object c){return null;}
        /// <summary>
        /// Sets the dsiabled state of a control by id.
        /// </summary>
        /// <param name="id">Control id to set state on.</param>
        /// <param name="s">Active state true/false.</param>
        public SharpKit.TinyMCE.tinymce.ui.Control setDisabled(string id, bool s){return null;}
    }
}
