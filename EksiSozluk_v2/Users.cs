using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_v2
{
    public class Users
    {

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime RegisterDate { get; set; }

        public Entities Entities1 { get; set; }
    }
}
