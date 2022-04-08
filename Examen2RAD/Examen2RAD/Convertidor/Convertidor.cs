using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.IO;

namespace Examen2RAD.Convertidor
{
    public class Convertidor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ImageSource setrecorse = null;
            if(value != null)
            {
                byte[] imageasbyte = (byte[])value;
                setrecorse = ImageSource.FromStream(() => new MemoryStream(imageasbyte));
            }
            return setrecorse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
