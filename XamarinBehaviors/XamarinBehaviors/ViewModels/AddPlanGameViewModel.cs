using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinBehaviors.Common;
using XamarinBehaviors.Services;

namespace XamarinBehaviors.ViewModels
{
    public class AddPlanGameViewModel : ObservableBase
    {
        public ICommand AddPlanAGame
        {
            get;
        }

        int _numberOfSets;

        public int NumberOfSets
        {
            get => _numberOfSets;
            set => SetProperty(ref _numberOfSets, value);
        }
        public AddPlanGameViewModel()
        {
            try
            {
               AddPlanAGame = new Command(async () =>
                {
                    var todoList = await DependencyService.Get<IPlanAGame>().SavePlanGame(new Models.PlanAGame()
                    {
                        Player1 = this.Player1,
                        Player2 = this.Player2,
                        NumberOfSets = this.NumberOfSets,
                        CurrentScore1 = this.CurrentScore1,
                        CurrentScore2= this.CurrentScore2,
                        Player1Serving = this.Player1Serving,
                        Player2Serving = this.Player2Serving

                    });

                });
            }

            catch(Exception ex)
            {

            }
        }


        string _player1;

        public string Player1
        {
            get => _player1;
            set => SetProperty(ref _player1, value);
        }

        string _player2;

        public string Player2
        {
            get => _player2;
            set => SetProperty(ref _player2, value);
        }

        string _currentScore1;

        public string CurrentScore1
        {
            get => _currentScore1;
            set => SetProperty(ref _currentScore1, value);
        }

        string _currentScore2;

        public string CurrentScore2
        {
            get => _currentScore2;
            set => SetProperty(ref _currentScore2, value);
        }

        bool _player1serving;

        public bool Player1Serving
        {
            get => _player1serving;
            set => SetProperty(ref _player1serving, value);
        }

        bool _player2serving;

        public bool Player2Serving
        {
            get => _player2serving;
            set => SetProperty(ref _player2serving, value);
        }
    }

}   



   
    




