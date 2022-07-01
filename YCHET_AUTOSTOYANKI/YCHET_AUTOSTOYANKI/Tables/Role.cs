using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Namerole { get; set; }

    }
}
