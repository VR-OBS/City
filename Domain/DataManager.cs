using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;

namespace City.Domain
{
    public class DataManager
    {
        public ICardRepository Cards { get; set; }
        public IContractorRepository Contractors { get; set; }
        public IStatusRepository Statuses { get; set; }
        public ITypeCardRepository TypesCard { get; set; }

        public DataManager(ICardRepository cardRepository, IStatusRepository statusRepository,IContractorRepository contractorRepository, ITypeCardRepository typeCardRepository)
        {
            Cards = cardRepository;
            Contractors = contractorRepository;
            Statuses = statusRepository;
            TypesCard = typeCardRepository;
        }
    }
}
