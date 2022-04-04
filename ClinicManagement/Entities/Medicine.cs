using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
