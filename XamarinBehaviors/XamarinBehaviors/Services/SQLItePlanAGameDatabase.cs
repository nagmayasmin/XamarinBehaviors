using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinBehaviors.Helpers;
using XamarinBehaviors.Models;

namespace XamarinBehaviors.Services
{
   public class SQLitePlanAGameDatabase : IPlanAGame
    {
        readonly SQLiteAsyncConnection database;

      
        public SQLitePlanAGameDatabase()
        {
            var dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("TennisGame.db3");
            database = new SQLiteAsyncConnection(dbPath);

         //   database.DropTableAsync<PlanAGame>().Wait();
            database.CreateTableAsync<PlanAGame>().Wait();
        }

        public Task<int> SavePlanGame(PlanAGame item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                    
                return database.InsertAsync(item);
            }
        }


        public Task<List<PlanAGame>> GetPlanAGameAsync()
        {
            return database.Table<PlanAGame>().ToListAsync();
        }
    }
}
