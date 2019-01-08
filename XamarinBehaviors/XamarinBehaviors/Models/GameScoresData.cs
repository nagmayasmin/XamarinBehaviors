using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBehaviors.Models
{
  public static  class GameScoresData
    {
        public static IList<GameScores> AllGameScores { get; set; }

        static GameScoresData()
        {
            AllGameScores = new List<GameScores>()
            {
                new GameScores{ Scores="0"},
                new GameScores{ Scores="15"},
                new GameScores{ Scores="30"},
                new GameScores{ Scores="40"},
                new GameScores{ Scores="AD"},
                new GameScores{ Scores="GAME"}
            };

        }
    }
}
