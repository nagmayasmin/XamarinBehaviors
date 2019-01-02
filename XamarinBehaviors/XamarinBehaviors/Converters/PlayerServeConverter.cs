using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviors.Converters
{
    public class PlayerServeConverter : IValueConverter
    {
        public string TrueText
        {
            get
            {
                return "*";
            }

            set
            {
                value = "*";
            }
        }
            
              
        public string FalseText { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return (bool)value ? "*" : "" ;
            
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
