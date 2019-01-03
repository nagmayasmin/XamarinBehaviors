using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinBehaviors.Common;
using XamarinBehaviors.Services;
using System.Threading.Tasks;

namespace XamarinBehaviors.ViewModels
{
    public class AddPlanGameViewModel : ObservableBase
    {
        public ICommand AddPlanAGame
        {
            get;
        }

        public ICommand ToggleSwitchPlayer1
        {
            get { return new ToggleSwitchPlayer1(this);  }
        }


        int _set11;

        public int Set11
        {
            get => _set11;
            set => SetProperty(ref _set11, value);
        }

        int _set21;

        public int Set21
        {
            get => _set21;
            set => SetProperty(ref _set21, value);
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
                        Player1Serving = App.PlayListViewModel.Player1Serving,
                        Player2Serving = App.PlayListViewModel.Player2Serving,
                        Set11 = AddSet11(this.CurrentScore1),
                        Set21 = AddSet21(this.CurrentScore2)

                    });

                });

                AddSet11(CurrentScore1);
                AddSet21(CurrentScore2);
            }

            catch(Exception ex)
            {

            }
        }

        private int AddSet11(string currentScore2)
        {
            if(CurrentScore1 == "GAME")
            {
                CurrentScore1 = "LOVE";
                CurrentScore2 = "LOVE";
                return Set11 += 1;
            }

            return Set11;
        }

        private int AddSet21(string currentScore1)
        {
            if (CurrentScore2 == "GAME")
            {
                CurrentScore1 = "LOVE";
                CurrentScore2 = "LOVE";
                return Set21 += 1;
               
            } 
            return Set21;
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

        internal  void DoExecute()
        {
            dispAlert();
        }

        private async void dispAlert()
        {
            await Application.Current.MainPage.DisplayAlert("Alert", "This Is Alert.", "OK");
        }
    }

    internal class ToggleSwitchPlayer1 : ICommand
    {
        private AddPlanGameViewModel addPlanGameViewModel;

        public ToggleSwitchPlayer1(AddPlanGameViewModel addPlanGameViewModel)
        {
            this.addPlanGameViewModel = addPlanGameViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            addPlanGameViewModel.DoExecute();
        }

       
    }
}   



   
    




