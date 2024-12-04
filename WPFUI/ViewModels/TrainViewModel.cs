using BLL.DTO;
using BLL.ServiceInterfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFUI.ViewModels
{
    internal class TrainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TrainDTO> _trains = new ObservableCollection<TrainDTO>();
        private readonly ITrainService _trainService;
        
        public TrainViewModel(ITrainService trainService)
        {
            _trainService = trainService;
        }

        internal ObservableCollection<TrainDTO> Trains
        {
            get => _trains;
            set { _trains = value; OnPropertyChanged(); }
        }

        public void LoadTrains()
        {
            var trains = _trainService.GetAll();

            // обновляет коллекцию trains
            _trains.Clear();
            foreach (var ticket in trains)
            {
                _trains.Add(ticket);
            }
        }

        internal void AddTrain(TrainDTO train)
        {
            _trainService.Add(train); // в бд
            _trains.Add(train); // в коллекцию
        }

        internal void DeleteTrain(int trainIdToDelete)
        {
            _trainService.DeleteById(trainIdToDelete); // из бд

            var trainToDelete = _trains.FirstOrDefault(p => p.Id == trainIdToDelete);
            if (trainToDelete != null)
            {
                // Удаляем объект из коллекции
                _trains.Remove(trainToDelete);
            }
        }

        internal TrainDTO SearchTrain(int trainIdToSearch)
        {
            return _trainService.GetById(trainIdToSearch); // null либо passengerDTO
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
