# Additional clean files
cmake_minimum_required(VERSION 3.16)

if("${CONFIG}" STREQUAL "" OR "${CONFIG}" STREQUAL "Debug")
  file(REMOVE_RECURSE
  "CMakeFiles/StreetManager_autogen.dir/AutogenUsed.txt"
  "CMakeFiles/StreetManager_autogen.dir/ParseCache.txt"
  "StreetManager_autogen"
  )
endif()
