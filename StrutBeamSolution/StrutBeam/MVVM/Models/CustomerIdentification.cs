
using System.ComponentModel.DataAnnotations;

namespace StrutBeam.MVVM.Models
{
    public class CustomerIdentification
    {
        [Key]
        public int Id { get; set; } 
        public string CustomerId { get; set; } = string.Empty;
    }
}
