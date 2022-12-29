#ifndef KITX_CONTRACT_CPP_KITX_CONTRACT_H
#define KITX_CONTRACT_CPP_KITX_CONTRACT_H

#include <string>
#include <hash_map>

namespace KitX::Contract::Cpp{
    typedef std::unordered_map<std::string, std::string> Dictionary;
    typedef std::string string;
    typedef void (*fp);
    typedef void* (*fps)(std::string cmd);
    typedef void* (*fpso)(std::string cmd, void* arg);

    struct IIdentifyInterface;
    struct IController;
    struct IMarketPluginContract;

    class DateTime;
    class Function;

    struct IIdentifyInterface{
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
        DateTime* PublishDate;
        DateTime* LastUpdateDate;
        IController* Controller;
        bool IsMarketVersion;
        IMarketPluginContract* MarketPluginContract;
        string RootStartupFileName;
    };

    struct IController{
        fp Start;
        fp Pause;
        fp End;
        Function** Functions;
        fps Execute;
        fpso ExecuteWithArg;
        fps SetRootPath;
        fps SetWorkPath;
    };

    struct IMarketPluginContract{

    };

    class DateTime{

    };

    class Function{

    };
}

#endif //KITX_CONTRACT_CPP_KITX_CONTRACT_H
