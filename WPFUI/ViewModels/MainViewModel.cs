//using BLL.DTO;
//using BLL.ServiceInterfaces;
using BLL.DTO;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
//using System.ComponentModel;
//using System.Windows.Input;


//namespace WPFUI.ViewModels
//{
//    internal class MainViewModel
//    {
//        public ICommand AddCommand { get; }
//        public ICommand DeleteCommand { get; }
//        public ICommand SearchCommand { get; }

//        // сервисы
//        private readonly IPassengerService _passengerService;
//        private readonly ITicketService _ticketService;
//        private readonly ITrainService _trainService;

//        // св-во для отображения в таблице

//        public MainViewModel(/*IPassengerService passengerService, ITicketService ticketService, ITrainService trainService*/)
//        {
//            AddCommand = new RelayCommand(Add);
//            DeleteCommand = new RelayCommand(Delete);
//            SearchCommand = new RelayCommand(Search);

//            // сервисы
//            //_passengerService = passengerService;
//            //_ticketService = ticketService;
//            //_trainService = trainService;
//        }

//        private void Add()
//        {
//            throw new NotImplementedException();
//        }

//        private void Delete()
//        {
//            throw new NotImplementedException();
//        }

//        private void Search()
//        {
//            throw new NotImplementedException();
//        }

//        public event PropertyChangedEventHandler PropertyChanged;
//        protected virtual void OnPropertyChanged(string propertyName) =>
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//    }
//}


namespace WPFUI.ViewModels
{
    internal class MainViewModel //: INotifyPropertyChanged
    {
        private readonly TicketViewModel _ticketViewModel;

        // список для выбора в comboBox
        public ObservableCollection<string> Entities { get; }

        public string selectedEntity { get; set; }

        public string SelectedEntity
        {
            get => selectedEntity;
            set
            {
                if (selectedEntity != value)
                {
                    selectedEntity = value;
                    //OnPropertyChanged(nameof(selectedEntity));
                }
            }
        }

        // команды для выполнения операций
        public ICommand LoadCommand { get; }

        public ObservableCollection<object> EntityData { get; set; }

        public MainViewModel(TicketViewModel ticketViewModel)
        {
            // views
            _ticketViewModel = ticketViewModel;

            Entities = new ObservableCollection<string> { "Пассажиры", "Билеты", "Поезда" };

            // привязка команд
            LoadCommand = new RelayCommand(Load);
        }

        void Load()
        {
            if (selectedEntity == "Пассажиры")
            {
                //var tickets = _passengerService.GetAll().ToList();
                //EntityData = new ObservableCollection<PassengerDTO>(passengers);
                _ticketViewModel.LoadTickets();
            }
        }

        //public event PropertyChangedEventHandler? PropertyChanged;
        //protected virtual void OnPropertyChanged(string propertyName) =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}