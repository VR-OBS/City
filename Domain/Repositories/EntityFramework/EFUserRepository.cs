using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;
using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain.Repositories.EntityFramework
{
    public class EFUserRepository : IUserRepository
    {
        private readonly AppDBContext context;
        public EFUserRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void DeleteCard(Guid id)
        {
            context.Users.Remove(new User() { ID = id });
            context.SaveChanges();
        }

        public User GetCard(Guid id)
        {
            return context.Users.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<User> GetCards()
        {
            return context.Users;
        }

        public void SaveCard(User entity)
        {
            if (entity.ID==default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
