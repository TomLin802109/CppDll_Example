// CppTestConsole.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
#include <limits>
#include <format>
#include <string>
#include <algorithm>

using namespace std;

struct Point3 {
    float X, Y, Z;
    Point3() {
        auto lim = numeric_limits<float>();
        X = Y = Z = lim.quiet_NaN();
    }
    Point3(float x, float y, float z) {
        X = x; Y = y; Z = z;
    }
    string ToString() {
        return to_string(X) + "," + to_string(Y) + "," + to_string(Z);
    }
};

ostream& operator<<(ostream& os, Point3 p) {
    os << p.X << "," << p.Y << "," << p.Z;
    return os;
}

bool compZ(Point3 const& lhs, Point3 const& rhs) {
    return lhs.Z < rhs.Z;
}

int main()
{
    Point3 p1(1, 2, 3);
    Point3 p2;
    cout << p2.ToString() << endl;

    int count = 3;
    vector<Point3> vec;
    for (int i = -3 * count; i < 3 * count; i += 3) {
        auto p = Point3(i, i + 1, i + 2);
        vec.push_back(p);
        cout << p << endl;
    }

    auto func = [](const Point3& a, const Point3& b) {
        return a.Z < b.Z;
    };

    auto max = std::max_element(vec.begin(), vec.end(), [](const Point3& a, const Point3& b) { return a.Z < b.Z; });
    auto min = std::min_element(vec.begin(), vec.end(), [](const Point3& a, const Point3& b) { return a.Z < b.Z; });
    cout << "max element: " << max->ToString() << endl;
    cout << "min element: " << min->ToString() << endl;
    cout << "print by pointer" << endl;
    cout << "vec ptr: " << &vec << endl;
    for (int i = 0; i < vec.size(); i++) {
        auto ptr = &vec;
        cout << (*ptr)[i].ToString() << endl;
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
