//@AutoGenerated
var NamespaceSample = {Namespace1 : {}, Namespace2 : {}};
function btn_onclick()
{
	var c1 = new NamespaceSample.Namespace1.SomeClass();
	alert("new NamespaceSample.Namespace1.SomeClass() returned:" + c1);
	var c2 = new NamespaceSample.Namespace2.SomeClass();
	alert("new NamespaceSample.Namespace2.SomeClass() returned:" + c2);
}
NamespaceSample.Namespace1.SomeClass = function()
{
}
NamespaceSample.Namespace2.SomeClass = function()
{
}
