#pragma once
#include <type_traits>
#include <cstring>
#define ES extern "C" __declspec(dllexport) inline

template <typename...> struct minBND_TypeList {};
#define BlittableTypes(...) minBND_TypeList<__VA_ARGS__>minBND_blittables;
#define ForbiddenTypes(...) minBND_TypeList<__VA_ARGS__>minBND_forbidden;
#define ManualDecls(...) minBND_TypeList<__VA_ARGS__>minBND_manualDecls;
#define ManualBlittableTypes(...) minBND_TypeList<__VA_ARGS__>minBND_manualBlittables;
#define ManualPointerTypes(...) minBND_TypeList<__VA_ARGS__>minBND_manualPointers;
#define ForcedStaticClasses(...) minBND_TypeList<__VA_ARGS__>minBND_forcedStatics;

#define CONCAT_D(X,Y) X##Y
#define CONCAT(X,Y) CONCAT_D(X,Y)
#define CONFSIG(func, retType, ...) \
	void* CONCAT(minBND_confsig_fName_L_,__LINE__); /*func*/ \
	minBND_TypeList<retType, __VA_ARGS__>CONCAT(minBND_confsig_typeList_L_,__LINE__);
#define ForbidSignature(func, retType, ...) CONFSIG(func, retType, __VA_ARGS__);