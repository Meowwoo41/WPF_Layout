using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Dashboard.xaml 的互動邏輯
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
            Date.Text = DateTime.Today.ToString("yyyy/MM/dd");

            //讓小日曆浮空，不影響布局
            calendarPopup.IsOpen = !calendarPopup.IsOpen;
        }

        private void CalendarShow_Click(object sender, RoutedEventArgs e)
        {
            if (Cus_Calendar.Visibility == Visibility.Collapsed)
            {
                Cus_Calendar.Visibility = Visibility.Visible;
            }
            else if (Cus_Calendar.Visibility == Visibility.Visible)
            {
                Cus_Calendar.Visibility = Visibility.Collapsed;
            }
        }

        private void SelectDateChanged_Click(object sender, SelectionChangedEventArgs e)
        {
            if(sender is Calendar calendar && calendar.SelectedDate.HasValue)
            {
                DateTime selectedDate = calendar.SelectedDate.Value;
                Date.Text = selectedDate.ToString("yyyy/MM/dd");

                Cus_Calendar.Visibility = Visibility.Collapsed;
            }
        }
    }
}
