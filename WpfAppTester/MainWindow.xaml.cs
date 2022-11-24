using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var num1 = MathLibraryInvoke.Add(3333.1111, 1111.1111);
            var num2 = MathLibraryInvoke.Divide(5555.5555, 1111.1111);
            var cal = MathClassInvoke.CreateInstance();
            var num3 = MathClassInvoke.Multiplication(cal, 1.2f, 2.1f);
            var last1 = MathClassInvoke.LastResult(cal);
            var num4 = MathClassInvoke.Division(cal, 123.123f, 123.123f);
            var last2 = MathClassInvoke.LastResult(cal);
            var vec = MathClassInvoke.GetVector(cal);
            var vecPtr = MathClassInvoke.GetVectorPtr(cal);
            var dot = MathClassInvoke.Dot(cal, new vector3f(0, 1, 1), new vector3f(0, 1, 0));
            var nor = MathClassInvoke.Cross(cal, new vector3f(0, 0, 1), new vector3f(0, 1, 0));
            MathClassInvoke.DeleteInstance(cal);

            var ary = new vector3f[] { new vector3f(1, 2, 3), new vector3f(4, 5, 6), new vector3f(7, 8, 9) };

            MathClassInvoke.SetArray(cal, ary, ary.Length);


            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
            }
            // send a array of int struct to native dll and allow it to modify array value.
            int sum1 = MathClassInvoke.TestArrayOfInts(array1, array1.Length);
            ;
            // send a array of vector3f struct to native dll and allow it to modify array value.
            int sum2 = MathClassInvoke.TestArrayOfStructs(ary, ary.Length);
            ;

            GetArrayFromCpp();

            ;
        }

        private unsafe void GetArrayFromCpp()
        {
            int n = 0;
            IntPtr ptr = IntPtr.Zero;
            MathClassInvoke.TestOutArrayOfStructs(out n, out ptr);
            vector3f[] ary = new vector3f[n];
            for(int i = 0; i < n; i++)
            {
                ary[i] = Marshal.PtrToStructure<vector3f>(ptr + sizeof(vector3f) * i);
                Console.WriteLine($"{ary[i].X},{ary[i].Y},{ary[i].Z}");
                Marshal.DestroyStructure<vector3f>(ptr + sizeof(vector3f) * i);
            }
            Marshal.FreeCoTaskMem(ptr);
            ;

        }
    }
}
