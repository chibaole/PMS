//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamlStaticHelperNamespace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "15.0.0.0")]
    internal class _XamlStaticHelper {
        
        private static System.WeakReference schemaContextField;
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> assemblyListField;
        
        internal static System.Xaml.XamlSchemaContext SchemaContext {
            get {
                System.Xaml.XamlSchemaContext xsc = null;
                if ((schemaContextField != null)) {
                    xsc = ((System.Xaml.XamlSchemaContext)(schemaContextField.Target));
                    if ((xsc != null)) {
                        return xsc;
                    }
                }
                if ((AssemblyList.Count > 0)) {
                    xsc = new System.Xaml.XamlSchemaContext(AssemblyList);
                }
                else {
                    xsc = new System.Xaml.XamlSchemaContext();
                }
                schemaContextField = new System.WeakReference(xsc);
                return xsc;
            }
        }
        
        internal static System.Collections.Generic.IList<System.Reflection.Assembly> AssemblyList {
            get {
                if ((assemblyListField == null)) {
                    assemblyListField = LoadAssemblies();
                }
                return assemblyListField;
            }
        }
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> LoadAssemblies() {
            System.Collections.Generic.IList<System.Reflection.Assembly> assemblyList = new System.Collections.Generic.List<System.Reflection.Assembly>();
            assemblyList.Add(Load("Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364" +
                        "e35"));
            assemblyList.Add(Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b7" +
                        "7a5c561934e089"));
            assemblyList.Add(Load("System.ServiceModel.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "31bf3856ad364e35"));
            assemblyList.Add(Load("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56193" +
                        "4e089"));
            assemblyList.Add(Load("System.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08" +
                        "9"));
            assemblyList.Add(Load("Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08" +
                        "9"));
            assemblyList.Add(Load("EntityFramework.SqlServer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5" +
                        "c561934e089"));
            assemblyList.Add(Load("ISMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("PMS.BLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("PMS.BLLRedis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("PMS.DALSQLSer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("PMS.IBLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("PMS.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("SMSFactory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("System.Collections.Concurrent, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Collections, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.ComponentModel.Annotations, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.EventBasedAsync, Version=4.0.0.0, Culture=neutral, PublicKe" +
                        "yToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Contracts, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Debug, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Tools, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Tracing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.Dynamic.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Globalization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.IO, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Linq.Expressions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Linq.Parallel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Linq.Queryable, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Net.NetworkInformation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Net.Requests, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.ObjectModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Reflection, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                        "a3a"));
            assemblyList.Add(Load("System.Reflection.Emit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Emit.ILGeneration, Version=4.0.0.0, Culture=neutral, PublicKeyT" +
                        "oken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Emit.Lightweight, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Resources.ResourceManager, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Runtime.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices.WindowsRuntime, Version=4.0.0.0, Culture=neutral, " +
                        "PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Json, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Primitives, Version=4.0.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Principal, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Duplex, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.NetTcp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Primitives, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Text.RegularExpressions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("System.Threading.Tasks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Threading.Tasks.Parallel, Version=4.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Xml.ReaderWriter, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Xml.XDocument, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Xml.XmlSerializer, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(System.Reflection.Assembly.GetExecutingAssembly());
            return assemblyList;
        }
        
        private static System.Reflection.Assembly Load(string assemblyNameVal) {
            System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assemblyNameVal);
            byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
            System.Reflection.Assembly asm = null;
            try {
                asm = System.Reflection.Assembly.Load(assemblyName.FullName);
            }
            catch (System.Exception ) {
                System.Reflection.AssemblyName shortName = new System.Reflection.AssemblyName(assemblyName.Name);
                if ((publicKeyToken != null)) {
                    shortName.SetPublicKeyToken(publicKeyToken);
                }
                asm = System.Reflection.Assembly.Load(shortName);
            }
            return asm;
        }
    }
}
