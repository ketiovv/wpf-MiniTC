﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniTC.Resources {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MiniTC.Resources.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy &gt;&gt;.
        /// </summary>
        public static string CopyButtonString {
            get {
                return ResourceManager.GetString("CopyButtonString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drive.
        /// </summary>
        public static string DriveLabelString {
            get {
                return ResourceManager.GetString("DriveLabelString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open directory.
        /// </summary>
        public static string ErrorMessageCannotOpen {
            get {
                return ResourceManager.GetString("ErrorMessageCannotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error copying directory.
        /// </summary>
        public static string ErrorMessageCopyDir {
            get {
                return ResourceManager.GetString("ErrorMessageCopyDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error copying file.
        /// </summary>
        public static string ErrorMessageCopyFile {
            get {
                return ResourceManager.GetString("ErrorMessageCopyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination folder is a subfolder of the source folder.
        /// </summary>
        public static string ErrorMessageCopyToSelf {
            get {
                return ResourceManager.GetString("ErrorMessageCopyToSelf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path.
        /// </summary>
        public static string PathLabelString {
            get {
                return ResourceManager.GetString("PathLabelString", resourceCulture);
            }
        }
    }
}