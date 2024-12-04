using CommunityToolkit.Mvvm.Input;
using DAL.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WPFUI.Views;

namespace WPFUI.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public  PassengerViewModel PassengerViewModel { get; }
        public TicketViewModel TicketViewModel { get; }
        public TrainViewModel TrainViewModel { get; }

        // список для выбора в comboBox
        public ObservableCollection<string> Entities { get; } = new ObservableCollection<string> { "Пассажиры", "Билеты", "Поезда" };

        // команды для выполнения операций
        public ICommand LoadCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand SearchCommand { get; }


        public ObservableCollection<object> TableData { get; set; }

        public string selectedEntity { get; set; }

        public string SelectedEntity
        {
            get => selectedEntity;
            set
            {
                if (selectedEntity != value)
                {
                    selectedEntity = value;
                    OnPropertyChanged(nameof(selectedEntity));
                }
            }
        }

        public MainViewModel(TicketViewModel ticketViewModel, PassengerViewModel passengerViewModel, TrainViewModel trainViewModel)
        {
            // views
            PassengerViewModel = passengerViewModel;
            TicketViewModel = ticketViewModel;
            TrainViewModel = trainViewModel;

            // привязка команд
            LoadCommand = new RelayCommand(Load);
            AddCommand = new RelayCommand(Add);
            DeleteCommand = new RelayCommand(Delete);
            SearchCommand = new RelayCommand(Search);
        }

        private void Load()
        {
            switch (selectedEntity)
            {
                case "Пассажиры":
                    PassengerViewModel.LoadPassengers();
                    TableData = new ObservableCollection<object>(PassengerViewModel.Passengers);
                    OnPropertyChanged(nameof(TableData));
                    break;

                case "Билеты":
                    TicketViewModel.LoadTickets();
                    TableData = new ObservableCollection<object>(TicketViewModel.Tickets);
                    OnPropertyChanged(nameof(TableData));
                    break;

                case "Поезда":
                    TrainViewModel.LoadTrains();
                    TableData = new ObservableCollection<object>(TrainViewModel.Trains);
                    OnPropertyChanged(nameof(TableData));
                    break;

                default:
                    break;
            }            
        }

        private void Add()
        {
            switch (selectedEntity)
            {
                case "Пассажиры":
                    var addPassengerWindow = new AddPassengerWindow();
                    if (addPassengerWindow.ShowDialog() == true)
                    {
                        var newPassenger = addPassengerWindow.newPassenger;
                        PassengerViewModel.AddPassenger(newPassenger);

                        // изменения
                        TableData = new ObservableCollection<object>(PassengerViewModel.Passengers);
                        OnPropertyChanged(nameof(TableData));
                    }
                    break;

                case "Билеты":
                    var addTicketWindow = new AddTicketWindow();
                    if (addTicketWindow.ShowDialog() == true)
                    {
                        var newTicket = addTicketWindow.newTicket;
                        TicketViewModel.AddTicket(newTicket);

                        // изменения
                        TableData = new ObservableCollection<object>(TicketViewModel.Tickets);
                        OnPropertyChanged(nameof(TableData));
                    }
                    break;

                case "Поезда":
                    var addTrainWindow = new AddTrainWindow();
                    if (addTrainWindow.ShowDialog() == true)
                    {
                        var newTrain = addTrainWindow.newTrain;
                        TrainViewModel.AddTrain(newTrain);

                        // изменения
                        TableData = new ObservableCollection<object>(TrainViewModel.Trains);
                        OnPropertyChanged(nameof(TableData));
                    }
                    break;

                default:
                    break;
            }
        }

        private void Delete()
        {
            switch (selectedEntity)
            {
                case "Пассажиры":
                    var getIdWindow = new GetIdWindow(TableData);
                    if (getIdWindow.ShowDialog() == true)
                    {
                        var passengerIdToDelete = getIdWindow.InputId;
                        PassengerViewModel.DeletePassenger(passengerIdToDelete);

                        // изменения
                        TableData = new ObservableCollection<object>(PassengerViewModel.Passengers);
                        OnPropertyChanged(nameof(TableData));
                    }
                    break;

                case "Билеты":
                    getIdWindow = new GetIdWindow(TableData);
                    if (getIdWindow.ShowDialog() == true)
                    {
                        var ticketIdToDelete = getIdWindow.InputId;
                        TicketViewModel.DeleteTicket(ticketIdToDelete);

                        // изменения
                        TableData = new ObservableCollection<object>(TicketViewModel.Tickets);
                        OnPropertyChanged(nameof(TableData));
                    }
                    break;

                case "Поезда":
                    getIdWindow = new GetIdWindow(TableData);
                    if (getIdWindow.ShowDialog() == true)
                    {
                        var trainsIdToDelete = getIdWindow.InputId;
                        TrainViewModel.DeleteTrain(trainsIdToDelete);

                        // изменения
                        TableData = new ObservableCollection<object>(TrainViewModel.Trains);
                        OnPropertyChanged(nameof(TableData));
                    }
                    break;

                default:
                    break;
            }
        }

        private void Search()
        {
            switch (selectedEntity)
            {
                case "Пассажиры":
                    var getIdWindow = new GetIdWindow(TableData);
                    if (getIdWindow.ShowDialog() == true)
                    {
                        var passengerSearchId = getIdWindow.InputId;
                        var passenger = PassengerViewModel.SearchPassenger(passengerSearchId);

                        if (passenger != null)
                        {
                            MessageBox.Show($"Имя: {passenger.FirstName}; Фамилия: {passenger.SecondName}");
                            OnPropertyChanged(nameof(TableData));
                        }
                        else
                        {
                            MessageBox.Show("Нет такого пассажира.");
                        }
                    }
                    break;

                case "Билеты":
                    getIdWindow = new GetIdWindow(TableData);
                    if (getIdWindow.ShowDialog() == true)
                    {
                        var ticketSearchId = getIdWindow.InputId;
                        var ticket = TicketViewModel.SearchTicket(ticketSearchId);

                        if (ticket != null)
                        {
                            MessageBox.Show($"Место оправления: {ticket.Source}; Место прибытия: {ticket.Destination}; " +
                                            $"Дата отправления: {ticket.StartTime}; Время прибытия: {ticket.ArrivalTime}; " +
                                            $"Номер вагона: {ticket.WagonNumber}; Номер места: {ticket.PlaceNumber}");
                            OnPropertyChanged(nameof(TableData));
                        }
                        else
                        {
                            MessageBox.Show("Нет такого билета.");
                        }
                    }
                    break;

                case "Поезда":
                    getIdWindow = new GetIdWindow(TableData);
                    if (getIdWindow.ShowDialog() == true)
                    {
                        var trainSearchId = getIdWindow.InputId;
                        var train = TrainViewModel.SearchTrain(trainSearchId);

                        if (train != null)
                        {
                            MessageBox.Show($"Маршрут: {train.Route}; Количество мест: {train.Capacity}; Количество вагонов: {train.WagonCount}");
                            OnPropertyChanged(nameof(TableData));
                        }
                        else
                        {
                            MessageBox.Show("Нет такого поезда.");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}