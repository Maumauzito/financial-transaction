using Microsoft.EntityFrameworkCore;
using TransacaoFinanceira.Domain.Entities;

namespace TransacaoFinanceira.Infrastructure.Data
{
    public class TransacaoFinanceiraContex : DbContext
    {
        public TransacaoFinanceiraContex(DbContextOptions<TransacaoFinanceiraContex> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //populando base
            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, AccountNumber = "938485762", Balance = 180.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 2, AccountNumber = "347586970", Balance = 1200.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 3, AccountNumber = "2147483649", Balance = 0.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 4, AccountNumber = "675869708", Balance = 4900.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 5, AccountNumber = "238596054", Balance = 478.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 6, AccountNumber = "573659065", Balance = 787.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 7, AccountNumber = "210385733", Balance = 10.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 8, AccountNumber = "674038564", Balance = 400.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Account { Id = 9, AccountNumber = "563856300", Balance = 1200.0M, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
                );

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { Id = 1, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:15:00"), AccountSource = "938485762", AccountTarget = "2147483649", AmountTransaction = 150 },
                new Transaction { Id = 2, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:15:05"), AccountSource = "2147483649",AccountTarget = "210385733", AmountTransaction = 149 },
                new Transaction { Id = 3, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:15:29"), AccountSource = "347586970", AccountTarget = "238596054", AmountTransaction = 1100 },
                new Transaction { Id = 4, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:17:00"), AccountSource = "675869708", AccountTarget = "210385733", AmountTransaction = 5300 },
                new Transaction { Id = 5, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:18:00"), AccountSource = "238596054", AccountTarget = "674038564", AmountTransaction = 1489 },
                new Transaction { Id = 6, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:18:20"), AccountSource = "573659065", AccountTarget = "563856300", AmountTransaction = 49 },
                new Transaction { Id = 7, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:19:00"), AccountSource = "938485762", AccountTarget = "2147483649", AmountTransaction = 44 },
                new Transaction { Id = 8, CorrelationId = Guid.NewGuid(), CreatedAt = Convert.ToDateTime("09/09/2023 14:19:01"), AccountSource = "573659065", AccountTarget = "675869708", AmountTransaction = 150 }
                );
        }

    }
}
