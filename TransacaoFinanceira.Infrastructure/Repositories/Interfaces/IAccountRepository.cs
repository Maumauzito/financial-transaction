using TransacaoFinanceira.Domain.Entities;

namespace TransacaoFinanceira.Infrastructure.Repositories.Interfaces
{
    public interface IAccountRepository : ICommonRepository<Account>
    {
        Task<Account> FindByAccountNumberAsync(string accountNumber);
    }
}