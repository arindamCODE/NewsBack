using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Users
    {
        public int ID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}