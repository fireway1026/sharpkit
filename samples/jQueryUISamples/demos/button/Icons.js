/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $(".demo button:first").button(
    {
        icons:{primary:"ui-icon-locked"},
        text:false
    }).next().button(
    {
        icons:{primary:"ui-icon-locked"}
    }).next().button(
    {
        icons:{primary:"ui-icon-gear",secondary:"ui-icon-triangle-1-s"}
    }).next().button(
    {
        icons:{primary:"ui-icon-gear",secondary:"ui-icon-triangle-1-s"},
        text:false
    });
};
