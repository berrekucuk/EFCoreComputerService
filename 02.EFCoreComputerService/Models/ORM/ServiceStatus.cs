using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class ServiceStatus : BaseModel
    {
        public string StatusName { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }
    }
}
