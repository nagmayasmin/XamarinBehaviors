using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinBehaviors.Models
{
    public class PlanAGame
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Player1 { get; set; }

        [MaxLength(10)]
        public string Player2 { get; set; }

     //   [MaxLength(20)]
      //  public string CurrentScore { get; set; }

        public int NumberOfSets { get; set; }

       // public int Set1 { get; set; }
       // public int Set2 { get; set; }
       // public int Set3 { get; set; }

    }
}
