/*@Generated by SharpKit v4.21.8000*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
AfterCompilation(function()
{
	System.IO.Path.ctor();
});

if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.IO.Path",
    baseTypeName:"System.Object",
    staticDefinition:{
        cctor:function()
        {
            System.IO.Path.AltDirectorySeparatorChar = '/';
            System.IO.Path.DirectorySeparatorChar = '\\';
            System.IO.Path.InvalidFileNameChars = ['"','<','>','|','\0','\x0001','\x0002','\x0003','\x0004','\x0005','\x0006','\a','\b','\t','\n','\v','\f','\r','\x000e','\x000f','\x0010','\x0011','\x0012','\x0013','\x0014','\x0015','\x0016','\x0017','\x0018','\x0019','\x001a','\x001b','\x001c','\x001d','\x001e','\x001f',':','*','?','\\','/'];
            System.IO.Path.InvalidPathChars = ['"','<','>','|','\0','\x0001','\x0002','\x0003','\x0004','\x0005','\x0006','\a','\b','\t','\n','\v','\f','\r','\x000e','\x000f','\x0010','\x0011','\x0012','\x0013','\x0014','\x0015','\x0016','\x0017','\x0018','\x0019','\x001a','\x001b','\x001c','\x001d','\x001e','\x001f'];
            System.IO.Path.MaxPath = 260;
            System.IO.Path.PathSeparator = ';';
            System.IO.Path.RealInvalidPathChars = ['"','<','>','|','\0','\x0001','\x0002','\x0003','\x0004','\x0005','\x0006','\a','\b','\t','\n','\v','\f','\r','\x000e','\x000f','\x0010','\x0011','\x0012','\x0013','\x0014','\x0015','\x0016','\x0017','\x0018','\x0019','\x001a','\x001b','\x001c','\x001d','\x001e','\x001f'];
            System.IO.Path.VolumeSeparatorChar = ':';
        }
        ,
        MAX_DIRECTORY_PATH:0xf8,
        MAX_PATH:260,
        ChangeExtension:function(path,extension)
        {
            if(path == null)
            {
                return null;
            }
            System.IO.Path.CheckInvalidPathChars(path);
            var str=path;
            var length=path.get_Length();
            while(--length >= 0)
            {
                var ch=path.get_Chars(length);
                if(ch == '.')
                {
                    str = path.Substring$$Int32$$Int32(0,length);
                    break;
                }
                if(((ch == System.IO.Path.DirectorySeparatorChar) || (ch == System.IO.Path.AltDirectorySeparatorChar)) || (ch == System.IO.Path.VolumeSeparatorChar))
                {
                    break;
                }
            }
            if((extension == null) || (path.get_Length() == 0))
            {
                return str;
            }
            if((extension.get_Length() == 0) || (extension.get_Chars(0) != '.'))
            {
                str = str + ".";
            }
            return (str + extension);
        }
        ,
        CharArrayStartsWithOrdinal:function(array,numChars,compareTo,ignoreCase)
        {
            if(numChars < compareTo.get_Length())
            {
                return false;
            }
            if(ignoreCase)
            {
                var str=new System.String.ctor$$Char$Array$$Int32$$Int32(array,0,compareTo.get_Length());
                return compareTo.Equals$$String$$StringComparison(str,5);
            }
            for(var i=0;i < compareTo.get_Length();i++)
            {
                if(array[i] != compareTo.get_Chars(i))
                {
                    return false;
                }
            }
            return true;
        }
        ,
        CheckInvalidPathChars:function(path)
        {
            for(var i=0;i < path.get_Length();i++)
            {
                var num2=path.charCodeAt(i);
                if(((num2 == 0x22) || (num2 == 60)) || (((num2 == 0x3e) || (num2 == 0x7c)) || (num2 < 0x20)))
                {
                    throw new System.ArgumentException.ctor$$String(System.Environment.GetResourceString("Argument_InvalidPathChars"));
                }
            }
        }
        
        ,
        CheckSearchPattern:function(searchPattern)
        {
            var num;
            while((num = searchPattern.IndexOf$$String$$StringComparison("..",4)) != -1)
            {
                if((num + 2) == searchPattern.get_Length())
                {
                    throw new System.ArgumentException.ctor$$String(System.Environment.GetResourceString("Arg_InvalidSearchPattern"));
                }
                if((searchPattern.get_Chars(num + 2) == System.IO.Path.DirectorySeparatorChar) || (searchPattern.get_Chars(num + 2) == System.IO.Path.AltDirectorySeparatorChar))
                {
                    throw new System.ArgumentException.ctor$$String(System.Environment.GetResourceString("Arg_InvalidSearchPattern"));
                }
                searchPattern = searchPattern.Substring$$Int32(num + 2);
            }
        }
        ,
        Combine:function(path1,path2)
        {
            if((path1 == null) || (path2 == null))
            {
                throw new System.ArgumentNullException.ctor$$String((path1 == null)?"path1":"path2");
            }
            System.IO.Path.CheckInvalidPathChars(path1);
            System.IO.Path.CheckInvalidPathChars(path2);
            if(path2.get_Length() == 0)
            {
                return path1;
            }
            if(path1.get_Length() == 0)
            {
                return path2;
            }
            if(System.IO.Path.IsPathRooted(path2))
            {
                return path2;
            }
            var ch=path1.get_Chars(path1.get_Length() - 1);
            if(((ch != System.IO.Path.DirectorySeparatorChar) && (ch != System.IO.Path.AltDirectorySeparatorChar)) && (ch != System.IO.Path.VolumeSeparatorChar))
            {
                return (path1 + System.IO.Path.DirectorySeparatorChar + path2);
            }
            return (path1 + path2);
        }
        ,
        FixupPath:function(path)
        {
            return System.IO.Path.NormalizePath(path,false);
        }
        
        ,
        GetDirectoryName:function(path)
        {
            if(path != null)
            {
                System.IO.Path.CheckInvalidPathChars(path);
                path = System.IO.Path.FixupPath(path);
                var rootLength=System.IO.Path.GetRootLength(path);
                if(path.get_Length() > rootLength)
                {
                    var length=path.get_Length();
                    if(length == rootLength)
                    {
                        return null;
                    }
                    while(((length > rootLength) && (path.get_Chars(--length) != System.IO.Path.DirectorySeparatorChar)) && (path.get_Chars(length) != System.IO.Path.AltDirectorySeparatorChar))
                    {
                    }
                    return path.Substring$$Int32$$Int32(0,length);
                }
            }
            return null;
        }
        ,
        GetExtension:function(path)
        {
            if(path == null)
            {
                return null;
            }
            System.IO.Path.CheckInvalidPathChars(path);
            var length=path.get_Length();
            var startIndex=length;
            while(--startIndex >= 0)
            {
                var ch=path.get_Chars(startIndex);
                if(ch == '.')
                {
                    if(startIndex != (length - 1))
                    {
                        return path.Substring$$Int32$$Int32(startIndex,length - startIndex);
                    }
                    return System.String.Empty;
                }
                if(((ch == System.IO.Path.DirectorySeparatorChar) || (ch == System.IO.Path.AltDirectorySeparatorChar)) || (ch == System.IO.Path.VolumeSeparatorChar))
                {
                    break;
                }
            }
            return System.String.Empty;
        }
        ,
        GetFileName:function(path)
        {
            if(path != null)
            {
                System.IO.Path.CheckInvalidPathChars(path);
                var length=path.get_Length();
                var num2=length;
                while(--num2 >= 0)
                {
                    var ch=path.get_Chars(num2);
                    if(((ch == System.IO.Path.DirectorySeparatorChar) || (ch == System.IO.Path.AltDirectorySeparatorChar)) || (ch == System.IO.Path.VolumeSeparatorChar))
                    {
                        return path.Substring$$Int32$$Int32(num2 + 1,(length - num2) - 1);
                    }
                }
            }
            return path;
        }
        ,
        GetFileNameWithoutExtension:function(path)
        {
            path = System.IO.Path.GetFileName(path);
            if(path == null)
            {
                return null;
            }
            var length=path.LastIndexOf$$Char('.');
            if(length == -1)
            {
                return path;
            }
            return path.Substring$$Int32$$Int32(0,length);
        }
        ,
        GetFullPath:function(path)
        {
            var fullPathInternal=System.IO.Path.GetFullPathInternal(path);
            return fullPathInternal;
        }
        ,
        GetFullPathInternal:function(path)
        {
            if(path == null)
            {
                throw new System.ArgumentNullException.ctor$$String("path");
            }
            return System.IO.Path.NormalizePath(path,true);
        }
        ,
        GetInvalidFileNameChars:function()
        {
            return System.IO.Path.InvalidFileNameChars;
        }
        
        ,
        GetInvalidPathChars:function()
        {
            return System.IO.Path.RealInvalidPathChars;
        }
        
        ,
        GetPathRoot:function(path)
        {
            if(path == null)
            {
                return null;
            }
            path = System.IO.Path.FixupPath(path);
            return path.Substring$$Int32$$Int32(0,System.IO.Path.GetRootLength(path));
        }
        ,
        GetRandomFileName:function()
        {
            throw new System.NotSupportedException.ctor();
        }
        
        ,
        GetRootLength:function(path)
        {
            System.IO.Path.CheckInvalidPathChars(path);
            var num=0;
            var length=path.get_Length();
            if((length >= 1) && System.IO.Path.IsDirectorySeparator(path.get_Chars(0)))
            {
                num = 1;
                if((length >= 2) && System.IO.Path.IsDirectorySeparator(path.get_Chars(1)))
                {
                    num = 2;
                    var num3=2;
                    while((num < length) && (((path.get_Chars(num) != System.IO.Path.DirectorySeparatorChar) && (path.get_Chars(num) != System.IO.Path.AltDirectorySeparatorChar)) || (--num3 > 0)))
                    {
                        num++;
                    }
                }
                return num;
            }
            if((length >= 2) && (path.get_Chars(1) == System.IO.Path.VolumeSeparatorChar))
            {
                num = 2;
                if((length >= 3) && System.IO.Path.IsDirectorySeparator(path.get_Chars(2)))
                {
                    num++;
                }
            }
            return num;
        }
        ,
        GetTempFileName:function()
        {
            throw new System.NotSupportedException.ctor();
        }
        
        ,
        GetTempPath:function()
        {
            throw new System.NotSupportedException.ctor();
        }
        
        ,
        HasExtension:function(path)
        {
            if(path != null)
            {
                System.IO.Path.CheckInvalidPathChars(path);
                var length=path.get_Length();
                while(--length >= 0)
                {
                    var ch=path.get_Chars(length);
                    if(ch == '.')
                    {
                        return (length != (path.get_Length() - 1));
                    }
                    if(((ch == System.IO.Path.DirectorySeparatorChar) || (ch == System.IO.Path.AltDirectorySeparatorChar)) || (ch == System.IO.Path.VolumeSeparatorChar))
                    {
                        break;
                    }
                }
            }
            return false;
        }
        ,
        InternalCombine:function(path1,path2)
        {
            if((path1 == null) || (path2 == null))
            {
                throw new System.ArgumentNullException.ctor$$String((path1 == null)?"path1":"path2");
            }
            System.IO.Path.CheckInvalidPathChars(path1);
            System.IO.Path.CheckInvalidPathChars(path2);
            if(path2.get_Length() == 0)
            {
                throw new System.ArgumentException.ctor$$String$$String(System.Environment.GetResourceString("Argument_PathEmpty"),"path2");
            }
            if(System.IO.Path.IsPathRooted(path2))
            {
                throw new System.ArgumentException.ctor$$String$$String(System.Environment.GetResourceString("Arg_Path2IsRooted"),"path2");
            }
            var length=path1.get_Length();
            if(length == 0)
            {
                return path2;
            }
            var ch=path1.get_Chars(length - 1);
            if(((ch != System.IO.Path.DirectorySeparatorChar) && (ch != System.IO.Path.AltDirectorySeparatorChar)) && (ch != System.IO.Path.VolumeSeparatorChar))
            {
                return (path1 + System.IO.Path.DirectorySeparatorChar + path2);
            }
            return (path1 + path2);
        }
        ,
        IsDirectorySeparator:function(c)
        {
            if(c != System.IO.Path.DirectorySeparatorChar)
            {
                return (c == System.IO.Path.AltDirectorySeparatorChar);
            }
            return true;
        }
        ,
        IsPathRooted:function(path)
        {
            if(path != null)
            {
                System.IO.Path.CheckInvalidPathChars(path);
                var length=path.get_Length();
                if(((length >= 1) && ((path.get_Chars(0) == System.IO.Path.DirectorySeparatorChar) || (path.get_Chars(0) == System.IO.Path.AltDirectorySeparatorChar))) || ((length >= 2) && (path.get_Chars(1) == System.IO.Path.VolumeSeparatorChar)))
                {
                    return true;
                }
            }
            return false;
        }
        ,
        NormalizePath:function(path,fullCheck)
        {
            return System.IO.Path.NormalizePathSlow(path,fullCheck);
        }
        
        ,
        NormalizePathSlow:function(path,fullCheck)
        {
            return path;
        }
        
    }
    ,
    assemblyName:"SharpKit.JsClr-4.1.0",
    Kind:"Class",
    definition:{
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
        
    }
}
);
