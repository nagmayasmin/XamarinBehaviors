using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace XamarinBehaviors.Behaviors
{
    public class EntryNoSpecialCharacters : BaseAttachedBehavior<EntryNoSpecialCharacters, Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += NoSpecialCharacter;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= NoSpecialCharacter;
            base.OnDetachingFrom(entry);
        }

        // Behavior Implementation
        private void NoSpecialCharacter(object sender, TextChangedEventArgs e)
        {
            var regex = @"[^0-9a-zA-Z,.!? ]+";
            var currentText = ((Entry)sender).Text;

            if (Regex.IsMatch(currentText, regex))
               {
                 ((Entry)sender).Text = Regex.Replace(currentText, regex, "") ;
               }
        }
    }
}
