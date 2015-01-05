using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("RestSharp.Portable")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
#if PORTABLE
[assembly: AssemblyProduct("RestSharp.Portable (PCL)")]
#elif WINDOWS_PHONE
[assembly: AssemblyProduct("RestSharp.Portable (WP8)")]
#elif SILVERLIGHT
[assembly: AssemblyProduct("RestSharp.Portable (SL)")]
#elif __ANDROID__
[assembly: AssemblyProduct("RestSharp.Portable (Android)")]
#elif __IOS__ && __UNIFIED__
[assembly: AssemblyProduct("RestSharp.Portable (iOS)")]
#elif __IOS__
[assembly: AssemblyProduct("RestSharp.Portable (iOS Classic)")]
#else
[assembly: AssemblyProduct("RestSharp.Portable (.NET)")]
#endif
[assembly: AssemblyCopyright("Copyright © .NET Development Addict 2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
