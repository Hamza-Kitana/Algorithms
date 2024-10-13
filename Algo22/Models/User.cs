using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Algo22.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
