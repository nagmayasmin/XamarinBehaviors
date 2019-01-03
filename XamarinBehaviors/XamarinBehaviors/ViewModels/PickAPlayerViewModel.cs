using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinBehaviors.Common;
using XamarinBehaviors.Models;

namespace XamarinBehaviors.ViewModels
{
    public class PickAPlayerViewModel :ObservableBase
    {
       public string pickPlayer { get; set; }

        public PickAPlayerViewModel()
        {
            ObservableCollection<PickPlayer> pickPlayers = new ObservableCollection<PickPlayer>();
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
