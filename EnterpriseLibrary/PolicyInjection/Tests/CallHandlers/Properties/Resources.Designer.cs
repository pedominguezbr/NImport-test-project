﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers.Tests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers.Tests.Properti" +
                            "es.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Base counter for the average seconds / call counter..
        /// </summary>
        internal static string AverageCallDurationBaseCounterHelp {
            get {
                return ResourceManager.GetString("AverageCallDurationBaseCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Measures the average seconds / call for the monitored methods..
        /// </summary>
        internal static string AverageCallDurationCounterHelp {
            get {
                return ResourceManager.GetString("AverageCallDurationCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Counts the number of calls made per second..
        /// </summary>
        internal static string CallsPerSecondCounterHelp {
            get {
                return ResourceManager.GetString("CallsPerSecondCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Counts the number of exceptions thrown per second..
        /// </summary>
        internal static string ExceptionsPerSecondCounterHelp {
            get {
                return ResourceManager.GetString("ExceptionsPerSecondCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Counts calls made to methods that the call handler wraps..
        /// </summary>
        internal static string NumberOfCallsCounterHelp {
            get {
                return ResourceManager.GetString("NumberOfCallsCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Counts the number of exceptions thrown by the monitored methods..
        /// </summary>
        internal static string NumberOfExceptionsCounterHelp {
            get {
                return ResourceManager.GetString("NumberOfExceptionsCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This category is used by the unit tests for the PerformanceCounterCallHandler class included with the Enterprise Library Policy Injection Application Block. If you do not wish to run these tests, the category can be safely removed..
        /// </summary>
        internal static string TestPerformanceCounterCategoryHelp {
            get {
                return ResourceManager.GetString("TestPerformanceCounterCategoryHelp", resourceCulture);
            }
        }
    }
}
