﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTAnalyzer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    public sealed partial class MappingSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MappingSettings defaultInstance = ((MappingSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MappingSettings())));
        
        public static MappingSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomMapPath {
            get {
                return ((string)(this["CustomMapPath"]));
            }
            set {
                this["CustomMapPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseParishBoundaries {
            get {
                return ((bool)(this["UseParishBoundaries"]));
            }
            set {
                this["UseParishBoundaries"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HideScaleBar {
            get {
                return ((bool)(this["HideScaleBar"]));
            }
            set {
                this["HideScaleBar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IncludePartials {
            get {
                return ((bool)(this["IncludePartials"]));
            }
            set {
                this["IncludePartials"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GoogleAPI {
            get {
                return ((string)(this["GoogleAPI"]));
            }
            set {
                this["GoogleAPI"] = value;
            }
        }
    }
}
