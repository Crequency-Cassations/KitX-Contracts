using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace KitX.Contract.CSharp;

[InheritedExport]
public interface IIdentityInterface
{
    string GetName();

    string GetVersion();

    Dictionary<string, string> GetDisplayName();

    string GetAuthorName();

    string GetPublisherName();

    string GetAuthorLink();

    string GetPublisherLink();

    Dictionary<string, string> GetSimpleDescription();

    Dictionary<string, string> GetComplexDescription();

    Dictionary<string, string> GetTotalDescriptionInMarkdown();

    string GetIconInBase64();

    DateTime GetPublishDate();

    DateTime GetLastUpdateDate();

    IController GetController();

    bool IsMarketVersion();

    IMarketPluginContract GetMarketPluginContract();

    string GetRootStartupFileName();
}
