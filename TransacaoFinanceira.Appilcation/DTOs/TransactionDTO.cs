using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Appilcation.DTOs
{
    public class TransactionDTO
    {
        public Guid CorrelationId { get; set; }
        public string AccountSource { get; set; }
        public string AccountTarget { get; set; }
        public decimal AmountTransaction { get; set; }
    }
}
