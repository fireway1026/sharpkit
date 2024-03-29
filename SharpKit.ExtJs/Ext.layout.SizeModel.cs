//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout
{
    #region SizeModel
    /// <summary>
    /// <p>This class describes a size determination strategy or algorithm used by the layout
    /// system. There are special instances of this class stored as static properties to
    /// avoid needless object instantiation. These instances should be treated as readonly.</p>
    /// <ul>
    /// <li><c>calculated</c></li>
    /// <li><c>configured</c></li>
    /// <li><c>constrainedMax</c></li>
    /// <li><c>constrainedMin</c></li>
    /// <li><c>natural</c></li>
    /// <li><c>shrinkWrap</c></li>
    /// <li><c>calculatedFromConfigured</c></li>
    /// <li><c>calculatedFromNatural</c></li>
    /// <li><c>calculatedFromShrinkWrap</c></li>
    /// </ul>
    /// <p>Using one of these instances is simply:</p>
    /// <pre><code>  var calculated = <see cref="Ext.layout.SizeModel.calculated">Ext.layout.SizeModel.calculated</see>;
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class SizeModel
    {
        /// <summary>
        /// True if the size is either natural or shrinkWrap, otherwise false.
        /// </summary>
        public bool auto{get;set;}
        /// <summary>
        /// True if the size is calculated by the ownerLayout.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool calculated{get;set;}
        /// <summary>
        /// True if the size is calculated by the ownerLayout based on a configured size.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool calculatedFromConfigured{get;set;}
        /// <summary>
        /// True if the size is calculated by the ownerLayout based on natural size model
        /// results.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool calculatedFromNatural{get;set;}
        /// <summary>
        /// True if the size is calculated by the ownerLayout based on shrinkWrap size model
        /// results.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool calculatedFromShrinkWrap{get;set;}
        /// <summary>
        /// True if the size is configured (e.g., by a width or minWidth). The names of
        /// configuration properties can be found in the names property.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool configured{get;set;}
        /// <summary>
        /// True if the size is constrained by a maxWidth or maxHeight configuration. This
        /// is a flavor of configured (since maxWidth and maxHeight are config options).
        /// If true, the names property will be defined as well.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrainedMax{get;set;}
        /// <summary>
        /// True if the size is constrained by a minWidth or minHeight configuration. This
        /// is a flavor of configured (since minWidth and minHeight are config options).
        /// If true, the names property will be defined as well.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrainedMin{get;set;}
        /// <summary>
        /// True if the size is either calculated or configured, otherwise false.
        /// </summary>
        public bool @fixed{get;set;}
        /// <summary>
        /// The name of this size model (e.g., "calculated").
        /// </summary>
        public JsString name{get;set;}
        /// <summary>
        /// An object with the config property names that determine the
        /// size.
        /// Defaults to: <c>null</c><li><span>width</span> : <see cref="String">String</see><div><p>The width property name (e.g., 'width').</p>
        /// </div></li><li><span>height</span> : <see cref="String">String</see><div><p>The height property name (e.g., 'minHeight').</p>
        /// </div></li>
        /// </summary>
        public JsObject names{get;set;}
        /// <summary>
        /// True if the size is determined by CSS and not by content. Such sizes are assumed to
        /// be dependent on the container box and measurement occurs on the outer-most element.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool natural{get;set;}
        /// <summary>
        /// @prop {Number} ordinal
        /// The 0-based ordinal for this SizeModel instance.
        /// </summary>
        public JsObject ordinal{get;set;}
        /// <summary>
        /// An array of objects indexed by the ordinal of a height SizeModel on
        /// a width SizeModel to yield an object describing both height and width size
        /// models.
        /// Used like this:
        /// <code> widthModel.pairsByHeightOrdinal[heightModel.ordinal]
        /// </code>
        /// This provides a reusable object equivalent to the following:
        /// <code> {
        /// width: widthModel,
        /// height: heightModel
        /// }
        /// </code>
        /// <li><span>width</span> : <see cref="Ext.layout.SizeModel">Ext.layout.SizeModel</see><div><p>The <c>SizeModel</c> for
        /// the width.</p>
        /// </div></li><li><span>height</span> : <see cref="Ext.layout.SizeModel">Ext.layout.SizeModel</see><div><p>The <c>SizeModel</c> for
        /// the height.</p>
        /// </div></li>
        /// </summary>
        public JsObject pairsByHeightOrdinal{get;set;}
        /// <summary>
        /// True if the size is determined by content irrespective of the container box.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool shrinkWrap{get;set;}
        public SizeModel(SizeModelConfig config){}
        public SizeModel(){}
        public SizeModel(params object[] args){}
    }
    #endregion
    #region SizeModelConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SizeModelConfig
    {
        public SizeModelConfig(params object[] args){}
    }
    #endregion
    #region SizeModelEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SizeModelEvents
    {
        public SizeModelEvents(params object[] args){}
    }
    #endregion
}
