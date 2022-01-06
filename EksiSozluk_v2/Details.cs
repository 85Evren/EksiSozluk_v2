using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_v2
{
    public class Details
    {
        public int DetailsID { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
        public Entities Entities2 { get; set; }
    }
}
