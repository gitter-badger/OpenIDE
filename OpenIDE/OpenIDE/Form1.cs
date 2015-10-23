using OpenIDE.Core;
using OpenIDE.Core.Dialogs;
using OpenIDE.Core.Extensibility;
using OpenIDE.Core.ProjectSystem;
using System;
using System.Linq;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace OpenIDE
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();

            Workspace.PluginManager = new PluginManager();
            Workspace.PluginManager.Load(Environment.CurrentDirectory + "\\Plugins");

            var p = Workspace.PluginManager.Plugins[0];

            var editor = EditorBuilder.Build(p.ItemTemplates[0].Extension, null, null, null);

            documentWindow1.Controls.Add(editor);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Updater.IsUpdateAvailable()) {
                radDesktopAlert1.ContentText = "An Update is available. Please update!!";
                radDesktopAlert1.Show();
            }
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Solution (*.sln)|*.sln";
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Workspace.Solution = new Solution();
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
            if (np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var f = new Project();
                f.Name = np.Filename;
                f.Type = np.Type;

                Workspace.Solution.Projects.Add(f);

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
                Workspace.SolutionPath = openFileDialog1.FileName;

                radTreeView1.Nodes.Clear();
                radTreeView1.Nodes.Add(SolutionExplorer.Build(Workspace.Solution));
            }
        }

        private void radMenuItem14_Click(object sender, EventArgs e)
        {
            Updater.Update();
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {
            var np = new NewItemDialog();
            if (np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var f = new File();
                f.Name = np.Filename;
                f.Src = np.Filename;
                f.ID = np.Type;

                Workspace.SelectedProject.Files.Add(f);

                radTreeView1.Nodes.Clear();
                radTreeView1.Nodes.Add(SolutionExplorer.Build(Workspace.Solution));

                Workspace.Solution.Save(Workspace.SolutionPath);
                var p = np.Template;

                var editor = EditorBuilder.Build(p.Extension, null, null, null);

                var doc = new DocumentWindow(f.Name);
                doc.Controls.Add(editor);

                radDock1.AddDocument(doc);
            }
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Tag is File)
                {
                    var n = e.Node.Parent;
                    Workspace.SelectedProject = n?.Tag as Project;
                }
                else
                {
                    Workspace.SelectedProject = radTreeView1.SelectedNode?.Tag as Project;
                }
            }
        }
    }
}