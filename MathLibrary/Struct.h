#pragma once
#include <string>

struct Vector3f {
public:
	float X;
	float Y;
	float Z;
	Vector3f(float x, float y, float z) {
		this->X = x; this->Y = y; this->Z = z;
	}
	std::string ToString() {
		return std::to_string(X) + "," + std::to_string(Y) + "," + std::to_string(Z);
	}
};

template <class T>
struct ObjectCollection
{
public:
	int size;
	T* data;
private:

};