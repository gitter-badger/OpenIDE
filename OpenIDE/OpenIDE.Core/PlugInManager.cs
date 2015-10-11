using Hik.Sps;
using OpenIDE.Contracts;

namespace OpenIDE
{
    /// <summary>
    /// Implements ICalculatorApplication and provides a container/manager for plug-ins
    /// </summary>
    [PlugInApplication("OpenIDE")]
    public class PlugInManager : PlugInBasedApplication<IIDEPlugIn>, IIDEApplication
    {
        
    }
}
