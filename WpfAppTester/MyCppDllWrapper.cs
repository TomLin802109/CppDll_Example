using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTester
{
    internal static partial class Invoke
    {
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern IntPtr CreateInstance();
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern void DisposeInstance(ref IntPtr ptr);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern float Func1(IntPtr ptr, float a, float b);
        [DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        public static extern float Func2(IntPtr ptr, float a, float b);


        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void RotateAnyAxis(vector3f vector, vector3f rotateAxis, double anglePi, out vector3f result);
        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void RotateZYZ(vector3f vector, double z1Pi, double yPi, double z2Pi, out vector3f result);
        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void InverseRotateZYZ(vector3f vector, double z1Pi, double yPi, double z2Pi, out vector3f result);
        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void RotateZYX(vector3f vector, double z1Pi, double yPi, double z2Pi, out vector3f result);
        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void InverseRotateZYX(vector3f vector, double z1Pi, double yPi, double z2Pi, out vector3f result);
        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void RotateXYZ(vector3f vector, double z1Pi, double yPi, double z2Pi, out vector3f result);
        //[DllImport(Native.DllName, CallingConvention = Native.CallingConvention)]
        //public static extern void InverseRotateXYZ(vector3f vector, double z1Pi, double yPi, double z2Pi, out vector3f result);
    }

    public class MyCppDllWrapper : UnmanagedObject
    {
        public MyCppDllWrapper()
        {
            _ptr = Invoke.CreateInstance();
        }

        protected override void DisposeObject()
        {
            Invoke.DisposeInstance(ref _ptr);
        }

        public float Add(float a, float b)
        {
            return Invoke.Func1(_ptr, a, b);
        }

        public float Sub(float a, float b)
        {
            return Invoke.Func2(_ptr, a, b);
        }

    }
}
