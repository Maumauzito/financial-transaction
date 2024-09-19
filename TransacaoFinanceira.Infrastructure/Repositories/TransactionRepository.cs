using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransacaoFinanceira.Domain.Entities;
using TransacaoFinanceira.Infrastructure.Data;
using TransacaoFinanceira.Infrastructure.Repositories.Interfaces;

namespace TransacaoFinanceira.Infrastructure.Repositories
{
    public class TransactionRepository : CommonRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(TransacaoFinanceiraContex contex) : base(contex)
        {
        }

    }
}
