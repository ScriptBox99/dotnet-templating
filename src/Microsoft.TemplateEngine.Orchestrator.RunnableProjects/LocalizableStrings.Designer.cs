﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TemplateEngine.Orchestrator.RunnableProjects {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TemplateEngine.Orchestrator.RunnableProjects.LocalizableStrings", typeof(LocalizableStrings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; could not be parsed as a regular expression.
        /// </summary>
        internal static string Authoring_InvalidRegex {
            get {
                return ResourceManager.GetString("Authoring_InvalidRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-bool DataType was specified for a regexMatch type symbol.
        /// </summary>
        internal static string Authoring_NonBoolDataTypeForRegexMatch {
            get {
                return ResourceManager.GetString("Authoring_NonBoolDataTypeForRegexMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Source &apos;{0}&apos; in template does not exist..
        /// </summary>
        internal static string Authoring_SourceDoesNotExist {
            get {
                return ResourceManager.GetString("Authoring_SourceDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Source location &apos;{0}&apos; is outside the specified install source location..
        /// </summary>
        internal static string Authoring_SourceIsOutsideInstallSource {
            get {
                return ResourceManager.GetString("Authoring_SourceIsOutsideInstallSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Source must be a directory, but &apos;{0}&apos; is a file..
        /// </summary>
        internal static string Authoring_SourceMustBeDirectory {
            get {
                return ResourceManager.GetString("Authoring_SourceMustBeDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Source path relative to install location: &apos;{0}&apos;.
        /// </summary>
        internal static string Authoring_SourcePathRelativeToInstall {
            get {
                return ResourceManager.GetString("Authoring_SourcePathRelativeToInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template: &apos;{0}&apos;.
        /// </summary>
        internal static string Authoring_TemplateNameDisplay {
            get {
                return ResourceManager.GetString("Authoring_TemplateNameDisplay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template: &apos;{0}&apos; - Template root is outside the specified install source location..
        /// </summary>
        internal static string Authoring_TemplateRootOutsideInstallSource {
            get {
                return ResourceManager.GetString("Authoring_TemplateRootOutsideInstallSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     TemplateSourceRoot = &apos;{0}&apos;.
        /// </summary>
        internal static string Authoring_TemplateSourceRoot {
            get {
                return ResourceManager.GetString("Authoring_TemplateSourceRoot", resourceCulture);
            }
        }
    }
}
