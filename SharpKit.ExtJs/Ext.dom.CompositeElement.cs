//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dom
{
    #region CompositeElement
    /// <inheritdocs />
    /// <summary>
    /// <p>This class encapsulates a <i>collection</i> of DOM elements, providing methods to filter
    /// members, or to perform collective actions upon the whole set.</p>
    /// <p>Although they are not listed, this class supports all of the methods of <see cref="Ext.dom.Element">Ext.dom.Element</see> and
    /// <see cref="Ext.fx.Anim">Ext.fx.Anim</see>. The methods from these classes will be performed on all the elements in this collection.</p>
    /// <p>All methods return <i>this</i> and can be chained.</p>
    /// <p>Usage:</p>
    /// <pre><code> var els = <see cref="Ext.ExtContext.select">Ext.select</see>("#some-el div.some-class", true);
    /// // or select directly from an existing element
    /// var el = <see cref="Ext.ExtContext.get">Ext.get</see>('some-el');
    /// el.select('div.some-class', true);
    /// els.setWidth(100); // all elements become 100 width
    /// els.hide(true); // all elements fade out and hide
    /// // or
    /// els.setWidth(100).hide(true);
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class CompositeElement : CompositeElementLite
    {
        public CompositeElement(Ext.dom.CompositeElementConfig config){}
        public CompositeElement(){}
        public CompositeElement(params object[] args){}
    }
    #endregion
    #region CompositeElementConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CompositeElementConfig : CompositeElementLiteConfig
    {
        public CompositeElementConfig(params object[] args){}
    }
    #endregion
    #region CompositeElementEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CompositeElementEvents : CompositeElementLiteEvents
    {
        public CompositeElementEvents(params object[] args){}
    }
    #endregion
}
