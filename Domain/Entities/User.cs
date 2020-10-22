using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace City.Domain.Entities
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MidName { get; set; }

        public Guid? RoleID { get; set; }
        public Role Role { get; set; }
    }
}
