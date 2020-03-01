using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace WeatherApp
{
    class FahrenheitToCelsiusConvertet : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Math.Truncate(((double)value - 32) * 5 / 9).ToString() + "\x00B0" + "C";
        }    
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }     
    }
}
