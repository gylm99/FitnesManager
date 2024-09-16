using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesManager.Domain.Entities
{
    public class Trainer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public bool PersonalTrainer { get; set; }
    }
}
