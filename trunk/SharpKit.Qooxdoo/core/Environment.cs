// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.core
{
    /// <summary>
	/// <para>This class is the single point to access all settings that may be different
	/// in different environments. This contains e.g. the browser name, engine
	/// version but also qooxdoo or application specific settings.</para>
	/// <para>Its public API can be found in its four main methods. One pair of methods
	/// is used to check the synchronous values of the environment. The other pair
	/// of methods is used for asynchronous checks.</para>
	/// <para>The most often used method should be <see cref="Get"/>, which returns the
	/// current value for a given environment check.</para>
	/// <para>All qooxdoo settings can be changed via the generator&#8217;s config. See the manual
	/// for more details about the environment key in the config. As you can see
	/// from the methods API, there is no way to override an existing key. So if you
	/// need to change a qooxdoo setting, you have to use the generator to do so.</para>
	/// <para>The following table shows the available checks. If you are
	/// interested in more details, check the reference to the implementation of
	/// each check. Please do not use those check implementations directly, as the
	/// Environment class comes with a smart caching feature.</para>
	/// 
	/// 
	/// 
	/// Synchronous checks
	/// 
	/// 
	/// 
	/// Key
	/// Type
	/// Example
	/// Details
	/// 
	/// 
	/// browser
	/// 
	/// 
	/// browser.documentmodeInteger0
	/// <see cref="qx.bom.client.Browser.GetDocumentMode"/>
	/// 
	/// 
	/// browser.nameString chrome 
	/// <see cref="qx.bom.client.Browser.GetName"/>
	/// 
	/// 
	/// browser.quirksmodeBooleanfalse
	/// <see cref="qx.bom.client.Browser.GetQuirksMode"/>
	/// 
	/// 
	/// browser.versionString11.0
	/// <see cref="qx.bom.client.Browser.GetVersion"/>
	/// 
	/// 
	/// runtime
	/// 
	/// 
	/// runtime.name String  node.js 
	/// <see cref="qx.bom.client.Runtime.GetName"/>
	/// 
	/// 
	/// css
	/// 
	/// 
	/// css.borderradiusString or nullborderRadius
	/// <see cref="qx.bom.client.Css.GetBorderRadius"/>
	/// 
	/// 
	/// css.borderimageString or nullWebkitBorderImage
	/// <see cref="qx.bom.client.Css.GetBorderImage"/>
	/// 
	/// 
	/// css.borderimage.standardsyntaxBoolean or nulltrue
	/// <see cref="qx.bom.client.Css.GetBorderImageSyntax"/>
	/// 
	/// 
	/// css.boxmodelStringcontent
	/// <see cref="qx.bom.client.Css.GetBoxModel"/>
	/// 
	/// 
	/// css.boxshadowString or nullboxShadow
	/// <see cref="qx.bom.client.Css.GetBoxShadow"/>
	/// 
	/// 
	/// css.gradient.linearString or null-moz-linear-gradient
	/// <see cref="qx.bom.client.Css.GetLinearGradient"/>
	/// 
	/// 
	/// css.gradient.filterBooleantrue
	/// <see cref="qx.bom.client.Css.GetFilterGradient"/>
	/// 
	/// 
	/// css.gradient.radialString or null-moz-radial-gradient
	/// <see cref="qx.bom.client.Css.GetRadialGradient"/>
	/// 
	/// 
	/// css.gradient.legacywebkitBooleanfalse
	/// <see cref="qx.bom.client.Css.GetLegacyWebkitGradient"/>
	/// 
	/// 
	/// css.placeholderBooleantrue
	/// <see cref="qx.bom.client.Css.GetPlaceholder"/>
	/// 
	/// 
	/// css.textoverflowString or nulltextOverflow
	/// <see cref="qx.bom.client.Css.GetTextOverflow"/>
	/// 
	/// 
	/// css.rgbaBooleantrue
	/// <see cref="qx.bom.client.Css.GetRgba"/>
	/// 
	/// 
	/// css.usermodifyString or nullWebkitUserModify
	/// <see cref="qx.bom.client.Css.GetUserModify"/>
	/// 
	/// 
	/// css.appearanceString or nullWebkitAppearance
	/// <see cref="qx.bom.client.Css.GetAppearance"/>
	/// 
	/// 
	/// css.floatString or nullcssFloat
	/// <see cref="qx.bom.client.Css.GetFloat"/>
	/// 
	/// 
	/// css.userselectString or nullWebkitUserSelect
	/// <see cref="qx.bom.client.Css.GetUserSelect"/>
	/// 
	/// 
	/// css.userselect.noneString or null-moz-none
	/// <see cref="qx.bom.client.Css.GetUserSelectNone"/>
	/// 
	/// 
	/// css.boxsizingString or nullboxSizing
	/// <see cref="qx.bom.client.Css.GetBoxSizing"/>
	/// 
	/// 
	/// css.animationObject or null{end-event: "webkitAnimationEnd", keyframes: "@-webkit-keyframes", play-state: null, name: "WebkitAnimation"}
	/// <see cref="qx.bom.client.CssAnimation.GetSupport"/>
	/// 
	/// 
	/// css.animation.requestframeString or nullmozRequestAnimationFrame
	/// <see cref="qx.bom.client.CssAnimation.GetRequestAnimationFrame"/>
	/// 
	/// 
	/// css.transformObject or null{3d: true, origin: "WebkitTransformOrigin", name: "WebkitTransform", style: "WebkitTransformStyle", perspective: "WebkitPerspective", perspective-origin: "WebkitPerspectiveOrigin", backface-visibility: "WebkitBackfaceVisibility"}
	/// <see cref="qx.bom.client.CssTransform.GetSupport"/>
	/// 
	/// 
	/// css.transform.3dBooleanfalse
	/// <see cref="qx.bom.client.CssTransform.Get3D"/>
	/// 
	/// 
	/// css.inlineblockString or nullinline-block
	/// <see cref="qx.bom.client.Css.GetInlineBlock"/>
	/// 
	/// 
	/// css.opacityBooleantrue
	/// <see cref="qx.bom.client.Css.GetOpacity"/>
	/// 
	/// 
	/// deprecated since 2.1: css.overflowxyBooleantrue
	/// <see cref="qx.bom.client.Css.GetOverflowXY"/>
	/// 
	/// 
	/// css.textShadowBooleantrue
	/// <see cref="qx.bom.client.Css.GetTextShadow"/>
	/// 
	/// 
	/// css.textShadow.filterBooleantrue
	/// <see cref="qx.bom.client.Css.GetFilterTextShadow"/>
	/// 
	/// 
	/// device
	/// 
	/// 
	/// device.nameStringpc
	/// <see cref="qx.bom.client.Device.GetName"/>
	/// 
	/// 
	/// device.typeStringmobile
	/// <see cref="qx.bom.client.Device.GetType"/>
	/// 
	/// 
	/// ecmascript
	/// 
	/// 
	/// ecmascript.error.stacktraceString or nullstack
	/// <see cref="qx.bom.client.EcmaScript.GetStackTrace"/>
	/// 
	/// 
	/// ecmascript.array.indexofBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayIndexOf"/>
	/// 
	/// 
	/// ecmascript.array.lastindexofBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayLastIndexOf"/>
	/// 
	/// 
	/// ecmascript.array.foreachBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayForEach"/>
	/// 
	/// 
	/// ecmascript.array.filterBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayFilter"/>
	/// 
	/// 
	/// ecmascript.array.mapBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayMap"/>
	/// 
	/// 
	/// ecmascript.array.someBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArraySome"/>
	/// 
	/// 
	/// ecmascript.array.everyBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayEvery"/>
	/// 
	/// 
	/// ecmascript.array.reduceBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayReduce"/>
	/// 
	/// 
	/// ecmascript.array.reducerightBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetArrayReduceRight"/>
	/// 
	/// 
	/// ecmascript.function.bindBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetFunctionBind"/>
	/// 
	/// 
	/// ecmascript.object.keysBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetObjectKeys"/>
	/// 
	/// 
	/// ecmascript.date.nowBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetDateNow"/>
	/// 
	/// 
	/// ecmascript.error.toStringBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetErrorToString"/>
	/// 
	/// 
	/// ecmascript.string.trimBooleantrue
	/// <see cref="qx.bom.client.EcmaScript.GetStringTrim"/>
	/// 
	/// 
	/// engine
	/// 
	/// 
	/// engine.nameStringwebkit
	/// <see cref="qx.bom.client.Engine.GetName"/>
	/// 
	/// 
	/// engine.versionString534.24
	/// <see cref="qx.bom.client.Engine.GetVersion"/>
	/// 
	/// 
	/// event
	/// 
	/// 
	/// event.pointerBooleantrue
	/// <see cref="qx.bom.client.Event.GetPointer"/>
	/// 
	/// 
	/// event.mspointerBooleantrue
	/// <see cref="qx.bom.client.Event.GetMsPointer"/>
	/// 
	/// 
	/// event.touchBooleanfalse
	/// <see cref="qx.bom.client.Event.GetTouch"/>
	/// 
	/// 
	/// event.helpBooleanfalse
	/// <see cref="qx.bom.client.Event.GetHelp"/>
	/// 
	/// 
	/// event.hashchangeBooleantrue
	/// <see cref="qx.bom.client.Event.GetHashChange"/>
	/// 
	/// 
	/// html
	/// 
	/// 
	/// html.audioBooleantrue
	/// <see cref="qx.bom.client.Html.GetAudio"/>
	/// 
	/// 
	/// html.audio.mp3String""
	/// <see cref="qx.bom.client.Html.GetAudioMp3"/>
	/// 
	/// 
	/// html.audio.oggString"maybe"
	/// <see cref="qx.bom.client.Html.GetAudioOgg"/>
	/// 
	/// 
	/// html.audio.wavString"probably"
	/// <see cref="qx.bom.client.Html.GetAudioWav"/>
	/// 
	/// 
	/// html.audio.auString"maybe"
	/// <see cref="qx.bom.client.Html.GetAudioAu"/>
	/// 
	/// 
	/// html.audio.aifString"probably"
	/// <see cref="qx.bom.client.Html.GetAudioAif"/>
	/// 
	/// 
	/// html.canvasBooleantrue
	/// <see cref="qx.bom.client.Html.GetCanvas"/>
	/// 
	/// 
	/// html.classlistBooleantrue
	/// <see cref="qx.bom.client.Html.GetClassList"/>
	/// 
	/// 
	/// html.geolocationBooleantrue
	/// <see cref="qx.bom.client.Html.GetGeoLocation"/>
	/// 
	/// 
	/// html.storage.localBooleantrue
	/// <see cref="qx.bom.client.Html.GetLocalStorage"/>
	/// 
	/// 
	/// html.storage.sessionBooleantrue
	/// <see cref="qx.bom.client.Html.GetSessionStorage"/>
	/// 
	/// 
	/// html.storage.userdataBooleantrue
	/// <see cref="qx.bom.client.Html.GetUserDataStorage"/>
	/// 
	/// 
	/// html.svgBooleantrue
	/// <see cref="qx.bom.client.Html.GetSvg"/>
	/// 
	/// 
	/// html.videoBooleantrue
	/// <see cref="qx.bom.client.Html.GetVideo"/>
	/// 
	/// 
	/// html.video.h264String"probably"
	/// <see cref="qx.bom.client.Html.GetVideoH264"/>
	/// 
	/// 
	/// html.video.oggString""
	/// <see cref="qx.bom.client.Html.GetVideoOgg"/>
	/// 
	/// 
	/// html.video.webmString"maybe"
	/// <see cref="qx.bom.client.Html.GetVideoWebm"/>
	/// 
	/// 
	/// html.vmlBooleanfalse
	/// <see cref="qx.bom.client.Html.GetVml"/>
	/// 
	/// 
	/// html.webworkerBooleantrue
	/// <see cref="qx.bom.client.Html.GetWebWorker"/>
	/// 
	/// html.filereaderBooleantrue
	/// <see cref="qx.bom.client.Html.GetFileReader"/>
	/// 
	/// 
	/// html.xpathBooleantrue
	/// <see cref="qx.bom.client.Html.GetXPath"/>
	/// 
	/// 
	/// html.xulBooleantrue
	/// <see cref="qx.bom.client.Html.GetXul"/>
	/// 
	/// 
	/// html.consoleBooleantrue
	/// <see cref="qx.bom.client.Html.GetConsole"/>
	/// 
	/// 
	/// html.element.containsBooleantrue
	/// <see cref="qx.bom.client.Html.GetContains"/>
	/// 
	/// 
	/// html.element.compareDocumentPositionBooleantrue
	/// <see cref="qx.bom.client.Html.GetCompareDocumentPosition"/>
	/// 
	/// 
	/// html.element.textContentBooleantrue
	/// <see cref="qx.bom.client.Html.GetTextContent"/>
	/// 
	/// 
	/// html.image.naturaldimensionsBooleantrue
	/// <see cref="qx.bom.client.Html.GetNaturalDimensions"/>
	/// 
	/// 
	/// html.history.stateBooleantrue
	/// <see cref="qx.bom.client.Html.GetHistoryState"/>
	/// 
	/// 
	/// XML
	/// 
	/// 
	/// xml.implementationBooleantrue
	/// <see cref="qx.bom.client.Xml.GetImplementation"/>
	/// 
	/// 
	/// xml.domparserBooleantrue
	/// <see cref="qx.bom.client.Xml.GetDomParser"/>
	/// 
	/// 
	/// xml.selectsinglenodeBooleanfalse
	/// <see cref="qx.bom.client.Xml.GetSelectSingleNode"/>
	/// 
	/// 
	/// xml.selectnodesBooleanfalse
	/// <see cref="qx.bom.client.Xml.GetSelectNodes"/>
	/// 
	/// 
	/// xml.getelementsbytagnamensBooleantrue
	/// <see cref="qx.bom.client.Xml.GetElementsByTagNameNS"/>
	/// 
	/// 
	/// xml.dompropertiesBooleanfalse
	/// <see cref="qx.bom.client.Xml.GetDomProperties"/>
	/// 
	/// 
	/// xml.attributensBooleantrue
	/// <see cref="qx.bom.client.Xml.GetAttributeNS"/>
	/// 
	/// 
	/// xml.createelementnsBooleantrue
	/// <see cref="qx.bom.client.Xml.GetCreateElementNS"/>
	/// 
	/// 
	/// xml.createnodeBooleanfalse
	/// <see cref="qx.bom.client.Xml.GetCreateNode"/>
	/// 
	/// 
	/// xml.getqualifieditemBooleanfalse
	/// <see cref="qx.bom.client.Xml.GetQualifiedItem"/>
	/// 
	/// 
	/// Stylesheets
	/// 
	/// 
	/// html.stylesheet.createstylesheetBooleanfalse
	/// <see cref="qx.bom.client.Stylesheet.GetCreateStyleSheet"/>
	/// 
	/// 
	/// html.stylesheet.insertruleBooleantrue
	/// <see cref="qx.bom.client.Stylesheet.GetInsertRule"/>
	/// 
	/// 
	/// html.stylesheet.deleteruleBooleantrue
	/// <see cref="qx.bom.client.Stylesheet.GetDeleteRule"/>
	/// 
	/// 
	/// html.stylesheet.addimportBooleanfalse
	/// <see cref="qx.bom.client.Stylesheet.GetAddImport"/>
	/// 
	/// 
	/// html.stylesheet.removeimportBooleanfalse
	/// <see cref="qx.bom.client.Stylesheet.GetRemoveImport"/>
	/// 
	/// 
	/// io
	/// 
	/// 
	/// io.maxrequestsInteger4
	/// <see cref="qx.bom.client.Transport.GetMaxConcurrentRequestCount"/>
	/// 
	/// 
	/// io.sslBooleanfalse
	/// <see cref="qx.bom.client.Transport.GetSsl"/>
	/// 
	/// 
	/// io.xhrStringxhr
	/// <see cref="qx.bom.client.Transport.GetXmlHttpRequest"/>
	/// 
	/// 
	/// locale
	/// 
	/// 
	/// localeStringde
	/// <see cref="qx.bom.client.Locale.GetLocale"/>
	/// 
	/// 
	/// locale.variantStringde
	/// <see cref="qx.bom.client.Locale.GetVariant"/>
	/// 
	/// 
	/// os
	/// 
	/// 
	/// os.nameStringosx
	/// <see cref="qx.bom.client.OperatingSystem.GetName"/>
	/// 
	/// 
	/// os.versionString10.6
	/// <see cref="qx.bom.client.OperatingSystem.GetVersion"/>
	/// 
	/// 
	/// os.scrollBarOverlayedBooleanfalse
	/// <see cref="qx.bom.client.Scroll.ScrollBarOverlayed"/>
	/// 
	/// 
	/// phonegap
	/// 
	/// 
	/// phonegapBooleanfalse
	/// <see cref="qx.bom.client.PhoneGap.GetPhoneGap"/>
	/// 
	/// 
	/// phonegap.notificationBooleanfalse
	/// <see cref="qx.bom.client.PhoneGap.GetNotification"/>
	/// 
	/// 
	/// plugin
	/// 
	/// 
	/// plugin.divxBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetDivX"/>
	/// 
	/// 
	/// plugin.divx.versionString
	/// <see cref="qx.bom.client.Plugin.GetDivXVersion"/>
	/// 
	/// 
	/// plugin.flashBooleantrue
	/// <see cref="qx.bom.client.Flash.IsAvailable"/>
	/// 
	/// 
	/// plugin.flash.expressBooleantrue
	/// <see cref="qx.bom.client.Flash.GetExpressInstall"/>
	/// 
	/// 
	/// plugin.flash.strictsecurityBooleantrue
	/// <see cref="qx.bom.client.Flash.GetStrictSecurityModel"/>
	/// 
	/// 
	/// plugin.flash.versionString10.2.154
	/// <see cref="qx.bom.client.Flash.GetVersion"/>
	/// 
	/// 
	/// plugin.gearsBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetGears"/>
	/// 
	/// 
	/// plugin.activexBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetActiveX"/>
	/// 
	/// 
	/// plugin.skypeBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetSkype"/>
	/// 
	/// 
	/// plugin.pdfBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetPdf"/>
	/// 
	/// 
	/// plugin.pdf.versionString
	/// <see cref="qx.bom.client.Plugin.GetPdfVersion"/>
	/// 
	/// 
	/// plugin.quicktimeBooleantrue
	/// <see cref="qx.bom.client.Plugin.GetQuicktime"/>
	/// 
	/// 
	/// plugin.quicktime.versionString7.6
	/// <see cref="qx.bom.client.Plugin.GetQuicktimeVersion"/>
	/// 
	/// 
	/// plugin.silverlightBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetSilverlight"/>
	/// 
	/// 
	/// plugin.silverlight.versionString
	/// <see cref="qx.bom.client.Plugin.GetSilverlightVersion"/>
	/// 
	/// 
	/// plugin.windowsmediaBooleanfalse
	/// <see cref="qx.bom.client.Plugin.GetWindowsMedia"/>
	/// 
	/// 
	/// plugin.windowsmedia.versionString
	/// <see cref="qx.bom.client.Plugin.GetWindowsMediaVersion"/>
	/// 
	/// 
	/// qx
	/// 
	/// 
	/// qx.allowUrlSettingsBooleantrue
	/// default: false
	/// 
	/// 
	/// qx.allowUrlVariantsBooleantrue
	/// default: false
	/// 
	/// 
	/// qx.applicationStringname.space
	/// default: &lt;&lt;application name&gt;&gt;
	/// 
	/// 
	/// qx.aspectsBooleanfalse
	/// default: false
	/// 
	/// 
	/// qx.debugBooleantrue
	/// default: true
	/// 
	/// 
	/// qx.debug.databindingBooleanfalse
	/// default: false
	/// 
	/// 
	/// qx.debug.disposeBooleanfalse
	/// default: false
	/// 
	/// 
	/// qx.debug.dispose.levelInteger0
	/// default: 0
	/// 
	/// 
	/// qx.debug.ioBooleantrue
	/// default: false
	/// 
	/// 
	/// 
	/// qx.debug.io.remoteBooleantrue
	/// default: false
	/// 
	/// 
	/// 
	/// qx.debug.io.remote.dataBooleantrue
	/// default: false
	/// 
	/// 
	/// qx.debug.property.levelInteger0
	/// default: 0
	/// 
	/// 
	/// qx.debug.ui.queueBooleantrue
	/// default: true
	/// 
	/// 
	/// qx.dynamicmousewheelBooleantrue
	/// default: true
	/// 
	/// 
	/// qx.dynlocaleBooleantrue
	/// default: true
	/// 
	/// 
	/// qx.globalErrorHandlingBooleantrue
	/// default: true
	/// 
	/// 
	/// qx.mobile.emulatetouchBooleanfalse
	/// default: false
	/// 
	/// 
	/// qx.mobile.nativescrollBooleanfalse
	/// default: false
	/// 
	/// 
	/// qx.optimization.basecallsBooleantrue
	/// true if the corresp. optimize key is set in the config
	/// 
	/// 
	/// qx.optimization.commentsBooleantrue
	/// true if the corresp. optimize key is set in the config
	/// 
	/// 
	/// qx.optimization.privatesBooleantrue
	/// true if the corresp. optimize key is set in the config
	/// 
	/// 
	/// qx.optimization.stringsBooleantrue
	/// true if the corresp. optimize key is set in the config
	/// 
	/// 
	/// qx.optimization.variablesBooleantrue
	/// true if the corresp. optimize key is set in the config
	/// 
	/// 
	/// qx.optimization.variantsBooleantrue
	/// true if the corresp. optimize key is set in the config
	/// 
	/// 
	/// qx.revisionString27348
	/// 
	/// 
	/// qx.themeStringqx.theme.Modern
	/// default: &lt;&lt;initial theme name&gt;&gt;
	/// 
	/// 
	/// qx.versionString2.1.1
	/// 
	/// 
	/// qx.blankpageStringURI to blank.html page
	/// 
	/// 
	/// module
	/// 
	/// 
	/// module.databindingBooleantrue
	/// default: true
	/// 
	/// 
	/// module.loggerBooleantrue
	/// default: true
	/// 
	/// 
	/// module.propertyBooleantrue
	/// default: true
	/// 
	/// 
	/// module.eventsBooleantrue
	/// default: true
	/// 
	/// 
	/// Asynchronous checks
	/// 
	/// 
	/// 
	/// html.dataurlBooleantrue
	/// <see cref="qx.bom.client.Html.GetDataUrl"/>
	/// 
	/// 
	/// 
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.core.Environment", OmitOptionalParameters = true, Export = false)]
    public partial class Environment 
    {
		#region Methods

		public Environment() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a check to the environment class. If there is already a check
		/// added for the given key, the add will be ignored.</para>
		/// </summary>
		/// <param name="key">The key for the check e.g. html.featurexyz.</param>
		/// <param name="check">It could be either a function or a simple value. The function should be responsible for the check and should return the result of the check.</param>
		[JsMethod(Name = "add")]
		public static void Add(string key, object check) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an asynchronous check to the environment. If there is already a check
		/// added for the given key, the add will be ignored.</para>
		/// </summary>
		/// <param name="key">The key of the check e.g. html.featureabc</param>
		/// <param name="check">A function which should check for a specific environment setting in an asynchronous way. The method should take two arguments. First one is the callback and the second one is the context.</param>
		[JsMethod(Name = "addAsync")]
		public static void AddAsync(string key, Action<object> check) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Takes a given map containing the check names as keys and converts
		/// the map to an array only containing the values for check evaluating
		/// to true. This is especially handy for conditional
		/// includes of mixins.</para>
		/// </summary>
		/// <param name="map">A map containing check names as keys and values.</param>
		/// <returns>An array containing the values.</returns>
		[JsMethod(Name = "filter")]
		public static JsArray Filter(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The default accessor for the checks. It returns the value the current
		/// environment has for the given key. The key could be something like
		/// &#8220;qx.debug&#8221;, &#8220;css.textoverflow&#8221; or &#8220;io.ssl&#8221;. A complete list of
		/// checks can be found in the class comment of this class.</para>
		/// <para>Please keep in mind that the result is cached. If you want to run the
		/// check function again in case something could have been changed, take a
		/// look at the <see cref="InvalidateCacheKey"/> function.</para>
		/// </summary>
		/// <param name="key">The name of the check you want to query.</param>
		/// <returns>The stored value depending on the given key. (Details in the class doc)</returns>
		[JsMethod(Name = "get")]
		public static object Get(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Invokes the callback as soon as the check has been done. If no check
		/// could be found, a warning will be printed.</para>
		/// </summary>
		/// <param name="key">The key of the asynchronous check.</param>
		/// <param name="callback">The function to call as soon as the check is done. The function should have one argument which is the result of the check.</param>
		/// <param name="self">The context to use when invoking the callback.</param>
		[JsMethod(Name = "getAsync")]
		public static void GetAsync(string key, Action<object> callback, object self) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Invalidates the cache for the given key.</para>
		/// </summary>
		/// <param name="key">The key of the check.</param>
		[JsMethod(Name = "invalidateCacheKey")]
		public static void InvalidateCacheKey(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the proper value dependent on the check for the given key.</para>
		/// </summary>
		/// <param name="key">The name of the check the select depends on.</param>
		/// <param name="values">A map containing the values which should be returned in any case. The &#8220;default&#8221; key could be used as a catch all statement.</param>
		/// <returns>The value which is stored in the map for the given check of the key.</returns>
		[JsMethod(Name = "select")]
		public static object Select(string key, object values) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Selects the proper function dependent on the asynchronous check.</para>
		/// </summary>
		/// <param name="key">The key for the async check.</param>
		/// <param name="values">A map containing functions. The map keys should contain all possibilities which could be returned by the given check key. The &#8220;default&#8221; key could be used as a catch all statement. The called function will get one parameter, the result of the query.</param>
		/// <param name="self">The context which should be used when calling the method in the values map.</param>
		[JsMethod(Name = "selectAsync")]
		public static void SelectAsync(string key, object values, object self) { throw new NotImplementedException(); }

		#endregion Methods
    }
}