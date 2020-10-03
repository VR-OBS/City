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
        public IContactorRepository Contactors { get; set; }
        public IStatusRepository Statuses { get; set; }

        public DataManager(ICardRepository cardRepository, IStatusRepository statusRepository,IContactorRepository contactorRepository)
        {
            Cards = cardRepository;
            Contactors = contactorRepository;
            Statuses = statusRepository;
        }
    }
}
