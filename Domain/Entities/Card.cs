using City.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace City.Domain.Entities
{
    public class Card : EntityBase
    {
        [Display(Name = "Тип Заявки")]
        public Guid TypeID { get; set; }

        [Display(Name = "Описание")]
        public string Text { get; set; }

        public string Pos_X { get; set; }
        public string Pos_Y { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Фото")]
        public string PhotoPath { get; set; }

        [Display(Name = "Статус")]
        public Guid StatusID { get; set; }

        [Display(Name = "Ответственный")]
        public Guid ManagerID { get; set; }

        [Display(Name = "Исполнитель")]
        public Guid ContractorID { get; set; }

        [Display(Name = "Заявитель")]
        public Guid UserID { get; set; }

        [Display(Name = "Срок исполнения")]
        public DateTime EndDate { get; set; }

    }
}
