﻿using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ITrainRepository _trainRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, ITrainRepository trainRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _trainRepository = trainRepository;
            _mapper = mapper;
        }

        public void Add(TicketDTO item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Билет не может быть пустым.");
            //var train = _trainRepository.Get(item.Id);
            // проверка id на существование

            if (item.Source == item.Destination)
                throw new ArgumentException("Точка отпавления совпадает с точкой прибытия.", nameof(item.StartTime));

            if (item.StartTime <= DateTime.Now)
                throw new ArgumentException("Некорректная дата отправления.", nameof(item.StartTime));

            if (item.ArrivalTime <= item.StartTime)
                throw new ArgumentException("Время прибытия должно быть больше, чем время отправления.", nameof(item.ArrivalTime));

            if (item.WagonNumber <= 0 && item.WagonNumber > 25)
                throw new ArgumentException("Некорректный номер вагона.", nameof(item.WagonNumber));

            if (item.PlaceNumber <= 0 && item.PlaceNumber > 50)
                throw new ArgumentException("Некорректный номер места.", nameof(item.PlaceNumber));

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
