﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Field_Sales_System.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Database=proximoDB;Data Source=us-cdbr-azure-central-a.cloudapp.net;User Id=b5fb2" +
            "61919a40c;Password=aff5b96f")]
        public string dbServerConnectionString {
            get {
                return ((string)(this["dbServerConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Database=proximoImageDB;Data Source=us-cdbr-azure-central-a.cloudapp.net;User Id=" +
            "bc4e805be8c5fd;Password=f4c3aed8")]
        public string imageServerConnection {
            get {
                return ((string)(this["imageServerConnection"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Database=proximoProductDB;Data Source=us-cdbr-azure-central-a.cloudapp.net;User I" +
            "d=b94529907982dc;Password=b8a53004")]
        public string productDetailsServerConnection {
            get {
                return ((string)(this["productDetailsServerConnection"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Database=proximoOrderDB;Data Source=us-cdbr-azure-central-a.cloudapp.net;User Id=" +
            "b6a04a80481541;Password=e0db281b")]
        public string orderServerConnection {
            get {
                return ((string)(this["orderServerConnection"]));
            }
        }
    }
}
