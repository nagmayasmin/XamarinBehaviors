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
                var swId = ((Switch)sender).StyleId;

                if (swId == "switch1")
                {
                    App.PlayListViewModel.Player1Serving = true;
                    App.PlayListViewModel.Player2Serving = false;

                    Switch sw = new Switch() ;
                    sw.StyleId = "switch2";

                    ((Switch)sw).IsToggled = false;

                }
                
                //  ((Switch)sender).IsToggled = false;
                }
                else
                {
                App.PlayListViewModel.Player2Serving = true;
                App.PlayListViewModel.Player1Serving = false;

                var sw = new Switch();
                sw.StyleId = "switch1";

                ((Switch)sw).IsToggled = false;
            }
        }
        

        protected override void OnDetachingFrom(Switch sw)
        {
            base.OnDetachingFrom(sw);
            sw.Toggled -= Sw_Toggled;
        }
    }
}
