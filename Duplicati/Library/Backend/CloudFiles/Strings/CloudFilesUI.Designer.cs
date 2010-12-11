﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Backend.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CloudFilesUI {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CloudFilesUI() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Backend.Strings.CloudFilesUI", typeof(CloudFilesUI).Assembly);
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
        ///   Looks up a localized string similar to The container does not exist, do you want to create it?.
        /// </summary>
        internal static string CreateMissingContainer {
            get {
                return ResourceManager.GetString("CreateMissingContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter your CloudFiles API Access Key.
        ///You may click the link to the right
        ///to open the CloudFiles login page, and retrieve it..
        /// </summary>
        internal static string EmptyAPIKeyError {
            get {
                return ResourceManager.GetString("EmptyAPIKeyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter your CloudFiles user ID.
        ///You may click the link to the right
        ///to open the CloudFiles login page, and retrieve it..
        /// </summary>
        internal static string EmptyCloudFilesIDError {
            get {
                return ResourceManager.GetString("EmptyCloudFilesIDError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter a name for the Container.
        ///You must use a unique name for each backup.
        ///You may enter any name you like..
        /// </summary>
        internal static string EmptyContainerNameError {
            get {
                return ResourceManager.GetString("EmptyContainerNameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to On this page you can select where to store the backup data..
        /// </summary>
        internal static string PageDescription {
            get {
                return ResourceManager.GetString("PageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup storage options.
        /// </summary>
        internal static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
    }
}
