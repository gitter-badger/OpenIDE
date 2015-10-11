using DigitalRune.Windows.TextEditor;
using DigitalRune.Windows.TextEditor.Document;
using DigitalRune.Windows.TextEditor.Insight;
using IntegratedJs;

namespace OpenIDE.Javascript
{
    public class MethodInsightDataProvider : AbstractInsightDataProvider
    {
        int _argumentStartOffset;   // The offset where the method arguments starts.
        string[] _insightText;      // The insight information.

        private FunctionCollection _funcs;

        public MethodInsightDataProvider(FunctionCollection funcs)
        {
            _funcs = funcs;
        }

        protected override int ArgumentStartOffset
        {
            get { return _argumentStartOffset; }
        }


        public override int InsightDataCount
        {
            get { return (_insightText != null) ? _insightText.Length : 0; }
        }


        public override string GetInsightData(int number)
        {
            return (_insightText != null) ? _insightText[number] : string.Empty;
        }


        public override void SetupDataProvider(string fileName)
        {

            // This class provides the method insight information.
            // To find out which information is requested, it simply compares the
            // word before the caret with 3 hardcoded method names.

            int offset = TextArea.Caret.Offset;
            IDocument document = TextArea.Document;
            string methodName = TextHelper.GetIdentifierAt(document, offset - 1);

            var f = _funcs[methodName];

            if (f != null)
            {
                SetupDataProviderForMethod(f, offset);
            }
            else
            {
                // Perhaps the cursor is already inside the parameter list.
                offset = TextHelper.FindOpeningBracket(document, offset - 1, '(', ')');
                if (offset >= 1)
                {
                    methodName = TextHelper.GetIdentifierAt(document, offset - 1);
                    SetupDataProviderForMethod(f, offset);
                }
            }
        }


        private void SetupDataProviderForMethod(Function f, int argumentStartOffset)
        {
            _insightText = new string[1];
            _insightText[0] = f.Description;

            _argumentStartOffset = argumentStartOffset;
        }
    }
}