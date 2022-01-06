using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_v2
{
    public class Comments
    {
        public int CommentsID { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }

        public Entities Entities3 { get; set; }
    }
}
