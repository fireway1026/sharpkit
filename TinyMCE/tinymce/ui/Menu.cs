//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.ui
{
    /// <summary>
    /// This class is base class for all menu types like DropMenus etc.
    /// </summary>
    public  partial class Menu
    {
        /// <summary>
        /// Adds a new menu, menu item or sub classes of them to the drop menu.
        /// </summary>
        /// <param name="o">Menu or menu item to add to the drop menu.</param>
        public SharpKit.TinyMCE.ui.Control add(SharpKit.TinyMCE.ui.Control o){return null;}
        /// <summary>
        /// Adds a sub menu to the menu.
        /// </summary>
        /// <param name="o">Menu control or a object with settings to be created into an control.</param>
        public SharpKit.TinyMCE.ui.Menu addMenu(object o){return null;}
        /// <summary>
        /// Adds a menu separator between the menu items.
        /// </summary>
        public SharpKit.TinyMCE.ui.MenuItem addSeparator(){return null;}
        /// <summary>
        /// Collapses the menu, this will hide the menu and all menu items.
        /// </summary>
        /// <param name="d">Optional deep state. If this is set to true all children will be collapsed as well.</param>
        public object collapse(bool d){return null;}
        /// <summary>
        /// Created a new sub menu for the menu control.
        /// </summary>
        /// <param name="s">Optional name/value settings object.</param>
        public SharpKit.TinyMCE.ui.Menu createMenu(object s){return null;}
        public object destroy(){return null;}
        /// <summary>
        /// Expands the menu, this will show them menu and all menu items.
        /// </summary>
        /// <param name="d">Optional deep state. If this is set to true all children will be expanded as well.</param>
        public object expand(bool d){return null;}
        /// <summary>
        /// Returns true/false if the menu has sub menus or not.
        /// </summary>
        public bool hasMenus(){return false;}
        public object isActive(){return null;}
        /// <summary>
        /// Returns true/false if the menu has been collapsed or not.
        /// </summary>
        public bool isCollapsed(){return false;}
        public object isDisabled(){return null;}
        public object isRendered(){return null;}
        public object isSelected(){return null;}
        /// <summary>
        /// Constructs a new button control instance.
        /// </summary>
        /// <param name="id">Button control id for the button.</param>
        /// <param name="s">Optional name/value settings object.</param>
        public Menu(string id, object s){}
        public object postRender(){return null;}
        /// <summary>
        /// Removes a specific sub menu or menu item from the menu.
        /// </summary>
        /// <param name="o">Menu item or menu to remove from menu.</param>
        public SharpKit.TinyMCE.ui.Control remove(SharpKit.TinyMCE.ui.Control o){return null;}
        /// <summary>
        /// Removes all menu items and sub menu items from the menu.
        /// </summary>
        public object removeAll(){return null;}
        public object renderHTML(){return null;}
        public object renderTo(){return null;}
        public object setActive(){return null;}
        public object setDisabled(){return null;}
        public object setSelected(){return null;}
        public object setState(){return null;}
    }
}
