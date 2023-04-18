#include "kitx_contract.hpp"

namespace KitX::Contract::Cpp {

    struct IIdentifyInterface {
        string Name;
        string Version;
        Dictionary DisplayName;
        string AuthorName;
        string PublisherName;
        string AuthorLink;
        string PublisherLink;
        Dictionary SimpleDescription;
        Dictionary ComplexDescription;
        Dictionary TotalDescriptionInMarkdown;
        string IconInBase64;
        DateTime *PublishDate;
        DateTime *LastUpdateDate;
        IController *Controller;
        bool IsMarketVersion;
        IMarketPluginContract *MarketPluginContract;
        string RootStartupFileName;
    };

    struct IController {
        fp Start;
        fp Pause;
        fp End;
        Function **Functions;
        fps Execute;
        fpso ExecuteWithArg;
        fps SetRootPath;
        fps SetWorkPath;
    };

    struct IMarketPluginContract {

    };

    class Function {

    };
}
