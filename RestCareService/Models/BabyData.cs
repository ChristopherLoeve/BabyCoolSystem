using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCareService.Models
{
    public class BabyData
    {
        public int Id { get; set; }
        public int UnitNo { get; set; }
        public int Breath { get; set; }
        public int Crying { get; set; }

        public BabyData()
        {

        }
    }
}
