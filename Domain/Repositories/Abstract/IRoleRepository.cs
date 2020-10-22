using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Entities;

namespace City.Domain.Repositories.Abstract
{
    public interface IRoleRepository
    {
        IQueryable<Role> GetCards();
        Role GetCard(Guid id);
        void SaveCard(Role entity);
        void DeleteCard(Guid id);
    }
}
