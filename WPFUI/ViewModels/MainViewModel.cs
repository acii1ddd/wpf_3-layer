using BLL.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace WPFUI.ViewModels
{
    internal class MainViewModel
    {
        public ObservableCollection<string> Entities { get; }

        public string SelectedEntity { get; set; }

        public ICommand ShowCommand { get; }


        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public MainViewModel()
        {
            Entities = new ObservableCollection<string> { "Пассажиры", "Билеты", "Поезда" };
        }

        void Show()
        {
            if (SelectedEntity == "Билеты")
            {
                //CurrentView = new TicketViewModel();
                //
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}