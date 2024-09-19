namespace TransacaoFinanceira.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string? AccountNumber { get; set; } 
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
