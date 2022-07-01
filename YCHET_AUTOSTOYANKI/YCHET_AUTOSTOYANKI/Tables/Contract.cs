using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime ConclusionDate { get; set; }
        public virtual Autostop Autostops { get; set; }
        public virtual Staff Staffs { get; set; }
        public virtual Voucher Vouchers { get; set; }
        public virtual Client Clients { get; set; }
    }
}
