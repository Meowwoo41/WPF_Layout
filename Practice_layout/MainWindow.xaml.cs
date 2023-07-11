using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.RightsManagement;
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
using Microsoft.Win32;

namespace Practice_layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string ?save;
        //顯示TextBox內容+今天中文星期
        private void Msg_Click(object sender, RoutedEventArgs e)
        {
            //主視窗操作
            if(Window_min.txt_return == null && txt_msg.Text != "")
            {
                save = txt_msg.Text;
                string result = save;
                MessageBox.Show("今天" + Week.result + "!" + Environment.NewLine + "【" + result + "】");
                Window_min.txt_return = null;
                save = null;    
            }
            else if(Window_min.txt_return == null && txt_msg.Text == "")
            {
                MessageBox.Show("Text內容不能為空白值!","提示",MessageBoxButton.OK,MessageBoxImage.Question);
            }

            //小視窗操作變動
            if (Window_min.txt_return != null)
            {
                save = Window_min.txt_return;
                string result = Window_min.txt_return;
                txt_msg.Text = result;
                MessageBox.Show("今天" + Week.result + "!" + Environment.NewLine + "【" + result + "】");
                Window_min.txt_return = null;
                save = null;
            }
            /*else if(Window_min.txt_return != null && save != null)
            {
                if(Window_min.txt_return != txt_msg.Text)
                {
                    save = Window_min.txt_return;
                    string result = save.ToString();

                    txt_msg.Text = result;
                    MessageBox.Show("今天" + Week.result + "!" + Environment.NewLine + "【" + result + "】");
                    Window_min.txt_return = null;
                }
                else
                {
                    string result = save.ToString();
                    txt_msg.Text = result;
                    MessageBox.Show("今天" + Week.result + "!" + Environment.NewLine + "【" + result + "】");
                }
            }*/
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult result =MessageBox.Show("是否刪除","提示",MessageBoxButton.YesNo,MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes) 
            {
                txt_msg.Clear();
                Window_min.txt_return = null;
                save = null;
            }
        }

        //關閉視窗提示
        private void Close_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("是否關閉", "警告", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {               
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        //開啟小視窗
        private void Min_windows_Click(object sender, RoutedEventArgs e)
        {
            Window_min min_Windows = new Window_min();
            min_Windows.ShowDialog();//開啟Window_min
            /*if(result ==null)
            {
                MessageBox.Show("尚未設置");
            }
            else if(result == true) 
            {
            }
            else if(result == false)
            {
            }*/
        }

        //開啟文件
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open_FileDialog = new OpenFileDialog();
            open_FileDialog.Filter = "文本文件 (*.txt)|*.txt|PNG (*.png)|*.png|所有文件 (*.*)|*.*";
            if (open_FileDialog.ShowDialog() == true)
            {
                string File_name = open_FileDialog.FileName;
                MessageBox.Show("已開啟"+File_name);
            }
            else
            {
                MessageBox.Show("已關閉");
            }
        }

        //儲存檔案
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save_FileDialog = new SaveFileDialog();
            save_FileDialog.Filter = "文本文件 (*.txt)|*.txt|PNG (*.png)|*.png";
            if(save_FileDialog.ShowDialog() == true)
            {
                MessageBox.Show(save_FileDialog.FileName);
            }
        }
    }
}
