using OpenIDE.Core;
using Telerik.WinControls.UI;

namespace OpenIDE
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();

            var editor = EditorBuilder.Build("JavaScript", null, null, null);

            documentWindow1.Controls.Add(editor);
        }
    }
}