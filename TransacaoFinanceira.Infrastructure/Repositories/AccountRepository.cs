using Microsoft.EntityFrameworkCore;
using TransacaoFinanceira.Domain.Entities;
using TransacaoFinanceira.Infrastructure.Data;
using TransacaoFinanceira.Infrastructure.Repositories.Interfaces;

namespace TransacaoFinanceira.Infrastructure.Repositories
{
    public class AccountRepository : CommonRepository<Account>, IAccountRepository
    {
        public AccountRepository(TransacaoFinanceiraContex contex) : base(contex){}

        public async Task<Account> FindByAccountNumberAsync(string accountNumber)
        {
            return await _contex
                .Accounts
                .AsNoTracking()
                .Where(x => x.AccountNumber == accountNumber)
                .FirstOrDefaultAsync();
        }

    }
}
