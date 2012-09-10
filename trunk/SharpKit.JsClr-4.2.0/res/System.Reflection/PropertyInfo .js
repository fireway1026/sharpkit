/*Generated by SharpKit 5 v4.29.8000*/
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var System$Reflection$PropertyInfo=
{
    fullname:"System.Reflection.PropertyInfo",
    baseTypeName:"System.Reflection.MemberInfo",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this._PropertyType = null;
            this._IsStatic = false;
            this._Getter = null;
            this._Setter = null;
            System.Reflection.MemberInfo.ctor.call(this);
        },
        GetBaseMember:function()
        {
            return null;
        },
        GetValue:function(obj,indexes)
        {
            if(this._Getter == null)
                throw $CreateException(new System.Exception.ctor$$String("Property " + this._Name + " doesn\'t have a getter"),new Error());
            var value=this._Getter.apply(obj,(indexes != null?indexes: []));
            return value;
        },
        SetValue:function(obj,value,indexes)
        {
            if(this._Setter == null)
                throw $CreateException(new System.Exception.ctor$$String("Property " + this._Name + " doesn\'t have a setter"),new Error());
            if(indexes == null || indexes.length == 0)
            {
                this._Setter.call(obj,value);
            }
            else
            {
                var arr=new Array(indexes);
                arr.push(value);
                this._Setter.apply(obj,(indexes != null?indexes: []));
            }
        },
        Name$$:"System.String",
        get_Name:function()
        {
            return this._Name;
        },
        PropertyType$$:"SharpKit.JavaScript.Private.JsImplType",
        get_PropertyType:function()
        {
            return this._PropertyType;
        }
    }
};
JsTypes.push(System$Reflection$PropertyInfo);
