using City.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace City.Models
{
    public class CardViewModel
    {
        public Card Card { get; set; }
        public IEnumerable<TypeCard> TypesCard { get; set; }
    }
}
