using System;
using DigitalRune.Windows.TextEditor.Completion;
using DigitalRune.Windows.TextEditor.Folding;
using DigitalRune.Windows.TextEditor.Insight;
using Hik.Sps;
using OpenIDE.Contracts;
using IntegratedJs;
using System.Text.RegularExpressions;

namespace OpenIDE.Javascript
{
    [PlugIn("JavaScript")]
    public class JavaScriptPlugin : PlugIn<IIDEApplication>, IIDEPlugIn
    {
        private FunctionCollection Functions = new FunctionCollection();

        public AbstractCompletionDataProvider CompletionProvider => new CodeCompletionDataProvider(Functions);

        public string Extension => ".js";

        public IFoldingStrategy FoldingStrategy => new CodeFoldingStrategy();

        public string Highlighting => "JavaScript";

        public AbstractInsightDataProvider Insight => new MethodInsightDataProvider(Functions);

        public Guid ProjectTypeID => Guid.Parse("17764EC8-8379-437E-BCD6-97660F1656FB");

        public void TextChanged(string Text)
        {
            Functions.Clear();

            var funcPattern = @"function\s*(?<name>[^\s(]*)\((?<args>[^)]*)\)";
            if (Text != null)
            {
                foreach (var line in Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var m = Regex.Match(line, funcPattern);
                    var f = new Function();

                    if (m.Success)
                    {
                        f.Name = m.Groups["name"].Value;
                        f.Args = m.Groups["args"].Value;
                        f.Description = f.Name + "Function";

                        Functions.Add(f);
                    }
                }
            }
        }
    }
}