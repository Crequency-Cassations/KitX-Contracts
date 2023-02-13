#ifndef KITX_CONTRACT_CPP_KITX_CONTRACT_H
#define KITX_CONTRACT_CPP_KITX_CONTRACT_H

#include <string>
#include <hash_map>

#include "datetime.h"

namespace KitX::Contract::Cpp{
    typedef std::unordered_map<std::string, std::string> Dictionary;
    typedef std::string string;
    typedef void (*fp);
    typedef void* (*fps)(std::string cmd);
    typedef void* (*fpso)(std::string cmd, void* arg);

    struct IIdentifyInterface;
    struct IController;
    struct IMarketPluginContract;

    class Function;
}

#endif //KITX_CONTRACT_CPP_KITX_CONTRACT_H
