using DigitalRune.Windows.TextEditor.Completion;
using DigitalRune.Windows.TextEditor.Folding;
using DigitalRune.Windows.TextEditor.Insight;
using Hik.Sps;
using OpenIDE.Core;
using System;

namespace OpenIDE.Contracts
{
    public interface IIDEPlugIn : IPlugIn
    {
        string Extension { get; }
        AbstractCompletionDataProvider CompletionProvider { get; }
        IFoldingStrategy FoldingStrategy { get; }
        AbstractInsightDataProvider Insight { get; }
        string Highlighting { get; }
        void TextChanged(string text);
        Guid ProjectTypeID { get; }
        Template[] Templates { get; }
    }
}
