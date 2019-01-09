using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinBehaviors.LabelBindableProperty;

namespace XamarinBehaviors.Triggers
{
    public class TextChangedTriggerAction : TriggerAction<AltLabel>
    {
        protected override void Invoke(AltLabel sender)
        {
            string oldScoreValue = ((AltLabel)sender).Text;
         //   bool isChanged = oldScoreValue == 
        }
    }
}
