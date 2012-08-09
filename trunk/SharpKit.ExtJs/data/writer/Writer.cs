//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.writer
namespace Ext.data.writer
{
    #region Writer
    /// <summary>
    /// Base Writer class used by most subclasses of Ext.data.proxy.Server. This class is
    /// responsible for taking a set of Ext.data.Operation objects and a Ext.data.Request
    /// object and modifying that request based on the Operations. For example a Ext.data.writer.Json would format the Operations and their Ext.data.Model
    /// instances based on the config options passed to the JsonWriter&#39;s constructor. Writers are not needed for any kind of local storage - whether via a
    /// Web Storage proxy (see localStorage
    /// and sessionStorage) or just in memory via a
    /// MemoryProxy.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Writer
    {
        /// <summary>
        /// Creates new Writer. ...
        /// </summary>
        public Writer(object config=null){}
        /// <summary>
        /// Formats the data for each record before sending it to the server. ...
        /// </summary>
        public object getRecordData(object record){return null;}
        /// <summary>
        /// Prepares a Proxy's Ext.data.Request object ...
        /// </summary>
        public Request write(Request request){return null;}
        public Writer(WriterConfig config){}
    }
    #endregion
    #region WriterConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class WriterConfig
    {
        /// <summary>
        /// This property is used to read the key for each value that will be sent to the server. ...
        /// </summary>
        public JsString nameProperty{get;set;}
        /// <summary>
        /// True to write all fields from the record to the server. ...
        /// </summary>
        public bool writeAllFields{get;set;}
    }
    #endregion
    #region WriterEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class WriterEvents
    {
    }
    #endregion
}
#endregion