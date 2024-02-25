using KitX.Shared.Plugin;
using System.ComponentModel.Composition;

namespace KitX.Contract.CSharp;

[InheritedExport]
public interface IIdentityInterface
{
    PluginInfo GetPluginInfo();

    IController GetController();

    IMarketPluginContract GetMarketPluginContract();
}
