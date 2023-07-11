using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 访问 MyFunctionality 类中的属性
            //繼承方法使用
            //int number = MyFunctionality.Number;
            //MessageBox.Show(number.ToString());

            //int ans = MyFunctionality.Number + 1;

            // 使用类型转换访问 MyFunctionality 类中的属性
            //if (MyFunctionality.Number is int number)
            //{
            //MessageBox.Show(ans.ToString());
            /*}
            else
            {
                //MessageBox.Show("Invalid number.");
            }*/
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            /*int ans = Convert.ToInt16(MyFunctionality.Number) + 1;
            int add = ans;
            txt.Content = add;*/
            int currentValue = Convert.ToInt16(MyFunctionality.Number);
            int ans = currentValue + 1;
            int add = ans;
            txt.Content = add.ToString();

            MyFunctionality.Number = ans;

        }
    }
}
