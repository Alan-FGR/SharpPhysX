#include <cstdio>

#define ES extern "C" __declspec(dllexport) inline // Export Symbol

ES int add(int x, int y)
{
    return x + y;
}

