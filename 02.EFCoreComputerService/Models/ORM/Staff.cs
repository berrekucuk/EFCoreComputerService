using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class Staff : BaseModel
    {
        public string StaffName { get; set; }
        public string StaffSurname { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public DateTime StartingDate { get; set; }
        public List<ServiceRecord> ServiceRecords { get; set; }
    }
}
