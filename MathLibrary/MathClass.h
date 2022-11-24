#pragma once
#include <iostream>
#include "Struct.h"
#include <objbase.h>

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

class MATHLIBRARY_API Calculate
{
public:
	Calculate(float a=0.0, float b=0.0);
	~Calculate();
	float Multiplication(float a, float b);
	float Division(float a, float b);
	float LastResult();
	Vector3f GetVector();
	Vector3f* GetVectorPtr();
	float Dot(Vector3f v1, Vector3f v2);
	Vector3f Cross(Vector3f v1, Vector3f v2);
	void SetArray(Vector3f* inAryPtr, int size);
	void GetArray(int size, Vector3f* inAryPtr, int& outSize);
private:
	float num1 = 7.2f;
	float num2 = 3.7f;
	float result = 15.5;
	Vector3f vec = Vector3f(0.0, 0.0, 0.0);
};

extern "C" MATHLIBRARY_API Calculate* CreateInstance() {
	return new Calculate();
}
extern "C" MATHLIBRARY_API void DeleteInstance(Calculate * pShapeInstance) {
	if (pShapeInstance != NULL) {
		delete pShapeInstance;
		pShapeInstance = NULL;
	}
}

extern "C" MATHLIBRARY_API float Multiplication(Calculate * pShapeInstance, float a, float b) {
	return pShapeInstance->Multiplication(a, b);
}
extern "C" MATHLIBRARY_API float Division(Calculate * pShapeInstance, float a, float b) {
	return pShapeInstance->Division(a, b);
}
extern "C" MATHLIBRARY_API float LastResult(Calculate * pShapeInstance) {
	return pShapeInstance->LastResult();
}

extern "C" MATHLIBRARY_API Vector3f GetVector(Calculate* pShapeInstance) {
	return pShapeInstance->GetVector();
}
extern "C" MATHLIBRARY_API Vector3f* GetVectorPtr(Calculate* pShapeInstance) {
	return pShapeInstance->GetVectorPtr();
}
extern "C" MATHLIBRARY_API float Dot(Calculate* pShapeInstance, Vector3f v1, Vector3f v2) {
	return pShapeInstance->Dot(v1, v2);
}
extern "C" MATHLIBRARY_API Vector3f Cross(Calculate* pShapeInstance, Vector3f v1, Vector3f v2) {
	return pShapeInstance->Cross(v1, v2);
}

extern "C" MATHLIBRARY_API void SetArray(Calculate* pShapeInstance, Vector3f* inAryPtr, int size) {
	pShapeInstance->SetArray(inAryPtr, size);
}

extern "C" MATHLIBRARY_API void GetArray(Calculate * pShapeInstance, int size, Vector3f* outAryPtr, int& outSize) {
	pShapeInstance->GetArray(size, outAryPtr, outSize);
}

extern "C" {
	MATHLIBRARY_API int TestArrayOfInts(int* pArray, int size)
	{
		int result = 0;

		for (int i = 0; i < size; i++)
		{
			result += pArray[i];
			pArray[i] += 100;
		}
		return result;
	}
	MATHLIBRARY_API int TestArrayOfStructs(Vector3f* pArray, int size)
	{
		int result = 0;
		Vector3f* pCur = pArray;

		for (int i = 0; i < size; i++)
		{
			result += pCur->X + pCur->Y + pCur->Z;
			pCur->Y = 0;
			pCur++;
		}

		return result;
	}
	MATHLIBRARY_API void TestOutArrayOfStructs(int* pSize, Vector3f** ppStruct)
	{
		const int cArraySize = 5;
		*pSize = 0;
		*ppStruct = (Vector3f*)CoTaskMemAlloc(cArraySize * sizeof(Vector3f));

		if (ppStruct != NULL)
		{
			Vector3f* pCurStruct = *ppStruct;
			*pSize = cArraySize;

			for (int i = 0; i < cArraySize; i++, pCurStruct++)
			{
				pCurStruct->X = i;
				pCurStruct->Y = i + 1;
				pCurStruct->Z = i + 2;
			}
		}
	}
}
