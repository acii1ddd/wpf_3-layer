using BLL.DTO;
using BLL.ServiceInterfaces;
using BLL.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WPFUI.ViewModels
{
    internal class TicketViewModel
    {
        private readonly ITicketService _ticketService;

        // для отображения билетов в таблице
        public ObservableCollection<TicketDTO> Tickets { get; private set; }
        
        // команда для загрузки данных
        public ICommand LoadTicketsCommand { get; }

        public TicketViewModel(ITicketService ticketService)
        {
            _ticketService = ticketService;
            Tickets = new ObservableCollection<TicketDTO>();
            LoadTicketsCommand = new RelayCommand(LoadTickets);
        }

        private void LoadTickets()
        {
            var tickets = _ticketService.GetAll();

            // обновляет коллекцию Tickets
            Tickets.Clear();
            foreach (var ticket in tickets)
            {
                Tickets.Add(ticket);
            }
        }
    }
}
