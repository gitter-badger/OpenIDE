using System;
using Telerik.WinControls.UI;

namespace OpenIDE.Core.Dialogs
{
    public partial class NewProjectDialog : RadForm
    {
        public Guid Type { get; set; }
        public string ProjectName { get; set; }

        public NewProjectDialog()
        {
            InitializeComponent();

            foreach (var item in Workspace.PluginManager.PlugIns)
            {
                var i = new ListViewDataItem(item.Name);
                i.Tag = item.PlugInProxy.ProjectTypeID;

                radListView1.Items.Add(i);
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            ProjectName = radTextBox1.Text;
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
            Type = (Guid)radListView1.SelectedItem.Tag;
        }
    }
}