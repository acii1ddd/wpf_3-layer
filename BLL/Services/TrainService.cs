using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class TrainService : ITrainService
    {
        private readonly ITrainRepository _trainRepository;
        private readonly IMapper _mapper;

        public TrainService(ITrainRepository trainRepository, IMapper mapper)
        {
            _trainRepository = trainRepository;
            _mapper = mapper;
        }

        public void Add(TrainDTO item)
        {
            var ticket = _mapper.Map<Train>(item);
            _trainRepository.Add(ticket);
        }

        public void DeleteById(int id)
        {
            var train = _trainRepository.Get(id);
            if (train != null)
            {
                _trainRepository.Delete(train);
            }
        }

        public IEnumerable<TrainDTO> GetAll()
        {
            var trains = _trainRepository.GetAll();
            return _mapper.Map<IEnumerable<TrainDTO>>(trains);
        }

        public TrainDTO? GetById(int id)
        {
            var train = _trainRepository.Get(id);
            return train == null ? null : _mapper.Map<TrainDTO>(train); // null если нету
        }

        public void Update(TrainDTO item)
        {
            var train = _trainRepository.Get(item.Id);
            if (train != null)
            {
                _mapper.Map(item, train);
                _trainRepository.Update(train);
            }
        }
    }
}
