//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.draw
namespace Ext.draw
{
    #region Sprite
    /// <summary>
    /// A Sprite is an object rendered in a Drawing surface. There are different options and types of sprites.
    /// The configuration of a Sprite is an object with the following properties:  type - (String) The type of the sprite. Possible options are &#39;circle&#39;, &#39;path&#39;, &#39;rect&#39;, &#39;text&#39;, &#39;square&#39;, &#39;image&#39;. group - (String/Array) The group that this sprite belongs to, or an array of groups. Only relevant when added to a Ext.draw.Surface. width - (Number) Used in rectangle sprites, the width of the rectangle. height - (Number) Used in rectangle sprites, the height of the rectangle. size - (Number) Used in square sprites, the dimension of the square. radius - (Number) Used in circle sprites, the radius of the circle. x - (Number) The position along the x-axis. y - (Number) The position along the y-axis. path - (Array) Used in path sprites, the path of the sprite written in SVG-like path syntax. opacity - (Number) The opacity of the sprite. fill - (String) The fill color. stroke - (String) The stroke color. stroke-width - (Number) The width of the stroke. font - (String) Used with text type sprites. The full font description. Uses the same syntax as the CSS font parameter. text - (String) Used with text type sprites. The text itself. translate - (Object) Defines a translation for the Sprite. There&#39;s more information on this property below. rotate - (Object) Defines a rotation for the Sprite. There&#39;s more information on this property below. scale - (Object) Defines a scaling for the Sprite. There&#39;s more information on this property below.  Translation For translate, the configuration object contains x and y attributes that indicate where to
    /// translate the object. For example: sprite.setAttributes({
    /// translate: {
    /// x: 10,
    /// y: 10
    /// }
    /// }, true);
    /// Rotation For rotation, the configuration object contains x and y attributes for the center of the rotation (which are optional),
    /// and a degrees attribute that specifies the rotation in degrees. For example: sprite.setAttributes({
    /// rotate: {
    /// degrees: 90
    /// }
    /// }, true);
    /// That example will create a 90 degrees rotation using the centroid of the Sprite as center of rotation, whereas: sprite.setAttributes({
    /// rotate: {
    /// x: 0,
    /// y: 0,
    /// degrees: 90
    /// }
    /// }, true);
    /// will create a rotation around the (0, 0) axis. Scaling For scaling, the configuration object contains x and y attributes for the x-axis and y-axis scaling. For example: sprite.setAttributes({
    /// scale: {
    /// x: 10,
    /// y: 3
    /// }
    /// }, true);
    /// You can also specify the center of scaling by adding cx and cy as properties: sprite.setAttributes({
    /// scale: {
    /// cx: 0,
    /// cy: 0,
    /// x: 10,
    /// y: 3
    /// }
    /// }, true);
    /// That last example will scale a sprite taking as centers of scaling the (0, 0) coordinate. Creating and adding a Sprite to a Surface Sprites can be created with a reference to a Ext.draw.Surface  var drawComponent = Ext.create(&#39;Ext.draw.Component&#39;, options here...);
    /// var sprite = Ext.create(&#39;Ext.draw.Sprite&#39;, {
    /// type: &#39;circle&#39;,
    /// fill: &#39;#ff0&#39;,
    /// surface: drawComponent.surface,
    /// radius: 5
    /// });
    /// Sprites can also be added to the surface as a configuration object:  var sprite = drawComponent.surface.add({
    /// type: &#39;circle&#39;,
    /// fill: &#39;#ff0&#39;,
    /// radius: 5
    /// });
    /// In order to properly apply properties and render the sprite we have to
    /// show the sprite setting the option redraw to true:  sprite.show(true);
    /// The constructor configuration object of the Sprite can also be used and passed into the Ext.draw.Surface
    /// add method to append a new sprite to the canvas. For example: drawComponent.surface.add({
    /// type: &#39;circle&#39;,
    /// fill: &#39;#ffc&#39;,
    /// radius: 100,
    /// x: 100,
    /// y: 100
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Sprite
    {
        /// <summary>
        /// Adds one or more CSS classes to the element. ...
        /// </summary>
        public Ext.draw.Sprite addCls(object className){return null;}
        /// <summary>
        /// Removes the sprite and clears all listeners. ...
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Retrieve the bounding box of the sprite. ...
        /// </summary>
        public object getBBox(){return null;}
        /// <summary>
        /// Hide the sprite. ...
        /// </summary>
        public Ext.draw.Sprite hide(bool redraw){return null;}
        /// <summary>
        /// Redraw the sprite. ...
        /// </summary>
        public Ext.draw.Sprite redraw(){return null;}
        /// <summary>
        /// Remove the sprite. ...
        /// </summary>
        public object remove(){return null;}
        /// <summary>
        /// Removes one or more CSS classes from the element. ...
        /// </summary>
        public Ext.draw.Sprite removeCls(object className){return null;}
        /// <summary>
        /// Change the attributes of the sprite. ...
        /// </summary>
        public Ext.draw.Sprite setAttributes(object attrs, bool redraw){return null;}
        /// <summary>
        /// Wrapper for setting style properties, also takes single object parameter of multiple styles. ...
        /// </summary>
        public Ext.draw.Sprite setStyle(object property, JsString value=null){return null;}
        /// <summary>
        /// Show the sprite. ...
        /// </summary>
        public Ext.draw.Sprite show(bool redraw){return null;}
        /// <summary>
        /// If this Sprite is configured draggable, this property will contain
        /// an instance of Ext.dd.DragSource which handles dra...
        /// </summary>
        public Ext.dd.DragSource dd{get;set;}
        public Sprite(Ext.draw.SpriteConfig config){}
        public Sprite(){}
    }
    #endregion
    #region SpriteConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class SpriteConfig
    {
        public JsString fill{get;set;}
        /// <summary>
        /// Used with text type sprites. ...
        /// </summary>
        public JsString font{get;set;}
        /// <summary>
        /// The group that this sprite belongs to, or an array of groups. ...
        /// </summary>
        public object group{get;set;}
        public JsNumber height{get;set;}
        public JsNumber opacity{get;set;}
        public JsArray path{get;set;}
        public JsNumber radius{get;set;}
        public JsNumber size{get;set;}
        public JsNumber stroke{get;set;}
        /// <summary>
        /// Used with text type sprites. ...
        /// </summary>
        public JsString text{get;set;}
        /// <summary>
        /// The type of the sprite. ...
        /// </summary>
        public JsString type{get;set;}
        public JsNumber width{get;set;}
        public JsNumber x{get;set;}
        public JsNumber y{get;set;}
    }
    #endregion
    #region SpriteEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class SpriteEvents
    {
    }
    #endregion
}
#endregion
