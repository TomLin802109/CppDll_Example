#pragma once

struct Vector3f {
public:
	float X;
	float Y;
	float Z;
	Vector3f(float x, float y, float z) {
		this->X = x; this->Y = y; this->Z = z;
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