using OpenIDE.Core.ProjectSystem;
using Telerik.WinControls.UI;

namespace OpenIDE.Core
{
    public class SolutionExplorer
    {
        public static RadTreeNode Build(Solution sol)
        {
            var ret = new RadTreeNode($"Solution '{sol.Name}'", true);
            ret.Tag = sol;

            foreach (var p in sol.Projects)
            {
                var pn = new RadTreeNode($"Project '{p.Name}'", true);
                pn.Tag = p;

                foreach (var f in p.Files)
                {
                    var n = new RadTreeNode(f.Src);
                    n.Tag = f;

                    pn.Nodes.Add(n);
                }

                ret.Nodes.Add(pn);
            }

            return ret;
        }
    }
}