using Levva.Newbies.Coins.Domain.Models;
using Levva.Newbies.Coins.Logic.Dtos;

namespace Levva.Newbies.Coins.Logic.Interfaces
{
    public interface IUserService
    {
        UserDto Create(CreateUserDto user);
        UserDto Get(int Id);
        List<UserDto> GetAll();
        void Update(UserDto user);
        void Delete(int Id);

        User GetByEmailAndPassword(string email, string password);
    }
}
