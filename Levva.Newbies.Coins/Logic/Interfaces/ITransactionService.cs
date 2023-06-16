using Levva.Newbies.Coins.Logic.Dtos;

namespace Levva.Newbies.Coins.Logic.Interfaces
{
    public interface ITransactionService
    {
        TransactionDto Create(int userId, CreateTransactionDto transaction);
        TransactionDto Get(int Id);
        List<TransactionDto> GetAll();
        void Update(TransactionDto transaction);
        void Delete(int Id);
    }
}
