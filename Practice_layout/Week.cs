using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practice_layout
{
    class Week 
    {
        public enum ChineseWeek
        {
            星期天,
            星期一,
            星期二,
            星期三,
            星期四,
            星期五,
            星期六
        }
        public static int today = (int)DateTime.Now.DayOfWeek;
        public static object result = (ChineseWeek)today;
    }
}
