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
            database.CreateTableAsync<PlayAMatch>().Wait();
        }

        public Task<int> SavePlanGame(PlayAMatch item)
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


        public Task<List<PlayAMatch>> GetPlanAGameAsync()
        {
            return database.Table<PlayAMatch>().ToListAsync();
        }
    }
}
