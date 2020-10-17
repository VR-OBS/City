using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;
using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain.Repositories.EntityFramework
{
    public class EFContractorRepository : IContractorRepository
    {
        private readonly AppDBContext context;
        public EFContractorRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void DeleteCard(Guid id)
        {
            context.Contractors.Remove(new Contractor() { ID = id });
            context.SaveChanges();
        }

        public Contractor GetCard(Guid id)
        {
            return context.Contractors.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Contractor> GetCards()
        {
            return context.Contractors;
        }

        public void SaveCard(Contractor entity)
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
