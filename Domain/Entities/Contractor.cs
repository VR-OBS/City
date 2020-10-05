using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace City.Domain.Entities
{
    public class Contractor : EntityBase
    {
        [Display(Name = "Организация")]
        public string Name { get; set; }

        public List<Card> Cards { get; set; }
    }
}
