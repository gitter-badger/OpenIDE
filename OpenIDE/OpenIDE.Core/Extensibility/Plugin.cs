using Creek.Scripting;
using Ionic.Zip;
using Microsoft.ClearScript;
using Microsoft.ClearScript.Windows;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace OpenIDE.Core.Extensibility
{
    public class Plugin
    {
        public Dictionary<string, Image> Icons { get; set; }
        public List<ItemTemplate> ItemTemplates { get; set; }
        public List<ProjectTemplate> ProjectTemplates { get; set; }
        public JObject Info { get; set; }
        private Dictionary<string, string> Highlightings;

        public JScriptEngine _engine;

        private Plugin()
        {
            _engine = new JScriptEngine(WindowsScriptEngineFlags.EnableJITDebugging);
            _engine.Add("host", new ExtendedHostFunctions());

            Icons = new Dictionary<string, Image>();
            ItemTemplates = new List<ItemTemplate>();
            ProjectTemplates = new List<ProjectTemplate>();

            Highlightings = new Dictionary<string, string>();
        }

        public static Plugin Load(string name)
        {
            var p = new Plugin();

            var z = new ZipFile(name);

            // Add Icons
            for (int i = 0; i < z.Count; i++)
            {
                if (z[i].FileName.StartsWith("Icons") && !z[i].FileName.EndsWith("/"))
                {
                    var n = z[i].FileName.Remove(0, "Icons/".Length);

                    var img = Image.FromStream(z[i].OpenReader());

                    p.Icons.Add(n, img);
                }
            }

            // Add Other Stuff
            for (int i = 0; i < z.Count; i++)
            {
                if (z[i].FileName == "info.json")
                {
                    var json = new StreamReader(z[i].OpenReader()).ReadToEnd();
                    p.Info = JObject.Parse(json);

                    p.ReadItemtemplates(z);
                }
            }

            return p;
        }

        private void ReadItemtemplates(ZipFile z)
        {
            var t = Info["Templates"]["Item"];

            foreach (var tt in t)
            {
                var te = new ItemTemplate();

                if (Icons.Count > 0)
                {
                    te.Icon = Icons[tt["Icon"].Value<string>()];
                }
                te.ProjectID = Guid.Parse(Info["ID"].Value<string>());

                te.Name = tt["Name"].Value<string>();
                te.Extension = tt["Extension"].Value<string>();

                //var h = z["Highlightings/" + tt["Highlighting"].Value<string>()];
                //te.Highlighting = h.OpenReader();
                ItemTemplates.Add(te);
            }
        }
    }
}