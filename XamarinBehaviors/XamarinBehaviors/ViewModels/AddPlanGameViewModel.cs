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


        int _set12;

        public int Set12
        {
            get => _set12;
            set => SetProperty(ref _set12, value);
        }

        int _set22;

        public int Set22
        {
            get => _set22;
            set => SetProperty(ref _set22, value);
        }


        int _set13;

        public int Set13
        {
            get => _set13;
            set => SetProperty(ref _set13, value);
        }

        int _set23;

        public int Set23
        {
            get => _set23;
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
                        Player1Serving = this.Player1Serving,
                        Player2Serving = this.Player2Serving,
                        Set11 = AddSet11(CurrentScore1),
                        Set21 = AddSet21(CurrentScore2),
                        Set12 = AddSet12(CurrentScore1),
                        Set22 = AddSet22(CurrentScore2)
                    //    Set13 = AddSet13(this.CurrentScore1),
                     //   Set23 = AddSet23(this.CurrentScore2)

                    });

                });

            }

            catch(Exception ex)
            {

            }
        }

        private int AddSet11(string currentScore2)
        {
           Set11 = (Set11 < 6 && CurrentScore1 == "GAME") ? Set11 + 1 : Set11;
            if (CurrentScore1 == "GAME")
            {
                CurrentScore1 = "0";
                CurrentScore2 = "0";
            }

            return Set11;
                     
        }

        private int AddSet21(string currentScore1)
        {
           Set21 = (Set21 < 6 && CurrentScore2 == "GAME") ? Set21 + 1 : Set21;

            if (CurrentScore2 == "GAME")
            {
                CurrentScore2 = "0";
                CurrentScore1 = "0";
            }

                return Set21;
        }


        private int AddSet12(string currentScore1)
        {
            Set12 = (CurrentScore1 == "GAME" && (Set11 == 6 || Set12 == 6)) ? Set12 + 1 : Set12;
            if (CurrentScore1 == "GAME")
            {
                CurrentScore1 = "0";
                CurrentScore2 = "0";
            }

            return Set12;
                       
        }

        private int AddSet22(string currentScore2)
        {
            Set22 = (CurrentScore2 == "GAME" && (Set11 == 6 || Set12 == 6)) ? Set22 + 1 : Set22;
            if (CurrentScore1 == "GAME")
            {
                CurrentScore1 = "0";
                CurrentScore2 = "0";
            }
            return Set22;

        }

        /*
                private int AddSet13(string currentScore2)
                {
                    if (CurrentScore1 == "GAME")
                    {
                        CurrentScore1 = "0";
                        CurrentScore2 = "0";
                        return Set13 += 1;
                    }

                    return Set13;
                }

                private int AddSet23(string currentScore1)
                {
                    if (CurrentScore2 == "GAME")
                    {
                        CurrentScore1 = "0";
                        CurrentScore2 = "0";
                        return Set23 += 1;

                    }
                    return Set23;
                }

            */

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

        string _currentScore1 = "0";

        public string CurrentScore1
        {
            get => _currentScore1;
            set => SetProperty(ref _currentScore1, value);
        }

        string _currentScore2 = "0";

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



   
    




