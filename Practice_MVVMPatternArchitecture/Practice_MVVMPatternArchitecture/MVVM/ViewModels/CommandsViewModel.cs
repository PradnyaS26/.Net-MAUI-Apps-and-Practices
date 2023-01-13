using System;
using System.Windows.Input;

namespace Practice_MVVMPatternArchitecture.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public string SearchTerm { get; set; }
        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "Message", "ok");

            });
            SearchCommand = new Command((s) =>
            {
                var data = s;
            });

        }

        public void ShowAlert()
        {
            App.Current.MainPage.DisplayAlert("Title", "Message", "ok");

        }
    }
}

