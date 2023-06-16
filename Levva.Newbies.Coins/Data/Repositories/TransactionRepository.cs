using Levva.Newbies.Coins.Data.Interfaces;
using Levva.Newbies.Coins.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Levva.Newbies.Coins.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Context _context;
        public TransactionRepository(Context context)
        {
            _context = context;
        }

        public Transaction Create(Transaction transaction)
        {
            transaction.Date = DateTime.Now;
            _context.Transaction.Add(transaction);
            _context.SaveChanges();

            return transaction;
        }

        public void Delete(int Id)
        {
            var transaction = _context.Transaction.Find(Id);
            _context.Transaction.Remove(transaction);
            _context.SaveChanges();
        }

        public Transaction Get(int Id)
        {
            return _context.Transaction.Find(Id);
        }

        public List<Transaction> GetAll()
        {
            return _context.Transaction.Include(x => x.Category).OrderByDescending(x => x.Date).AsNoTracking().ToList();
        }

        public List<Transaction> SearchByDescription(string search)
        {


            return _context.Transaction.Include(x => x.Category)

                            .Where(x =>

                                    EF.Functions.Like(x.Description, $"%{search}%") ||

                                    EF.Functions.Like(x.Category.Description, $"%{search}%"))

                            .OrderByDescending(x => x.Date)

                            .ToList();
        }

        public void Update(Transaction transaction)
        {
            _context.Transaction.Update(transaction);
            _context.SaveChanges();
        }
    }
}
