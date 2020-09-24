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

        public DataManager(ICardRepository cardRepository)
        {
            Cards = cardRepository;
        }
    }
}
