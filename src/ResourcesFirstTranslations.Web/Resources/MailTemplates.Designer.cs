﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResourcesFirstTranslations.Web.Resources {
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
    public class MailTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MailTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ResourcesFirstTranslations.Web.Resources.MailTemplates", typeof(MailTemplates).Assembly);
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
        ///   Looks up a localized string similar to Welcome {0}!
        ///
        ///Your new user account:
        ///
        ///Username: {1}
        ///Password: {2}
        ///
        ///Please go to
        ///
        ///{3}
        ///
        ///and change the auto-generated password to one of your choosing.
        ///
        ///The administration team.
        /// </summary>
        public static string NewUserBodyFormat {
            get {
                return ResourceManager.GetString("NewUserBodyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Translator Welcome.
        /// </summary>
        public static string NewUserSubjectFormat {
            get {
                return ResourceManager.GetString("NewUserSubjectFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your translation password has been reset.
        ///
        ///Password: {0}
        ///
        ///Please go to
        ///
        ///{1}
        ///
        ///and change the auto-generated password to one of your choosing.
        ///
        ///The administration team.
        /// </summary>
        public static string PasswordResetBodyFormat {
            get {
                return ResourceManager.GetString("PasswordResetBodyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Translation Password Has Been Reset.
        /// </summary>
        public static string PasswordResetSubjectFormat {
            get {
                return ResourceManager.GetString("PasswordResetSubjectFormat", resourceCulture);
            }
        }
    }
}
