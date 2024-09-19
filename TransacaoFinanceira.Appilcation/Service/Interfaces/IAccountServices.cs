using TransacaoFinanceira.Appilcation.DTOs;
using TransacaoFinanceira.Domain.Entities;

namespace TransacaoFinanceira.Appilcation.Service.Interfaces
{
    public interface IAccountServices
    {
        Task<Account> CreateAccountAsync(AccountDTO accountDTO);
        Task<List<Account>> GetAllAccountsAsync();
        Task<AccountDTO> GetAccountByIdAsync(int id);
        Task<Account> GetByAccountNumberAsync(string accountNumber);
        Task<(bool, string)> VerifyBalance(string accountNumber, decimal amount);
        Task<(bool, string)> BalanceTransfer(string accountSource, string accountTarget, decimal amount, Guid transactionId);

    }
}