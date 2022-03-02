using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS = System.Runtime.InteropServices;

namespace WpfAppTester
{
    public static class Native
    {
        public const string DllName = "MathLibrary.dll";
        public const RIS.CallingConvention CallingConvention = RIS.CallingConvention.Cdecl;
    }
}
