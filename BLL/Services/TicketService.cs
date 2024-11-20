using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public void Add(TicketDTO item)
        {
            var ticket = _mapper.Map<Ticket>(item);
            _ticketRepository.Add(ticket);
        }

        public void DeleteById(int id)
        {
            var ticket = _ticketRepository.Get(id);
            if (ticket != null)
            {
                _ticketRepository.Delete(ticket);
            }
        }

        public IEnumerable<TicketDTO> GetAll()
        {
            var tickets = _ticketRepository.GetAll();
            return _mapper.Map<IEnumerable<TicketDTO>>(tickets);
        }

        public TicketDTO? GetById(int id)
        {
            var ticket = _ticketRepository.Get(id);
            return ticket == null ? null : _mapper.Map<TicketDTO>(ticket);
        }

        public void Update(TicketDTO item)
        {
            var ticket = _ticketRepository.Get(item.Id);
            if (ticket != null)
            {
                _mapper.Map(item, ticket); // обновляем ticket с помощью item (Dto)
                _ticketRepository.Update(ticket); // обновляем в репозитории
            }
        }
    }
}
