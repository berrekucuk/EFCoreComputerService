using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class SparePart : BaseModel
    {
        public string SparePartName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
