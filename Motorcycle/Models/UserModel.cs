using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Motorcycle.Models
{
    public class UserModel
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
    

        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual RoleModel Role { get; set; }
        
    }
    
}
