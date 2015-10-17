using System;
using Telerik.WinControls.UI;

namespace OpenIDE.Core.Dialogs
{
    public partial class NewProjectDialog : RadForm
    {
        public Guid Type { get; set; }
        public string ProjectName { get; set; }
        public Template Template { get; set; }

        public NewProjectDialog()
        {
            InitializeComponent();

            foreach (var item in Workspace.PluginManager.PlugIns)
            {
                foreach (var t in item.PlugInProxy.Templates)
                {
                    var i = new ListViewDataItem(t.Name);
                    i.Tag = t;

                    radListView1.Items.Add(i);
                }
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            ProjectName = radTextBox1.Text;
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
            var s = (Template)radListView1.SelectedItem.Tag;

            Type = s.ProjectID;
            Template = s;
        }
    }
}