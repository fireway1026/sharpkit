/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#editor").kendoEditor();
    var editor = $("#editor").data("kendoEditor");
    var setValue = function ()
    {
        editor.value($("#value").val());
    };
    $("#get").click(function ()
    {
        window.alert(editor.value());
    });
    $("#set").click(setValue);
};
