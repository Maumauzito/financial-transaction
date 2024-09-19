using AutoMapper;
using TransacaoFinanceira.Appilcation.DTOs;
using TransacaoFinanceira.Appilcation.Service.Interfaces;
using TransacaoFinanceira.Domain.Entities;
using TransacaoFinanceira.Infrastructure.Repositories.Interfaces;

namespace TransacaoFinanceira.Appilcation.Service
{
    public class TransactionServices : ITransactionServices
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionServices(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Transaction> CreateTransactionAsync(TransactionDTO transaction)
        {
            var entity = _mapper.Map(transaction, new Transaction());

            await _repository.Add(entity);

            return entity;
        }

        public async Task<List<Transaction>> GetAllTransactionsAsync()
        {
            var transactions = await _repository.GetAllAsync();

            return transactions;

        }

        public async Task<Transaction> GetTransactionByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }
    }
}
