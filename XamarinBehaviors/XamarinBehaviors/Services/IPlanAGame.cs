using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinBehaviors.Models;

namespace XamarinBehaviors.Services
{
   public interface IPlanAGame
    {
        Task<List<PlayAMatch>> GetPlanAGameAsync();

        Task<int> SavePlanGame(PlayAMatch item);

    }
}
