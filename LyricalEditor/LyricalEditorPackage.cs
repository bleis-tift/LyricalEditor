using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Microsoft.Win32;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using EnvDTE;
using bleistift.LyricalEditor.Options;
using System.Collections.Generic;
using System.Linq;

namespace bleistift.LyricalEditor
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    ///
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the 
    /// IVsPackage interface and uses the registration attributes defined in the framework to 
    /// register itself and its components with the shell.
    /// </summary>
    // This attribute tells the PkgDef creation utility (CreatePkgDef.exe) that this class is
    // a package.
    [PackageRegistration(UseManagedResourcesOnly = true)]
    // This attribute is used to register the informations needed to show the this package
    // in the Help/About dialog of Visual Studio.
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(GuidList.guidLyricalEditorPkgString)]
    [ProvideOptionPage(typeof(GlobalConfigs), "Lyrical Editor", "Top", 0, 0, true)]
    [ProvideAutoLoad("ADFC4E64-0397-11D1-9F4E-00A0C911004F")]
    [ProvideAutoLoad("F1536EF8-92EC-443C-9ED7-FDADF150DA82")]
    public sealed class LyricalEditorPackage : Package
    {
        /// <summary>
        /// Default constructor of the package.
        /// Inside this method you can place any initialization code that does not require 
        /// any Visual Studio service because at this point the package object is created but 
        /// not sited yet inside Visual Studio environment. The place to do all the other 
        /// initialization is the Initialize method.
        /// </summary>
        public LyricalEditorPackage()
        {
            Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
        }

        DTE dte;
        SolutionEvents solEvents;
        DocumentEvents docEvents;

        TResult Get<TService, TResult>(Func<Type, object> f) { return (TResult)f(typeof(TService)); }
        T Get<T>(Func<Type, object> f) { return Get<T, T>(f); }

        static List<Detail> details = new List<Detail>();
        public static IEnumerable<Detail> Details { get { return details; } }
        void LoadConfig()
        {
            var conf = Get<GlobalConfigs>(GetDialogPage);
            details = Detail.Details(conf.DetailsStr).Select(kv => kv.Item2).ToList();
        }

        /////////////////////////////////////////////////////////////////////////////
        // Overriden Package Implementation
        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initilaization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            Trace.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
            base.Initialize();

            dte = Get<DTE>(GetService);
            solEvents = dte.Events.SolutionEvents;
            solEvents.Opened += () => LoadConfig();
            docEvents = dte.Events.DocumentEvents;
            docEvents.DocumentOpening += (docPath, readOnly) => LoadConfig();
        }
        #endregion

    }
}
