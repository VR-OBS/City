using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;
using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain.Repositories.EntityFramework
{
    public class EFTypeCardRepository : ITypeCardRepository
    {
        private readonly AppDBContext context;
        public EFTypeCardRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void DeleteCard(Guid id)
        {
            context.TypesCard.Remove(new TypeCard() { ID = id });
            context.SaveChanges();
        }

        public TypeCard GetCard(Guid id)
        {
            return context.TypesCard.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<TypeCard> GetCards()
        {
            return context.TypesCard;
        }

        public void SaveCard(TypeCard entity)
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
