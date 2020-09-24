using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Entities;

namespace City.Domain.Repositories.Abstract
{
    public interface ICardRepository
    {
        IQueryable<Card> GetCards();
        Card GetCard(Guid id);
        void SaveCard(Card entity);
        void DeleteCard(Guid id);
    }
}
