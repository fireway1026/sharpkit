
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:47:55 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/indexeddb/IDBObjectStore.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de
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

namespace SharpKit.Html.storage
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class IDBObjectStore
{
	public  JsString name {get; set; }
	public  IDBAny keyPath {get; set; }
	public  DOMStringList indexNames {get; set; }
	public  IDBTransaction transaction {get; set; }
	public  bool autoIncrement {get; set; }
	public  IDBRequest put(object value) { return default(IDBRequest); }
	public  IDBRequest put(object value, IDBKey key) { return default(IDBRequest); }
	public  IDBRequest add(object value) { return default(IDBRequest); }
	public  IDBRequest add(object value, IDBKey key) { return default(IDBRequest); }
	public  IDBRequest delete(IDBKeyRange keyRange) { return default(IDBRequest); }
	public  IDBRequest delete(IDBKey key) { return default(IDBRequest); }
	public  IDBRequest clear() { return default(IDBRequest); }
	public  IDBRequest get(IDBKeyRange key) { return default(IDBRequest); }
	public  IDBRequest get(IDBKey key) { return default(IDBRequest); }
	public  IDBRequest openCursor() { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKeyRange range) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKeyRange range, string direction) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKey key) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKey key, string direction) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKeyRange range, int direction) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKey key, int direction) { return default(IDBRequest); }
	public  IDBIndex createIndex(string name, string[] keyPath) { return default(IDBIndex); }
	public  IDBIndex createIndex(string name, string[] keyPath, object options) { return default(IDBIndex); }
	public  IDBIndex index(string name) { return default(IDBIndex); }
	public  void deleteIndex(string name) {}
	public  IDBRequest count() { return default(IDBRequest); }
	public  IDBRequest count(IDBKeyRange range) { return default(IDBRequest); }
	public  IDBRequest count(IDBKey key) { return default(IDBRequest); }
}

}