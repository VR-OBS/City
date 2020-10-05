using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Entities;

namespace City.Domain.Repositories.Abstract
{
    public interface ITypeCardRepository
    {
        IQueryable<TypeCard> GetCards();
        TypeCard GetCard(Guid id);
        void SaveCard(TypeCard entity);
        void DeleteCard(Guid id);
    }
}
