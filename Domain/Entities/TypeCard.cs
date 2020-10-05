using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace City.Domain.Entities
{
    public class TypeCard : EntityBase
    {
        [Display(Name = "Тип заявки")]
        public string Name { get; set; }

        [Display(Name = "Описание типа")]
        public string Description { get; set; }

        public List<Card> Cards { get; set; }

    }
}
