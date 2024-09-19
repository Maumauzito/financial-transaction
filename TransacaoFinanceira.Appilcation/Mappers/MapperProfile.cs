using AutoMapper;
using TransacaoFinanceira.Appilcation.DTOs;
using TransacaoFinanceira.Domain.Entities;

namespace TransacaoFinanceira.Appilcation.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Account, AccountDTO>();

            CreateMap<AccountDTO, Account>().AfterMap((src, target) =>
            {
                target.CreatedAt = DateTime.Now;
                target.UpdatedAt = DateTime.Now;
            });

            CreateMap<Transaction, TransactionDTO>();
            CreateMap<TransactionDTO, Transaction>()
                .AfterMap((src, target) =>
                {
                    target.CorrelationId = Guid.NewGuid(); 
                    target.CreatedAt = DateTime.Now;
                });
        }
    }
}
