/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
     $.fx.speeds._default = 1000;;
    $("#dialog").dialog( {autoOpen: false, show: "blind", hide: "explode"});
    $("#opener").click(function (e)
    {
        $("#dialog").dialog("open");
        return false;
    });
};
