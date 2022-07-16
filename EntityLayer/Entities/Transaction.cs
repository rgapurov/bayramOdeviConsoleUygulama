using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Transaction
    {
        [Key]
        public int transactionNo { get; set; }
        public int trAccaunt { get; set; }
        public virtual Accaunt accountNo { get; set; }
        public DateTime trTime { get; set; }
        [StringLength(50)]
        public string trType { get; set; }
        public int trAmount { get; set; }
    }
}
