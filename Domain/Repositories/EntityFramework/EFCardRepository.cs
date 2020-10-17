using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain.Repositories.Abstract;
using City.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City.Domain.Repositories.EntityFramework
{
    public class EFCardRepository : ICardRepository
    {
        private readonly AppDBContext context;
        public EFCardRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void DeleteCard(Guid id)
        {
            context.Cards.Remove(new Card() { ID = id });
            context.SaveChanges();
        }

        public Card GetCard(Guid id)
        {
            return context.Cards
                .Include(u => u.Status)
                .Include(u => u.Contractor)
                .Include(u => u.TypeCard)
                .FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Card> GetCards()
        {
            return context.Cards                
                .Include(u => u.Status)
                .Include(u => u.Contractor)
                .Include(u => u.TypeCard);
        }

        public void SaveCard(Card entity)
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

        public int GetCount()
        {
            return context.Cards.Count();
        }
    }
}
