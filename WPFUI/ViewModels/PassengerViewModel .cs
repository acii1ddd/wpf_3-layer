using BLL.DTO;
using BLL.ServiceInterfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFUI.ViewModels
{
    internal class PassengerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<PassengerDTO> _passengers = new ObservableCollection<PassengerDTO>();
        private readonly IPassengerService _passengerService;

        public PassengerViewModel(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }
        internal ObservableCollection<PassengerDTO> Passengers
        {
            get => _passengers;
            set { _passengers = value; OnPropertyChanged(); }
        }
        
        public void LoadPassengers()
        {
            var passengers = _passengerService.GetAll();

            _passengers.Clear();
            foreach (var passenger in passengers)
            {
                _passengers.Add(passenger);
            }
        }

        internal void AddPassenger(PassengerDTO passenger)
        {
            _passengerService.Add(passenger); // в бд
            _passengers.Add(passenger); // в коллекцию
        }

        internal void DeletePassenger(int passengerIdToDelete)
        {
            _passengerService.DeleteById(passengerIdToDelete); // из бд

            var passengerToDelete = _passengers.FirstOrDefault(p => p.Id == passengerIdToDelete);
            if (passengerToDelete != null)
            {
                // Удаляем объект из коллекции
                _passengers.Remove(passengerToDelete);
            }
        }

        internal PassengerDTO SearchPassenger(int passengerIdToSearch)
        {
            return _passengerService.GetById(passengerIdToSearch); // null либо passengerDTO
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
