using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
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

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //視窗最大，不遮蓋開始功能列表
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            //一開始就顯示首頁
            FramePage.NavigationService.Navigate(new Dashboard());
        }

        public static object ?title;
        //關閉視窗提示
        private void Close_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult result = MessageBox.Show("是否關閉視窗?", "提示", MessageBoxButton.YesNo,MessageBoxImage.Question);
           
           if (result == MessageBoxResult.Yes) 
            {
                Close();
            }
        }

        //視窗放大縮小
        private void FullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        //視窗最小化
        private void Minimize_Click(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        //拖曳視窗
        private void Drag_ClicK(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void btn_Page(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string? pageName =clickedButton.Name;
            title = clickedButton.Name;
            if (!string.IsNullOrEmpty(pageName))
            {
                FramePage.Source = new Uri(pageName + ".xaml", UriKind.Relative);

                switch(Convert.ToString(clickedButton.Name))
                {
                    case "Dashboard":
                        PageName.Text = "▶ Dashboard";
                        break;
                    case "UIElements":
                        PageName.Text = "▶ UI Elements";
                        break;
                    case "Charts":
                        PageName.Text = "▶ Charts";
                        break;
                    case "TabsPanels":
                        PageName.Text = "▶ Tabs＆Panels";
                        break;
                    case "ResponsiveTables":
                        PageName.Text = "▶ Responsive Tables";
                        break;
                    case "Forms":
                        PageName.Text = "▶ Forms";
                        break;
                    case "MultiLevelDropdown":
                        PageName.Text = "▶ Multi-Level Dropdown";
                        break;
                    case "EmptyPage":
                        PageName.Text = "▶ Empty Page";
                        break;
                }
            }
        }
    }
}
