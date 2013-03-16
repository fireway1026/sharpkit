// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.controller
{
    /// <summary>
	/// Tree Controller
	/// <para>General idea</para>
	/// <para>The tree controller is the controller made for the <see cref="qx.ui.tree.Tree"/>
	/// widget in qooxdoo. Therefore, it is responsible for creating and adding the
	/// tree folders to the tree given as target.</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Synchronize the model and the target</item>
	/// <item>Label and icon are bindable</item>
	/// <item>Takes care of the selection</item>
	/// <item>Passes on the options used by the bindings</item>
	/// </list
	/// <para>Usage</para>
	/// <para>As model, you can use every qooxdoo widget structure having one property,
	/// which is a data array holding the children of the current node. There can
	/// be as many additional as you like.
	/// You need to specify a model, a target, a child path and a label path to
	/// make the controller work.</para>
	/// <para>Cross reference</para>
	/// <list type="bullet">
	/// <item>If you want to bind single values, use <see cref="qx.data.controller.Object"/></item>
	/// <item>If you want to bind a list like widget, use <see cref="qx.data.controller.List"/></item>
	/// <item>If you want to bin a form widget, use <see cref="qx.data.controller.Form"/></item>
	/// </list
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.controller.Tree", OmitOptionalParameters = true, Export = false)]
    public partial class Tree : qx.core.Object, qx.data.controller.ISelection
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeModelEvent;

		/// <summary>
		/// Fired on change of the property <see cref="Target"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeTargetEvent;

		/// <summary>
		/// Fired on change of the property <see cref="Selection"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeSelectionEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The name of the property, where the children are stored in the model.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "childPath", NativeField = true)]
		public string ChildPath { get; set; }

		/// <summary>
		/// <para>Delegation object, which can have one ore more function defined by the
		/// <see cref="IControllerDelegate"/> interface.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "delegate", NativeField = true)]
		public object Delegate { get; set; }

		/// <summary>
		/// <para>A map containing the options for the icon binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "iconOptions", NativeField = true)]
		public object IconOptions { get; set; }

		/// <summary>
		/// <para>The name of the property, where the source for the tree folders icon
		/// is stored in the model classes.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "iconPath", NativeField = true)]
		public string IconPath { get; set; }

		/// <summary>
		/// <para>A map containing the options for the label binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "labelOptions", NativeField = true)]
		public object LabelOptions { get; set; }

		/// <summary>
		/// <para>The name of the property, where the value for the tree folders label
		/// is stored in the model classes.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "labelPath", NativeField = true)]
		public string LabelPath { get; set; }

		/// <summary>
		/// <para>The root element of the data.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public qx.core.Object Model { get; set; }

		/// <summary>
		/// <para>The tree to bind the data to.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "target", NativeField = true)]
		public object Target { get; set; }

		/// <summary>
		/// <para>Data array containing the selected model objects. This property can be
		/// manipulated directly which means that a push to the selection will also
		/// select the corresponding element in the target.</para>
		/// </summary>
		[JsProperty(Name = "selection", NativeField = true)]
		public qx.data.Array Selection { get; set; }

		#endregion Properties

		#region Methods

		public Tree() { throw new NotImplementedException(); }

		/// <param name="model">The root element of the model, which holds the data.</param>
		/// <param name="target">The target widgets which should be a tree.</param>
		/// <param name="childPath">The name of the property in the model, which holds the data array containing the children.</param>
		/// <param name="labelPath">The name of the property in the model, which holds the value to be displayed as the label of the tree items.</param>
		public Tree(qx.core.Object model = null, qx.ui.tree.Tree target = null, string childPath = null, string labelPath = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper method for binding the default properties (label and icon) from
		/// the model to the target widget.</para>
		/// <para>This method should only be called in the
		/// <see cref="qx.data.controller.IControllerDelegate.BindItem"/> function
		/// implemented by the <see cref="Delegate"/> property.</para>
		/// </summary>
		/// <param name="treeNode">The tree node corresponding to the model node.</param>
		/// <param name="modelNode">The model node holding the data.</param>
		[JsMethod(Name = "bindDefaultProperties")]
		public void BindDefaultProperties(qx.ui.tree.core.AbstractTreeItem treeNode, qx.core.Object modelNode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper method for binding a given property from the model to the target
		/// widget.
		/// This method should only be called in the
		/// <see cref="qx.data.controller.IControllerDelegate.BindItem"/> function
		/// implemented by the <see cref="Delegate"/> property.</para>
		/// </summary>
		/// <param name="sourcePath">The path to the property in the model. If you use an empty string, the whole model item will be bound.</param>
		/// <param name="targetPath">The name of the property in the target widget.</param>
		/// <param name="options">The options to use for the binding.</param>
		/// <param name="targetWidget">The target widget.</param>
		/// <param name="modelNode">The model node which should be bound to the target.</param>
		[JsMethod(Name = "bindProperty")]
		public void BindProperty(string sourcePath, string targetPath, object options, qx.ui.tree.core.AbstractTreeItem targetWidget, object modelNode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper method for binding a given property from the target widget to
		/// the model.
		/// This method should only be called in the
		/// <see cref="qx.data.controller.IControllerDelegate.BindItem"/> function
		/// implemented by the <see cref="Delegate"/> property.</para>
		/// </summary>
		/// <param name="targetPath">The path to the property in the model.</param>
		/// <param name="sourcePath">The name of the property in the target widget.</param>
		/// <param name="options">The options to use for the binding.</param>
		/// <param name="sourceWidget">The source widget.</param>
		/// <param name="modelNode">The model node which should be bound to the target.</param>
		[JsMethod(Name = "bindPropertyReverse")]
		public void BindPropertyReverse(string targetPath, string sourcePath, object options, qx.ui.tree.core.AbstractTreeItem sourceWidget, object modelNode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property childPath.</para>
		/// </summary>
		[JsMethod(Name = "getChildPath")]
		public string GetChildPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delegate.</para>
		/// </summary>
		[JsMethod(Name = "getDelegate")]
		public object GetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconOptions.</para>
		/// </summary>
		[JsMethod(Name = "getIconOptions")]
		public object GetIconOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconPath.</para>
		/// </summary>
		[JsMethod(Name = "getIconPath")]
		public string GetIconPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property labelOptions.</para>
		/// </summary>
		[JsMethod(Name = "getLabelOptions")]
		public object GetLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property labelPath.</para>
		/// </summary>
		[JsMethod(Name = "getLabelPath")]
		public string GetLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public qx.core.Object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property target.</para>
		/// </summary>
		[JsMethod(Name = "getTarget")]
		public object GetTarget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property childPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property childPath.</param>
		[JsMethod(Name = "initChildPath")]
		public void InitChildPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delegate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delegate.</param>
		[JsMethod(Name = "initDelegate")]
		public void InitDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconOptions.</param>
		[JsMethod(Name = "initIconOptions")]
		public void InitIconOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconPath.</param>
		[JsMethod(Name = "initIconPath")]
		public void InitIconPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property labelOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property labelOptions.</param>
		[JsMethod(Name = "initLabelOptions")]
		public void InitLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property labelPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property labelPath.</param>
		[JsMethod(Name = "initLabelPath")]
		public void InitLabelPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property target
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property target.</param>
		[JsMethod(Name = "initTarget")]
		public void InitTarget(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property childPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetChildPath")]
		public void ResetChildPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delegate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelegate")]
		public void ResetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconOptions")]
		public void ResetIconOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconPath")]
		public void ResetIconPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property labelOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabelOptions")]
		public void ResetLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property labelPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabelPath")]
		public void ResetLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property target.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTarget")]
		public void ResetTarget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property childPath.</para>
		/// </summary>
		/// <param name="value">New value for property childPath.</param>
		[JsMethod(Name = "setChildPath")]
		public void SetChildPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delegate.</para>
		/// </summary>
		/// <param name="value">New value for property delegate.</param>
		[JsMethod(Name = "setDelegate")]
		public void SetDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconOptions.</para>
		/// </summary>
		/// <param name="value">New value for property iconOptions.</param>
		[JsMethod(Name = "setIconOptions")]
		public void SetIconOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconPath.</para>
		/// </summary>
		/// <param name="value">New value for property iconPath.</param>
		[JsMethod(Name = "setIconPath")]
		public void SetIconPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property labelOptions.</para>
		/// </summary>
		/// <param name="value">New value for property labelOptions.</param>
		[JsMethod(Name = "setLabelOptions")]
		public void SetLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property labelPath.</para>
		/// </summary>
		/// <param name="value">New value for property labelPath.</param>
		[JsMethod(Name = "setLabelPath")]
		public void SetLabelPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(qx.core.Object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property target.</para>
		/// </summary>
		/// <param name="value">New value for property target.</param>
		[JsMethod(Name = "setTarget")]
		public void SetTarget(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Getter for the selection list.</para>
		/// </summary>
		/// <returns>The current selection.</returns>
		[JsMethod(Name = "getSelection")]
		public qx.data.IListData GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selection.</param>
		[JsMethod(Name = "initSelection")]
		public void InitSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the selection to its default value.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Setter for the selection.</para>
		/// </summary>
		/// <param name="value">The data of the selection.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.data.IListData value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}