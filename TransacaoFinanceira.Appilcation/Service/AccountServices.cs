using AutoMapper;
using TransacaoFinanceira.Appilcation.DTOs;
using TransacaoFinanceira.Appilcation.Service.Interfaces;
using TransacaoFinanceira.Domain.Entities;
using TransacaoFinanceira.Infrastructure.Repositories.Interfaces;

namespace TransacaoFinanceira.Appilcation.Service
{
    public class AccountServices: IAccountServices
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountServices(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<Account> CreateAccountAsync(AccountDTO accountDTO)
        {
            var entity = _mapper.Map(accountDTO, new Account());

            await _accountRepository.Add(entity);

            return entity;
        }

        public async Task<List<Account>> GetAllAccountsAsync()
        {
            var transactions = await _accountRepository.GetAllAsync();

            return transactions;

        }

        public async Task<AccountDTO> GetAccountByIdAsync(int id)
        {
            var accountResponse = await _accountRepository.FindByIdAsync(id);

            return _mapper.Map(accountResponse, new AccountDTO());
        }

        public async Task<Account> GetByAccountNumberAsync(string accountNumber)
        {

            var account = await _accountRepository.FindByAccountNumberAsync(accountNumber);

            return account;
        }

        public async Task<(bool,string)> VerifyBalance(string accountNumber,decimal amount)
        {
            var account = await _accountRepository.FindByAccountNumberAsync(accountNumber);
            
            if (account == null)
                return (false,"conta inexistente");

            if (account.Balance < amount)
                return (false,"falta de saldo");

            return (true,"Saldo Ok");

        }
        public async Task<(bool,string)> BalanceTransfer(string accountSource, string accountTarget,decimal amount, Guid transactionId)
        {
            var sourceAccount = await _accountRepository.FindByAccountNumberAsync(accountSource);
            if (sourceAccount == null)
                return (false, "Conta de Origem Inexistente");

            var targetAccount = await _accountRepository.FindByAccountNumberAsync(accountTarget);
            if (targetAccount == null)
                return (false, "Conta de destino Inexistente");

            sourceAccount.Balance -= amount;
            sourceAccount.UpdatedAt = DateTime.Now;
            
            targetAccount.Balance += amount;
            targetAccount.UpdatedAt = DateTime.Now;

            await _accountRepository.AddOrUpdate(sourceAccount, sourceAccount.Id);
            await _accountRepository.AddOrUpdate(targetAccount, targetAccount.Id);

            return (true, $"Transacao numero {transactionId} foi efetivada com sucesso! Novos saldos: Conta Origem:{sourceAccount.Balance} | Conta Destino: {targetAccount.Balance}");

        }

    }
}
