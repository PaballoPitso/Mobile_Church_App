using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace projectChurch.SesFolder
{
    class InverseBoolConverter : IValueConverter
    {
        public object Convert(object value , Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }
        public object ConvertBack(object value  , Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}
