using AutoMapper;
using Levva.Newbies.Coins.Data.Interfaces;
using Levva.Newbies.Coins.Data.Repositories;
using Levva.Newbies.Coins.Domain.Models;
using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;

namespace Levva.Newbies.Coins.Logic.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;
        public TransactionService(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public TransactionDto Create(int userId, CreateTransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _transaction.UserId = userId;
            var transactionCreated = _repository.Create(_transaction);

            return _mapper.Map<TransactionDto>(transactionCreated);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public TransactionDto Get(int Id)
        {
            var transaction = _mapper.Map<TransactionDto>(_repository.Get(Id));
            return transaction;
        }

        public List<TransactionDto> GetAll()
        {
            var transactions = _mapper.Map<List<TransactionDto>>(_repository.GetAll());
            return transactions;
        }

        public List<TransactionDto> SearchByDescription(string search)
        {
            var transactions = _repository.SearchByDescription(search);



            return _mapper.Map<List<TransactionDto>>(transactions);
        }

        public void Update(TransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _repository.Update(_transaction);
        }
    }
}
