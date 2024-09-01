using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGenerator
{
    public class CodigoGerado
    {
        
        [key] 
        public int Id { get; set; }
        public string Codigo { get; set;} = string.Empty;
    }
}
