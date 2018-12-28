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
   public class SQLItePlanAGameDatabase : IPlanAGame
    {
        readonly SQLiteAsyncConnection database;

        public SQLItePlanAGameDatabase()
        {
            var dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("TennisGame.db3");
            database = new SQLiteAsyncConnection(dbPath);
        }


        public SQLItePlanAGameDatabase(string dbPath)
        {
            dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("TennisGame.db3");
            database = new SQLiteAsyncConnection(dbPath);

            //  database.DropTableAsync<PlayDayTime>().Wait();
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
                item.Player1 = "Nagma";
                item.Player2 = "Ayesha";
                item.NumberOfSets = 3;
                
                return database.InsertAsync(item);
            }
        }


        public Task<List<PlanAGame>> GetPlanAGameAsync()
        {
            return database.Table<PlanAGame>().ToListAsync();
        }
    }
}
