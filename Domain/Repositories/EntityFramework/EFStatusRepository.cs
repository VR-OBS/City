using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;
using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain.Repositories.EntityFramework
{
    public class EFStatusRepository : IStatusRepository
    {
        private readonly AppDBContext context;
        public EFStatusRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void DeleteCard(Guid id)
        {
            context.Statuses.Remove(new Status() { ID = id });
            context.SaveChanges();
        }

        public Status GetCard(Guid id)
        {
            return context.Statuses.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Status> GetCards()
        {
            return context.Statuses;
        }

        public void SaveCard(Status entity)
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
