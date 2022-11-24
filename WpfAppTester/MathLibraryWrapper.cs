using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTester
{
    internal static partial class MathLibraryInvoke
    {
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern double Add(double a, double b);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern double Divide(double a, double b);
    }

    internal static partial class MathClassInvoke
    {
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern IntPtr CreateInstance();
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern void DeleteInstance(IntPtr ptr);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern float Multiplication(IntPtr ptr, float a, float b);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern float Division(IntPtr ptr, float a, float b);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern float LastResult(IntPtr ptr);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern vector3f GetVector(IntPtr ptr);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern IntPtr GetVectorPtr(IntPtr ptr);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern float Dot(IntPtr ptr, vector3f v1, vector3f v2);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern vector3f Cross(IntPtr ptr, vector3f v1, vector3f v2);

        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern void SetArray(IntPtr ptr, vector3f[] ary, int size);

        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern void GetArray(IntPtr ptr, int size, IntPtr aryPtr, out int outSize);

        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern int TestArrayOfInts([In, Out] int[] array, int size);
        
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern int TestArrayOfStructs([In, Out] vector3f[] pointArray, int size);

        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern void TestOutArrayOfStructs(out int size, out IntPtr outArray);
    }
}
