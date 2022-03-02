using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTester
{
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct vector3f
    {
        public float X;
        public float Y;
        public float Z;

        public vector3f(float x = 0, float y = 0, float z = 0)
        {
            X = x; Y = y; Z = z;
        }

        //public static implicit operator Vector3(vector3f v)
        //    => new Vector3(v.X, v.Y, v.Z);

        //public static implicit operator vector3f(Vector3 v)
        //    => new vector3f(v.X, v.Y, v.Z);
    }
}
