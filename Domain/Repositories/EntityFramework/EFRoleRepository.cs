using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;
using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain.Repositories.EntityFramework
{
    public class EFRoleRepository : IRoleRepository
    {
        private readonly AppDBContext context;
        public EFRoleRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void DeleteCard(Guid id)
        {
            context.Roles.Remove(new Role() { ID = id });
            context.SaveChanges();
        }

        public Role GetCard(Guid id)
        {
            return context.Roles.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Role> GetCards()
        {
            return context.Roles;
        }

        public void SaveCard(Role entity)
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
