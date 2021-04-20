using AutoMapper;
using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;

namespace StockSystem.Service
{
    public class UserService : ServiceBase, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserResponse GetUserById(string id) =>
            _mapper.Map<UserResponse>(_userRepository.GetUserById(id));

        public UserResponse PostUser(UserResquest userResquest) =>
            _mapper.Map<UserResponse>(_userRepository.PostUser(_mapper.Map<User>(userResquest)));
    }
}
