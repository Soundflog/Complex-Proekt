using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Gosnumber { get; set; }
        public virtual Auto Autos { get; set; }
        public string Numberphone { get; set; }
        public string SeriaNumberDoc { get; set; }
        public virtual Role Roles { get; set; }

    }
}
