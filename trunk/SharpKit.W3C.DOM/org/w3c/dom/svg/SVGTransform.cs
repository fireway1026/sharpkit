//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGTransform
{

	// SVGTransform
	public static short SVG_TRANSFORM_UNKNOWN = 0;
	public static short SVG_TRANSFORM_MATRIX = 1;
	public static short SVG_TRANSFORM_TRANSLATE = 2;
	public static short SVG_TRANSFORM_SCALE = 3;
	public static short SVG_TRANSFORM_ROTATE = 4;
	public static short SVG_TRANSFORM_SKEWX = 5;
	public static short SVG_TRANSFORM_SKEWY = 6;
	public short type {get;private set;}
	public SVGMatrix matrix {get;set;}
	public float angle {get;private set;}
	public void setTranslate(float tx, float ty) {}
	public void setScale(float sx, float sy) {}
	public void setRotate(float angle, float cx, float cy) {}
	public void setSkewX(float angle) {}
	public void setSkewY(float angle) {}
}

}