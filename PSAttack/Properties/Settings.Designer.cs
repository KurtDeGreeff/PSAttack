
namespace PSAttack.Properties {
    
    
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
		[global::System.Configuration.DefaultSettingValueAttribute(">IYBVQT3bAnFnw6V4Dub4zrFfB0jhcqL6CJWlSoIQf48sV782nem4a0Zbx8e1lcJA")]

        public string encryptionKey {
            get {
                return ((string)(this["encryptionKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute(">yxJFOHdFmAkkamESwoSECHyuzHtYJRfCtVUxbVQqahnAQnPAUGSdBnkqyOGHNFvU")]

        public string valueStore {
            get {
                return ((string)(this["valueStore"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute(">MdLCt")]

        public string encFileExtension {
            get {
                return ((string)(this["encFileExtension"]));
            }
        }
    }
}