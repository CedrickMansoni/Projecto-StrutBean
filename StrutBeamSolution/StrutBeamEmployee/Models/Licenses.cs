using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutBeamEmployee.Models
{
    public class Licenses
    {
        public int Id { get; set; }
        public string License { get; set; } = string.Empty;
        public int Month { get; set; }
        public string ActivationDate { get; set; } = string.Empty;
        public string ExpiractionDate { get; set; } = string.Empty;
        public int TotalUsers { get; set; } = 1;
        public int UsersActive { get; set; } = 0;
        public int IdClient { get; set; } = 0;
        public int StateLicense { get; set; } = 1;
        
        public string MSN { get; set; } = string.Empty;

    }
}
