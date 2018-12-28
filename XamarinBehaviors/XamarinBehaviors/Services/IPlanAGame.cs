using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinBehaviors.Models;

namespace XamarinBehaviors.Services
{
   public interface IPlanAGame
    {
        Task<List<PlanAGame>> GetPlanAGameAsync();

        Task<int> SavePlanGame(PlanAGame item);

    }
}
