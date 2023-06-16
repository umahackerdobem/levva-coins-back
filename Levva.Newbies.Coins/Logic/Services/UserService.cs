using AutoMapper;
using Levva.Newbies.Coins.Data.Interfaces;
using Levva.Newbies.Coins.Domain.Models;
using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;

namespace Levva.Newbies.Coins.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public UserDto Create(CreateUserDto user)
        {
            var _user = _mapper.Map<User>(user);
            var userCreated = _repository.Create(_user);

            return _mapper.Map<UserDto>(userCreated);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public UserDto Get(int Id)
        {
            var user = _mapper.Map<UserDto>(_repository.Get(Id));
            return user;
        }

        public List<UserDto> GetAll()
        {
            var users = _mapper.Map<List<UserDto>>(_repository.GetAll());
            return users;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return _repository.GetByEmailAndPassword(email, password);
        }

        public void Update(UserDto user)
        {
            var _user = _mapper.Map<User>(user);
            _repository.Update(_user);
        }
    }
}
