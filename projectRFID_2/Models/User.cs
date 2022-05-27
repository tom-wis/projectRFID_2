using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRFID_2.Models
{
    public class User

    {
        [Key]
        public int IdUser { get; set; }
       
        public string CardNumber{ get; set; }

        public string FirstName { get; set; }

        public string LastName{ get; set; }
        //public List<Registry> Registries { get; set; } = new List<Registry>();
    }

}
