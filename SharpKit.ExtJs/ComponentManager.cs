//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext
namespace Ext
{
    #region ComponentManager
    /// <summary>
    /// Provides a registry of all Components (instances of Ext.Component or any subclass
    /// thereof) on a page so that they can be easily accessed by component id (see get, or the convenience method Ext.getCmp). This object also provides a registry of available Component classes
    /// indexed by a mnemonic code known as the Component&#39;s xtype.
    /// The xtype provides a way to avoid instantiating child Components
    /// when creating a full, nested config object for a complete Ext page. A child Component may be specified simply as a config object
    /// as long as the correct xtype is specified so that if and when the Component
    /// needs rendering, the correct type can be looked up for lazy instantiation. For a list of all available xtypes, see Ext.Component.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ComponentManager : AbstractManager
    {
        /// <summary>
        /// Creates a new Component from the specified config object using the
        /// config object's xtype to determine the class to in...
        /// </summary>
        public static Ext.Component create(object config, Constructor defaultType){return null;}
        public ComponentManager(ComponentManagerConfig config){}
        public ComponentManager(){}
    }
    #endregion
    #region ComponentManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentManagerConfig : AbstractManagerConfig
    {
    }
    #endregion
    #region ComponentManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentManagerEvents : AbstractManagerEvents
    {
    }
    #endregion
}
#endregion
