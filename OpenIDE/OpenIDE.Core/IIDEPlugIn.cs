using DigitalRune.Windows.TextEditor.Completion;
using DigitalRune.Windows.TextEditor.Folding;
using DigitalRune.Windows.TextEditor.Insight;
using Hik.Sps;
using System;

namespace OpenIDE.Contracts
{
    /// <summary>
    /// Defines the plug-in interface for the calculator application.
    /// A class must implement this interface to be a plug-in for the calculator.
    /// Calculator application uses plug-ins through this interface.
    /// </summary>
    public interface IIDEPlugIn : IPlugIn
    {
        string Extension { get; }
        AbstractCompletionDataProvider CompletionProvider { get; }
        IFoldingStrategy FoldingStrategy { get; }
        AbstractInsightDataProvider Insight { get; }
        string Highlighting { get; }
        void TextChanged(string text);
        Guid ProjectTypeID { get; }
    }
}
