using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uowAPI.Profiles
{
    public class TransactionsProfile : Profile
    {
        public TransactionsProfile()
        {
            CreateMap<uow.Entities.Transaction, uow.Models.TransactionModel>();
            CreateMap<uow.Models.TransactionModel, uow.Entities.Transaction>();
        }
    }
}
