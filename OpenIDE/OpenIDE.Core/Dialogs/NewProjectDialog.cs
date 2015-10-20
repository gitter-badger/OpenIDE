using OpenIDE.Core.Extensibility;
using System;
using Telerik.WinControls.UI;

namespace OpenIDE.Core.Dialogs
{
    public partial class NewProjectDialog : RadForm
    {
        public Guid Type { get; set; }
        public string Filename { get; set; }
        public ProjectTemplate Template { get; set; }

        public NewProjectDialog()
        {
            InitializeComponent();

            Filename = "";

            foreach (var item in Workspace.PluginManager.Plugins)
            {
                foreach (var t in item.ProjectTemplates)
                {
                    var i = new ListViewDataItem(t.Name);
                    i.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    i.Image = t.Icon;
                    i.Tag = t;
                    i.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    i.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                    radListView1.Items.Add(i);
                }
            }

            radListView1.SelectedIndex = 0;
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            Filename = radTextBox1.Text;
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
           var s = radListView1.SelectedItem.Tag as ProjectTemplate;

            if (s != null)
            {
                Type = s.ProjectID;
                Template = s;

                if(!Filename.EndsWith(s.Extension))
                {
                    Filename += s.Extension;
                }
            }
        }
    }
}