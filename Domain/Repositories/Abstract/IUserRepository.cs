using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Entities;

namespace City.Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> GetCards();
        User GetCard(Guid id);
        void SaveCard(User entity);
        void DeleteCard(Guid id);
    }
}
