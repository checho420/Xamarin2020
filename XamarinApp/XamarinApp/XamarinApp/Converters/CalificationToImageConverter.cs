using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinApp.Converters
{
    public class CalificationToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;
            var calificacion = (int)value;
            if (calificacion < 2)
                return "bad";
            else if (calificacion >= 2 && calificacion < 4)
                return "neutro";
            else if (calificacion >= 4)
                return "bueno";
            else
                return "bueno";
        }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
