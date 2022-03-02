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
        }
    }
}
