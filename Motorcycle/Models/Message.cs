using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motorcycle.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан отрпавитель")]
        public virtual  UserModel Sender { get; set; }

        public string messageText { get; set; }

        [Required(ErrorMessage = "Не указано время отправления")]
        public DateTime Departure { get; set; }

    }
}
