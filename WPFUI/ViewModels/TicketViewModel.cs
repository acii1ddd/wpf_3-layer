using BLL.DTO;
using BLL.ServiceInterfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFUI.ViewModels
{
    internal class TicketViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TicketDTO> _tickets = new ObservableCollection<TicketDTO>();
        private readonly ITicketService _ticketService;

        public TicketViewModel(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        internal ObservableCollection<TicketDTO> Tickets
        {
            get => _tickets;
            set { _tickets = value; OnPropertyChanged(); }
        }

        public void LoadTickets()
        {
            var tickets = _ticketService.GetAll();

            // обновляет коллекцию Tickets
            _tickets.Clear();
            foreach (var ticket in tickets)
            {
                _tickets.Add(ticket);
            }
        }

        internal void AddTicket(TicketDTO ticket)
        {
            try
            {
                _ticketService.Add(ticket); // в бд
                _tickets.Add(ticket); // в 
            }
            catch
            {
                throw;
            }
        }

        internal void DeleteTicket(int ticketIdToDelete)
        {
            _ticketService.DeleteById(ticketIdToDelete); // из бд

            var ticketToDelete = _tickets.FirstOrDefault(p => p.Id == ticketIdToDelete);
            if (ticketToDelete != null)
            {
                // Удаляем объект из коллекции
                _tickets.Remove(ticketToDelete);
            }
        }

        internal TicketDTO SearchTicket(int ticketIdToSearch)
        {
            return _ticketService.GetById(ticketIdToSearch); // null либо passengerDTO
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
