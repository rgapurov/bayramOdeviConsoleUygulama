using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Accaunt
    {
        [Key]
        public int accountNo { get; set; }
        [StringLength(20)]
        public string acName { get; set; }
        public int acBalance { get; set; }
        public ICollection<Transaction> transactions { get; set; }


    }
}
