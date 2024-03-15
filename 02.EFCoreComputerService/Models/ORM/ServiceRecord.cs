using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class ServiceRecord : BaseModel
    {
        public string DeviceType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int SerialNo { get; set; }
        public string Description { get; set; }
        public DateTime AcceptanceDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int ServiceStatusId { get; set; }

        [ForeignKey("ServiceStatusId")]
        public ServiceStatus ServiceSatatus { get; set; }
    }
}
