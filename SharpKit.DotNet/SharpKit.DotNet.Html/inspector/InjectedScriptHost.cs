/*******************************************************************************************************
  This file was created/modified by Herv� PHILIPPE alchiweb[at]gmail.com
********************************************************************************************************

  Copyright (C) 2013 Herv� PHILIPPE, Web: http://xmadevlab.net

  Project based on the files auto generated with the tool "WebIDLParser"
  Copyright (C) 2013 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.ComponentModel;

namespace SharpKit.DotNet.Html.inspector
{

    using SharpKit.JavaScript;
    using SharpKit.DotNet.JavaScript;
    using SharpKit.DotNet.Html.fileapi;
    using SharpKit.DotNet.Html.html.shadow;
    using SharpKit.DotNet.Html.html.track;
    using SharpKit.DotNet.Html.inspector;
    using SharpKit.DotNet.Html.loader.appcache;
    using SharpKit.DotNet.Html.battery;
    using SharpKit.DotNet.Html.gamepad;
    using SharpKit.DotNet.Html.geolocation;
    using SharpKit.DotNet.Html.indexeddb;
    using SharpKit.DotNet.Html.intents;
    using SharpKit.DotNet.Html.mediasource;
    using SharpKit.DotNet.Html.mediastream;
    using SharpKit.DotNet.Html.networkinfo;
    using SharpKit.DotNet.Html.notifications;
    using SharpKit.DotNet.Html.proximity;
    using SharpKit.DotNet.Html.quota;
    using SharpKit.DotNet.Html.speech;
    using SharpKit.DotNet.Html.webaudio;
    using SharpKit.DotNet.Html.webdatabase;
    using SharpKit.DotNet.Html.plugins;
    using SharpKit.DotNet.Html.storage;
    using SharpKit.DotNet.Html.svg;
    using SharpKit.DotNet.Html.workers;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "InjectedScriptHost")]
    public partial class InjectedScriptHost
    {
        [JsMethod(Name = "clearConsoleMessages")]
        public void ClearConsoleMessages() { }
        [JsMethod(Name = "copyText")]
        public void CopyText(JsString text) { }
        [JsMethod(Name = "inspect")]
        public void Inspect(object objectId, object hints) { }
        [JsMethod(Name = "inspectedObject")]
        public object InspectedObject(int num) { return default(object); }
        [JsMethod(Name = "internalConstructorName")]
        public object InternalConstructorName(object @object) { return default(object); }
        [JsMethod(Name = "isHTMLAllCollection")]
        public bool IsHTMLAllCollection(object @object) { return default(bool); }
        [JsMethod(Name = "type")]
        public JsString Type(object @object) { return default(JsString); }
        [JsMethod(Name = "functionDetails")]
        public object FunctionDetails(object @object) { return default(object); }
        [JsMethod(Name = "getInternalProperties")]
        public Array GetInternalProperties(object @object) { return default(Array); }
        [JsMethod(Name = "getEventListeners")]
        public Array GetEventListeners(Node node) { return default(Array); }
        [JsMethod(Name = "databaseId")]
        public JsString DatabaseId(object database) { return default(JsString); }
        [JsMethod(Name = "storageId")]
        public JsString StorageId(object storage) { return default(JsString); }
        [JsMethod(Name = "evaluate")]
        public object Evaluate(JsString text) { return default(object); }
    }

}