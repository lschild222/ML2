using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ML2.Model
{
    public class Employee
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(20)]
        public string Password { get; set; } = string.Empty;
    }
}
