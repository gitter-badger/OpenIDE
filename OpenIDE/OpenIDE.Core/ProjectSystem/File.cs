using System.Windows.Markup;

namespace OpenIDE.Core.ProjectSystem
{
    [ContentProperty("Src")]
    public class File
    {
        public string Src { get; set; }
        public string Name { get; set; }
    }
}