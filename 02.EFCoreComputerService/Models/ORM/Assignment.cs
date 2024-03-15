using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class Assignment : BaseModel
    {
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int ServiceRecordId { get; set; }
        public ServiceRecord ServiceRecord { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}
