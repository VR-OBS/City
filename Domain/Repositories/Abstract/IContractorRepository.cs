using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Entities;

namespace City.Domain.Repositories.Abstract
{
    public interface IContractorRepository
    {
        IQueryable<Contractor> GetCards();
        Contractor GetCard(Guid id);
        void SaveCard(Contractor entity);
        void DeleteCard(Guid id);
    }
}
