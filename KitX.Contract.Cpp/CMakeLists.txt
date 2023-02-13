cmake_minimum_required(VERSION 3.24)
project(KitX_Contract_Cpp)

set(CMAKE_CXX_STANDARD 20)

link_directories(${PROJECT_SOURCE_DIR}/lib/CppEnhanced)
include_directories(${PROJECT_SOURCE_DIR}/lib/CppEnhanced/include)

add_library(KitX_Contract_Cpp kitx_contract.cpp)
