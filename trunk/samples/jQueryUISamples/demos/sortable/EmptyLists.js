/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("ul.droptrue").sortable( {connectWith: "ul"});
    $("ul.dropfalse").sortable( {connectWith: "ul", dropOnEmpty: false});
    $("#sortable1, #sortable2, #sortable3").disableSelection();
};