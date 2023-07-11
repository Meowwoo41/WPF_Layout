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
using System.Windows.Shapes;

namespace Practice_layout
{
    /// <summary>
    /// Window_min.xaml 的互動邏輯
    /// </summary>
    public partial class Window_min : Window
    {
        public Window_min()
        {
            InitializeComponent();
        }
        public static string ?txt_return { get; set; }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if(MinWin_txt.Text != "")
            {
                txt_return = MinWin_txt.Text;
                MessageBoxResult txt =  MessageBox.Show(MinWin_txt.Text);
                if (txt == MessageBoxResult.OK) 
                {
                    DialogResult = true;
                }
                }
            else
            {
                MessageBox.Show("請輸入文字");
            }
        }

        private void btnNO_Click(object sender, RoutedEventArgs e)
        {
            DialogResult= false;
        }
    }
}
