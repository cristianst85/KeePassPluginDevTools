// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace KeePassPluginDevTools.PlgxTools {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PlgxConfiguration {
        
        private PlgxConfigurationPrerequisites prerequisitesField;
        
        private PlgxConfigurationBuildCommands buildCommandsField;
        
        /// <remarks/>
        public PlgxConfigurationPrerequisites Prerequisites {
            get {
                return this.prerequisitesField;
            }
            set {
                this.prerequisitesField = value;
            }
        }
        
        /// <remarks/>
        public PlgxConfigurationBuildCommands BuildCommands {
            get {
                return this.buildCommandsField;
            }
            set {
                this.buildCommandsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PlgxConfigurationPrerequisites {
        
        private string keePassVersionField;
        
        private string dotNetVersionField;
        
        private PlgxConfigurationPrerequisitesOS oSField;
        
        private bool oSSpecifiedField;
        
        private PlgxConfigurationPrerequisitesPointerSize pointerSizeField;
        
        private bool pointerSizeSpecifiedField;
        
        /// <remarks/>
        public string KeePassVersion {
            get {
                return this.keePassVersionField;
            }
            set {
                this.keePassVersionField = value;
            }
        }
        
        /// <remarks/>
        public string DotNetVersion {
            get {
                return this.dotNetVersionField;
            }
            set {
                this.dotNetVersionField = value;
            }
        }
        
        /// <remarks/>
        public PlgxConfigurationPrerequisitesOS OS {
            get {
                return this.oSField;
            }
            set {
                this.oSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool OSSpecified {
            get {
                return this.oSSpecifiedField;
            }
            set {
                this.oSSpecifiedField = value;
            }
        }
        
        /// <remarks/>
        public PlgxConfigurationPrerequisitesPointerSize PointerSize {
            get {
                return this.pointerSizeField;
            }
            set {
                this.pointerSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool PointerSizeSpecified {
            get {
                return this.pointerSizeSpecifiedField;
            }
            set {
                this.pointerSizeSpecifiedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum PlgxConfigurationPrerequisitesOS {
        
        /// <remarks/>
        Windows,
        
        /// <remarks/>
        Unix,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum PlgxConfigurationPrerequisitesPointerSize {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PlgxConfigurationBuildCommands {
        
        private string preBuildField;
        
        private string postBuildField;
        
        /// <remarks/>
        public string PreBuild {
            get {
                return this.preBuildField;
            }
            set {
                this.preBuildField = value;
            }
        }
        
        /// <remarks/>
        public string PostBuild {
            get {
                return this.postBuildField;
            }
            set {
                this.postBuildField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PlgxExtras {
        
        private PlgxExtrasItem itemField;
        
        /// <remarks/>
        public PlgxExtrasItem Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PlgxExtrasItem {
        
        private string sourceField;
        
        private string destinationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Destination {
            get {
                return this.destinationField;
            }
            set {
                this.destinationField = value;
            }
        }
    }
}
