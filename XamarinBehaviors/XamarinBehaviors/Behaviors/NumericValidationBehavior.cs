using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviors.Behaviors
{
   public class NumericValidationBehavior : BaseAttachedBehavior<NumericValidationBehavior, Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            base.OnAttachedTo(entry);
            entry.TextChanged += NumericValidation;
        }

       
        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
            entry.TextChanged -= NumericValidation;
        }


        // Behavior Impelmentation

        private void NumericValidation(object sender, TextChangedEventArgs e)
        {
            var text = ((Entry)sender).Text;
            bool isValid = double.TryParse(text, out double result);

            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;

          
        }


    }
}
