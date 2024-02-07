namespace KitX.Contract.CSharp;

public interface IMarketPluginContract
{
    string GetMarketPluginId();

    string GetMarketPluginKey();

    string GetMarketPluginVerifyUrl();

    string GetMarketPluginVerifyToken();
}
