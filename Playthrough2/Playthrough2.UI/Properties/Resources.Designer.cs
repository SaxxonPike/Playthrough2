﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Playthrough2.UI.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Playthrough2.UI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} v{1}.{2}.
        /// </summary>
        internal static string ConfigurationFormTitle {
            get {
                return ResourceManager.GetString("ConfigurationFormTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Logo16 {
            get {
                object obj = ResourceManager.GetObject("Logo16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restart.
        /// </summary>
        internal static string StartButtonRestartText {
            get {
                return ResourceManager.GetString("StartButtonRestartText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start.
        /// </summary>
        internal static string StartButtonStartText {
            get {
                return ResourceManager.GetString("StartButtonStartText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WavePipeManager did not shut down cleanly.
        ///{0}.
        /// </summary>
        internal static string WavePipeManagerShutdownFailure {
            get {
                return ResourceManager.GetString("WavePipeManagerShutdownFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WavePipeManager could not start the route.
        ///{0}.
        /// </summary>
        internal static string WavePipeManagerStartFailure {
            get {
                return ResourceManager.GetString("WavePipeManagerStartFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WavePipeManager could not stop the route.
        ///{0}.
        /// </summary>
        internal static string WavePipeManagerStopFailure {
            get {
                return ResourceManager.GetString("WavePipeManagerStopFailure", resourceCulture);
            }
        }
    }
}
