using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Entities;

namespace City.Domain.Repositories.Abstract
{
    public interface IStatusRepository
    {
        IQueryable<Status> GetCards();
        Status GetCard(Guid id);
        void SaveCard(Status entity);
        void DeleteCard(Guid id);
    }
}
