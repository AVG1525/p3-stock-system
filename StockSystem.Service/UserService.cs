using AutoMapper;
using StockSystem.Domain.Entities;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Domain.Request;
using StockSystem.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<UserResponse> GetAll() =>
            _mapper.Map<IEnumerable<UserResponse>>(_userRepository.GetAll().ToList());

        public UserResponse GetUserById(string id) =>
            _mapper.Map<UserResponse>(_userRepository.GetById(Convert.ToInt32(id)));

        public UserResponse PostUser(UserRequest userResquest) =>
            _mapper.Map<UserResponse>(_userRepository.PostUser(_mapper.Map<User>(userResquest)));
    }
}
