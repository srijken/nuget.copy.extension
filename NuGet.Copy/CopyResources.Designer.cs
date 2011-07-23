﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Copy {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CopyResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CopyResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Copy.CopyResources", typeof(CopyResources).Assembly);
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
        ///   Looks up a localized string similar to The API key for the destination (optional if already set).
        /// </summary>
        internal static string ApiKeyDescription {
            get {
                return ResourceManager.GetString("ApiKeyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copies a package from one source to another source.
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The location to copy the package..
        /// </summary>
        internal static string DestinationDescription {
            get {
                return ResourceManager.GetString("DestinationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A list of package sources to use for finding the package..
        /// </summary>
        internal static string SourceDescription {
            get {
                return ResourceManager.GetString("SourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the id of a package and the destination feed to copy the package to. Optionally specify a source if not the official to copy from..
        /// </summary>
        internal static string UsageDescription {
            get {
                return ResourceManager.GetString("UsageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to packageId [options].
        /// </summary>
        internal static string UsageSummary {
            get {
                return ResourceManager.GetString("UsageSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version of the package to install..
        /// </summary>
        internal static string VersionDescription {
            get {
                return ResourceManager.GetString("VersionDescription", resourceCulture);
            }
        }
    }
}
