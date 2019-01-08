using System;
using System.Collections.Generic;
using System.Text;
using XamarinBehaviors.Models;
using System.Linq;
using XamarinBehaviors.Common;

namespace XamarinBehaviors.ViewModels
{
    public class GameScoresViewModel : ObservableBase
    {
        public IList<GameScores> AllGameScores { get { return GameScoresData.AllGameScores; } }

        GameScores selectedScores;

        public GameScores SelectedScores
        {
            get => selectedScores;
            set => SetProperty(ref selectedScores, value);
        }
    }
}

