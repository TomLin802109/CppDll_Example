#include "pch.h"
#include "MathClass.h"

#include <iostream>
#include <vector>

using namespace std;

Calculate::Calculate(float a, float b) {
	this->num1 = a;
	this->num2 = b;
	vec = Vector3f(1, 1, 1);
}

Calculate::~Calculate() {
	//std::cout << "Calculate object distroy" << std::endl;
}

float Calculate::Multiplication(float a, float b) {
	result = a * b;
	return result;
}
float Calculate::Division(float a, float b) {
	result = a / b;
	return result;
}
float Calculate::LastResult() {
	return result;
}

Vector3f Calculate::GetVector() {
	return this->vec;
}
Vector3f* Calculate::GetVectorPtr() {
	return &vec;
}
//float Dot(Vector3f* v1, Vector3f* v2) {
//	return v1->X * v2->X + v1->Y * v2->Y + v1->Z * v2->Z;
//}
float Calculate::Dot(Vector3f v1, Vector3f v2) {
	return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
}
Vector3f Calculate::Cross(Vector3f v1, Vector3f v2) {
	return Vector3f(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
}


void Calculate::SetArray(Vector3f* inAryPtr, int size) {
	cout << "MSG from native dll:" << endl;
	
	for (int i = 0; i < size; i++) {
		auto d = inAryPtr[i];
		cout << d.ToString() << endl;
	}
}

void Calculate::GetArray(int size, Vector3f* inAryPtr, int& outSize) {
	outSize = size;
	vector<Vector3f> vec;
	for (int i = 0; i < size; i++) {
		vec.push_back(Vector3f(i, i, i));
	}
	inAryPtr = &(vec[0]);
}
