/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("#datepicker").kendoDatePicker( {change: onChange, close: onClose, open: onOpen});
};
function onOpen()
{
    kendoConsole.log("Open");
};
function onClose()
{
    kendoConsole.log("Close");
};
function onChange()
{
    kendoConsole.log("Change :: " + kendo.toString(this.value(), "d"));
};