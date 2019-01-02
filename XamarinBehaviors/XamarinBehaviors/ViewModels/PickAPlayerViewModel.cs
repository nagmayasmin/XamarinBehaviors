using System;
using System.Collections.Generic;
using System.Text;
using XamarinBehaviors.Common;
using XamarinBehaviors.Models;

namespace XamarinBehaviors.ViewModels
{
    public class PickAPlayerViewModel :ObservableBase
    {
     
        public PickAPlayerViewModel()
        {
            List<PickPlayer> pickPlayers = new List<PickPlayer>();
            pickPlayers.Add(new PickPlayer()
            {
                Name = "Player1"
              
            });

            pickPlayers.Add(new PickPlayer()
            {
                Name = "Player2"

            });

        }
    }
}
