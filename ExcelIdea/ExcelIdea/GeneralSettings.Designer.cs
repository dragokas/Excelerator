﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcelIdea {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class GeneralSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GeneralSettings defaultInstance = ((GeneralSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GeneralSettings())));
        
        public static GeneralSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("file")]
        public string ExcelDataSource {
            get {
                return ((string)(this["ExcelDataSource"]));
            }
            set {
                this["ExcelDataSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CCInBackground {
            get {
                return ((bool)(this["CCInBackground"]));
            }
            set {
                this["CCInBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\ExcelIdea\\bin")]
        public string CCPath {
            get {
                return ((string)(this["CCPath"]));
            }
            set {
                this["CCPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OpenResultFile {
            get {
                return ((bool)(this["OpenResultFile"]));
            }
            set {
                this["OpenResultFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Bob\\Desktop")]
        public string DefaultResultDir {
            get {
                return ((string)(this["DefaultResultDir"]));
            }
            set {
                this["DefaultResultDir"] = value;
            }
        }
    }
}
