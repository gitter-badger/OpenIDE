using DigitalRune.Windows.TextEditor;
using OpenIDE.Core.ProjectSystem;
using System;
using Telerik.WinControls.UI.Docking;
using OpenIDE;

namespace OpenIDE.Core
{
    public static class Workspace
    {
        public static event EventHandler IsIdleChanged;

        private static bool _isIdle;
        public static bool IsIdle
        {
            get { return _isIdle; }
            set {
                _isIdle = value;
                IsIdleChanged?.Invoke(null, null);
            }
        }   

        public static PlugInManager PluginManager { get; set; }

        public static TextEditorControl CurrentEditor { get; set; }

        public static Solution Solution { get; set; }

        public static string SolutionPath { get; set; }

        public static string AppDataPath { get; set; }

        public static RadDock dockingManager;

        static Workspace()
        {
            Solution = new Solution();

            AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\OpenIDE\";
            SolutionPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
    }
}