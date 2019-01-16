using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviors.Converters
{
    public class LabelToSwitchConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int Set11;
            if (value != null && targetType.Name != "Object")
            {
                Set11 = (Int32)value;
                return (Set11 % 2 == 0) ? true : false;
            }

            return false;
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
