using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutBeamEmployee.Models
{
    public class Employee : Clients
    {
        public bool Admin { get; set; } = false;
    }
}
