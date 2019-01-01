using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinBehaviors.Behaviors
{
   public class ToggleSwitchBehavior:  BaseAttachedBehavior<ToggleSwitchBehavior, Switch>
    {
        protected override void OnAttachedTo(Switch sw)
        {
            base.OnAttachedTo(sw);
            sw.Toggled += Sw_Toggled;
           
        }

        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (((Switch)sender).IsToggled)
            {
                Application.Current.MainPage.DisplayAlert("Who is serving", "Player 1", "Cancel");
                App.PlayListViewModel.Player1Serving = ((Switch)sender).IsToggled;
            }
        }

        protected override void OnDetachingFrom(Switch sw)
        {
            base.OnDetachingFrom(sw);
            sw.Toggled -= Sw_Toggled;
        }
    }
}
