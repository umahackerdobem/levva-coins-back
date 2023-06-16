using Levva.Newbies.Coins.Domain.Models;

namespace Levva.Newbies.Coins.Data.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        User Get(int Id);
        List<User> GetAll();
        void Update(User user);
        void Delete(int Id);

        User GetByEmailAndPassword(string email, string password);
    }
}
