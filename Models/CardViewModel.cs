using City.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public SelectList TypesCard { get; set; }

        public SelectList Statuses { get; set; }

        public SelectList Contractors { get; set; }
    }
}
