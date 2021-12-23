using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.DataTransferObjects
{
    public class UserForRegistrationDTO
    {
        [Required(ErrorMessage = "Username Is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<string> Roles { get; set; }
    }
}
