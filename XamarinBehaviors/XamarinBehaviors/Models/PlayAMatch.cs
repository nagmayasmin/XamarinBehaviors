using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinBehaviors.Models
{
    public class PlayAMatch
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Player1 { get; set; }

        [MaxLength(10)]
        public string Player2 { get; set; }

    
        public string CurrentScore1 { get; set; }
        public string CurrentScore2 { get; set; }

        public bool Player1Serving { get; set; }
        public bool Player2Serving { get; set; }

        public int NumberOfSets { get; set; }

        public int Set11 { get; set; }
        public int Set12 { get; set; }
        public int Set13 { get; set; }

        public int Set21 { get; set; }
        public int Set22 { get; set; }
        public int Set23 { get; set; }

    }
}
