﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILGPU.Algorithms.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ILGPU.Algorithms.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to This function does not currently support ArrayViews of length &gt; int.MaxValue..
        /// </summary>
        internal static string NotSupportedArrayView64 {
            get {
                return ResourceManager.GetString("NotSupportedArrayView64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported cuRAND API platform..
        /// </summary>
        internal static string NotSupportedCuRandAPI {
            get {
                return ResourceManager.GetString("NotSupportedCuRandAPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The allocation of type &apos;{0}&apos; is not correctly aligned. Requires &apos;{1}&apos; byte alignment but was allocated at byte offset &apos;{2}&apos;..
        /// </summary>
        internal static string TempViewManagerUnalignedAllocation {
            get {
                return ResourceManager.GetString("TempViewManagerUnalignedAllocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} view is larger than the {1} view..
        /// </summary>
        internal static string ViewOutOfRange {
            get {
                return ResourceManager.GetString("ViewOutOfRange", resourceCulture);
            }
        }
    }
}
