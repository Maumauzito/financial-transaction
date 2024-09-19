using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using TransacaoFinanceira.Appilcation.DTOs;
using TransacaoFinanceira.Appilcation.Service.Interfaces;
using Newtonsoft.Json;

namespace TransacaoFinanceira.Api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class FinancingController : ControllerBase
    {
        private readonly IAccountServices _accountServices;
        private readonly ITransactionServices _transactionServices;

        public FinancingController(IAccountServices accountServices, ITransactionServices transactionServices)
        {
            _accountServices = accountServices;
            _transactionServices = transactionServices;
        }

        [HttpGet]
        [Route("accounts")]
        public async Task<IActionResult> GetAccounts()
        {
            var response = await _accountServices.GetAllAccountsAsync();
            return Ok(response);
        }

        [HttpGet]
        [Route("account/{id}")]
        public async Task<IActionResult> GetAccountById([FromRoute] int id)
        {
            var response = await _accountServices.GetAccountByIdAsync(id);
            if (response == null)
            return BadRequest("O valor do campo valor aplicado deve ser um valor monetário positivo");

            return Ok(response);
        }

        [HttpPost]
        [Route("account")]
        public async Task<IActionResult> InsertAccount(AccountDTO accountDTO)
        {
            if (accountDTO == null)
                return BadRequest("Formato inesperado");
            
            await _accountServices.CreateAccountAsync(accountDTO);

            return Ok("Conta criada");
        }

        [HttpPost]
        [Route("account/processtransaction")]
        public async Task<IActionResult> ProcessTransction()
        {
            var transactions = await _transactionServices.GetAllTransactionsAsync();
            if (transactions.Count() == 0)
            {
                return Ok("Lista de transações vazia");
            }
            
            List<string> returnTransction = new List<string>();
            
            foreach (var transaction in transactions) {

               var (success,response) =  await _accountServices.VerifyBalance(transaction.AccountSource, transaction.AmountTransaction);
                if (success) 
                {
                    var (isCompleted,message) = await _accountServices.BalanceTransfer(transaction.AccountSource, transaction.AccountTarget, transaction.AmountTransaction, transaction.CorrelationId);
                    returnTransction.Add(message);

                }
                else
                {
                    if (response.ToString()== "falta de saldo")
                    {
                        returnTransction.Add($"Transacao numero {transaction.CorrelationId} foi cancelada por falta de saldo");
                    }
                    returnTransction.Add(response.ToString());
                }
            }

            return Ok(returnTransction.ToArray());

        }

        [HttpGet]
        [Route("transaction")]
        public async Task<IActionResult> GetTransactions()
        {
            var response = await _transactionServices.GetAllTransactionsAsync();
            
            return Ok(response);
        }

        [HttpGet]
        [Route("transaction/{id}")]
        public async Task<IActionResult> GetTransactionById([FromRoute] int id)
        {
            return Ok("");
        }

        [HttpPost]
        [Route("transaction")]
        public async Task<IActionResult> InsertTransaction(TransactionDTO transaction)
        {

            if (transaction == null)
                return BadRequest("Formato inesperado");

            await _transactionServices.CreateTransactionAsync(transaction);

            return Ok(transaction);
        }







    }

}
