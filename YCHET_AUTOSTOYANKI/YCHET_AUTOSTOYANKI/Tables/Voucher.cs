using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{
    public class Voucher
    {
        [Key]
        public int Id { get; set; }
        public DateTime Indate  { get; set; }
        [Required]
        public DateTime Outdate { get; set; }
        public int Summ { get; set; }
        public virtual Discount Discounts { get; set; }
    }
}
