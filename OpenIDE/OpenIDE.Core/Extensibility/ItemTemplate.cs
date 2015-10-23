using System;
using System.Drawing;
using System.IO;

namespace OpenIDE.Core.Extensibility
{
    public class ItemTemplate
    {
        public string Name { get; set; }
        public string Highlighting { get; set; }
        public Image Icon { get; set; }
        public Guid ProjectID { get; set; }
        public string Extension { get; set; }

        public ItemTemplate()
        {
            Name = "";
        }
    }
}