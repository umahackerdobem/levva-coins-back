using Levva.Newbies.Coins.Domain.Models;

namespace Levva.Newbies.Coins.Data.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);
        Transaction Get(int Id);
        List<Transaction> GetAll();
        void Update(Transaction transaction);
        void Delete(int Id);
        List<Transaction> SearchByDescription(string search);
    }
}
