namespace TransacaoFinanceira.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public Guid CorrelationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string AccountSource { get; set; } = "";
        public string AccountTarget { get; set; } = "";
        public decimal AmountTransaction { get; set; }
    }
}
