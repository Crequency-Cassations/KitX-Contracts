cmake_minimum_required(VERSION 3.24)

project(KitX_Contract_Cpp)

set(CMAKE_CXX_STANDARD 20)

file(GLOB SOURCE_FILES "${CMAKE_CURRENT_SOURCE_DIR}/source/*.cpp")

link_directories(${PROJECT_SOURCE_DIR}/lib/CppEnhanced)
include_directories(${PROJECT_SOURCE_DIR}/lib/CppEnhanced/include)

add_library(KitX_Contract_Cpp SHARED ${SOURCE_FILES})
