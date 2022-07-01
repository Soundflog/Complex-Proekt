using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Desription { get; set; }
        public virtual Role Roles { get; set; }
    }
}
