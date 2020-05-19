#include "pch.h"

extern "C"
{
	__declspec(dllexport) int Count(int a, int b)
	{
		int rez = a + b;
		return rez;
	}
}