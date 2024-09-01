
using System.ComponentModel.DataAnnotations;

namespace StrutBeam.MVVM.Models
{
    public class Licenses
    {
        [Key]
        public int Id { get; set; } 
        public string License { get; set; } = string.Empty;
        public int Month { get; set; }
        public string Code { get; set; } = string.Empty;
        public DateTime ActivationDate { get; set; } 
        public DateTime ExpiractionDate { get; set; } 
    }
}
