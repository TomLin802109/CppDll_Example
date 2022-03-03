#include "pch.h"
#include "MathClass.h"

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


