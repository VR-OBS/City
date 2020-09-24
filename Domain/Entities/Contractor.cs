using System.ComponentModel.DataAnnotations;

namespace City.Domain.Entities
{
    public class Contractor : EntityBase
    {
        [Display(Name = "Организация")]
        public string Name { get; set; }
    }
}
