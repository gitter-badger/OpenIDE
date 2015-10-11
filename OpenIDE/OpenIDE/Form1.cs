using OpenIDE.Core;
using OpenIDE.Core.Dialogs;
using OpenIDE.Core.ProjectSystem;
using System;
using Telerik.WinControls.UI;

namespace OpenIDE
{
    public partial class Form1 : RadForm
    {
        PlugInManager _plugins = new PlugInManager();

        public Form1()
        {
            InitializeComponent();

            _plugins.PlugInFolder = Environment.CurrentDirectory + "\\Plugins";
            _plugins.LoadPlugIns();

            Workspace.PluginManager = _plugins;

            var p = _plugins.PlugIns[0].PlugInProxy;

            var editor = EditorBuilder.Build(p.Highlighting, p.CompletionProvider, p.FoldingStrategy, p.Insight);
            editor.DocumentChanged += (s, e) => p.TextChanged(e.Text);

            documentWindow1.Controls.Add(editor);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Updater.IsUpdateAvailable()) Updater.Update();
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Solution (*.sln)|*.sln";
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Workspace.Solution = new Core.ProjectSystem.Solution();
                var name = Prompt.Show("Please specifiy an solution name", "Name");
                Workspace.Solution.Name = name;

                radTreeView1.Nodes.Clear();
                radTreeView1.Nodes.Add(SolutionExplorer.Build(Workspace.Solution));

                Workspace.SolutionPath = saveFileDialog1.FileName;

                Workspace.Solution.Save(saveFileDialog1.FileName);
            }
        }

        private void radMenuItem12_Click(object sender, EventArgs e)
        {
            var np = new NewProjectDialog();
            if(np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var p = new Project();
                p.Name = np.ProjectName;
                p.Type = np.Type;

                Workspace.Solution.Projects.Add(p);

                radTreeView1.Nodes.Clear();
                radTreeView1.Nodes.Add(SolutionExplorer.Build(Workspace.Solution));

                Workspace.Solution.Save(Workspace.SolutionPath);
            }
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Solution (*.sln)|*.sln";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Workspace.Solution = Solution.Load(openFileDialog1.FileName);

                radTreeView1.Nodes.Clear();
                radTreeView1.Nodes.Add(SolutionExplorer.Build(Workspace.Solution));
            }
        }
    }
}