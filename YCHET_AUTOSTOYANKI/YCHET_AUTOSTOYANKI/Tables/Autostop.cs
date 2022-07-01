using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{
    public class Autostop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public int Seats { get; set; }
        public string Type { get; set; }
    }
}
