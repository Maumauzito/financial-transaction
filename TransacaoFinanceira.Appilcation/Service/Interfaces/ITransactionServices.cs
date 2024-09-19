using TransacaoFinanceira.Appilcation.DTOs;
using TransacaoFinanceira.Domain.Entities;

namespace TransacaoFinanceira.Appilcation.Service.Interfaces
{
    public interface ITransactionServices
    {
        Task<Transaction> CreateTransactionAsync(TransactionDTO transaction);
        Task<Transaction> GetTransactionByIdAsync(int id);
        Task<List<Transaction>> GetAllTransactionsAsync();
    }
}
