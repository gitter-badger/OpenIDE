using Creek.Scripting;
using Ionic.Zip;
using Microsoft.ClearScript;
using Microsoft.ClearScript.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using TinyJson;

namespace OpenIDE.Core.Extensibility
{
    public class Plugin
    {
        public Dictionary<string, Image> Icons { get; set; }
        public List<ItemTemplate> ItemTemplates { get; set; }
        public List<ProjectTemplate> ProjectTemplates { get; set; }
        public IDictionary<string, object> Info { get; set; }
        private Dictionary<string, string> Highlightings;

        public string Filename { get; set; }

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
            var parts = z.Entries;
            var pa = parts.ToList();

            for (int i = 0; i < pa.Count; i++)
            {
                var part = pa[i];

                if (part.FileName.StartsWith("Icons") && !part.IsDirectory)
                {
                    var strm = part.OpenReader();

                    var img = Image.FromStream(strm);
                    var n = part.FileName.Remove(0, "Icons/".Length);

                    p.Icons.Add(n, img);
                }
                if (part.FileName == "info.json")
                {
                    var json = new StreamReader(part.OpenReader()).ReadToEnd();

                    p.Info = ((ObjectValue)Json.Parse(json)).Value;
                    p.Filename = name;
                }
            }

            p.ReadItemtemplates(z);

            return p;
        }

        private void ReadItemtemplates(ZipFile z)
        {
            var t = Info["Templates"] as ObjectValue;
            var items = (t.Value["Item"] as ArrayValue).Value;

            foreach (var tt in items)
            {
                var obj = (tt as ObjectValue).Value;
                var te = new ItemTemplate();

                te.ProjectID = Guid.Parse(Info["ID"].ToString());

                te.Name = obj["Name"].ToString();
                te.Extension = obj["Extension"].ToString();

                if (Icons.Count > 0)
                {
                    te.Icon = Icons[obj["Icon"].ToString()];
                }
                
                //var h = z["Highlightings/" + tt["Highlighting"].Value<string>()];
                //te.Highlighting = h.OpenReader();
                ItemTemplates.Add(te);
            }
        }
    }
}