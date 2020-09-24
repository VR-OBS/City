using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace City.Domain.Entities
{
    public class Status : EntityBase
    {
        [Display(Name = "Статус")]
        public string Name { get; set; }

        [Display(Name = "Описание статуса")]
        public string Description { get; set; }

    }
}
