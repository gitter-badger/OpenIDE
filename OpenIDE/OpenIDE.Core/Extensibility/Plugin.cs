using Creek.Scripting;
using Ionic.Zip;
using Microsoft.ClearScript;
using Microsoft.ClearScript.Windows;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace OpenIDE.Core.Extensibility
{
    public class Plugin
    {
        public Dictionary<string, Image> Icons { get; set; }
        public List<ItemTemplate> ItemTemplates { get; set; }
        public JObject Info { get; set; }

        public JScriptEngine _engine;

        private Plugin()
        {
            _engine = new JScriptEngine(WindowsScriptEngineFlags.EnableJITDebugging);
            _engine.Add("host", new ExtendedHostFunctions());

            Icons = new Dictionary<string, Image>();
            ItemTemplates = new List<ItemTemplate>();
        }

        public static Plugin Load(string name)
        {
            var p = new Plugin();

            var z = new ZipFile(name);

            for (int i = 0; i < z.Count; i++)
            {
                if (z[i].FileName.StartsWith("Icons") && !z[i].FileName.EndsWith("/"))
                {
                    var n = z[i].FileName;

                    var img = Image.FromStream(z[i].OpenReader());

                    p.Icons.Add(n, img);
                }
                if (z[i].FileName == "info.json")
                {
                    var json = new StreamReader(z[i].OpenReader()).ReadToEnd();
                    p.Info = JObject.Parse(json);

                    p.ReadItemtemplates();
                }
            }

            return p;
        }

        private void ReadItemtemplates()
        {
            var t = Info["Templates"]["Item"];

            foreach (var tt in t)
            {
                var te = new ItemTemplate();

                te.Icon = Icons[tt["Icon"].Value<string>()];
                te.Highlighting = tt["Highlighting"].Value<string>();
                te.Name = tt["Name"].Value<string>();

                ItemTemplates.Add(te);
            }
        }
    }
}