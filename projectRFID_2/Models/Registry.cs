using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRFID_2.Models
{
   public class Registry
    {
        [Key]
        public int IdRegistry { get; set; }
        
        public string Date { get; set; }
        public string Hour { get; set; }
    }
}
