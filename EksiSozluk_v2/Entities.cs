using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_v2
{
    public class Entities
    {


        public int ID { get; set; }

        public string Name { get; set; }
           
        //public int DetailsID { get; set; }
       // public List<Details> Details { get; set; }
       public List<Details> Details_ { get; set; }

        //public int UserID { get; set; }
        //public List<Users> Users { get; set; }
        public List<Users> Users_ { get; set; }


        // public int CommentsID { get; set; }
        //public List<Comments> Comments { get; set; }
        public List<Comments> Comments_ { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
