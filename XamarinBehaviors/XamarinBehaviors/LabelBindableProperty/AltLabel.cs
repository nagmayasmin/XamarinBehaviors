using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviors.LabelBindableProperty
{
   public class AltLabel : Label
    {
        public static BindableProperty TextChangedProperty = BindableProperty.Create(nameof(TextChanged), typeof(string), typeof(AltLabel), string.Empty, propertyChanged: OnTextChanged);

        
        public string TextChanged
        {
            get { return (string)GetValue(TextChangedProperty); }
            set { SetValue(TextChangedProperty, value); }
        }

        static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((AltLabel)bindable).OnTextChanged((string)oldValue, (string)newValue);
            
        }

        private void OnTextChanged(string oldValue, string newValue)
        {
            SetLabelText(newValue);
           // bool isChanged = oldValue == newValue ? true : false;
        }

        private void SetLabelText(string newValue)
        {
            Text = newValue;
        }
    }
}
