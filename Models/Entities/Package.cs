using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coorier.Models.Entities
{
    public class Package
    {
        public String Status { get; set; }
        public String Id { get; set; }

        public Package(String id /*, String status*/)
        {
            this.Id = id;
           // this.Status = status;
        }
    }
}
