using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviors.Behaviors
{
   public class EntryAllUpperCase: BaseAttachedBehavior<EntryAllUpperCase, Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {

            entry.TextChanged += Entry_TextChanged;
            base.OnAttachedTo(entry);
        }
            

        protected override void OnDetachingFrom(BindableObject entry)
        {
            ((Entry)entry).TextChanged -= Entry_TextChanged;
            base.OnDetachingFrom(entry);
        }

        // Behavior implementation

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((Entry)sender).Text = ((Entry)sender).Text.ToUpper().ToString();
        }

    }
}
