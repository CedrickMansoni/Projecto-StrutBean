using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutBeam.MVVM.Models
{
    public class ControlAccess
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateAccess { get; set; }
    }
}
