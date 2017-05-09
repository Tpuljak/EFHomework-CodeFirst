using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDB.Data.Models
{
    public enum Role
    {
        LEAD_CHEF,
        ASSISTANT_CHEF,
        WAITER
    }

    public class Employee
    {
        public string Name { get; set; }

        [Key]
        public string PersonalIdNumber { get; set; }

        public int BirthYear { get; set; }
        public Role Role { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
