using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class Customer : BaseModel
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string Address { get; set; }
    }
}
