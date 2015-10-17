using System.Drawing;

namespace OpenIDE.Core.Extensibility
{
    public class ItemTemplate
    {
        public string Name { get; set; }
        public string Highlighting { get; set; }
        public Image Icon { get; set; }

        public ItemTemplate()
        {
            Name = "";
            Highlighting = "";
        }
    }
}