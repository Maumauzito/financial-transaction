namespace TransacaoFinanceira.Appilcation.DTOs
{
    public class AccountDTO
    {
        public string? AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
