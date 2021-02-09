using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage ="Please enter a valid First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a valid Last Name")]
        public string LastName { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid Email")]
        public string Email { get; set; }

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 10000, ErrorMessage ="Please select a category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Slug => FirstName?.Replace(' ', '-').ToLower() + "-" + LastName?.Replace(' ', '-').ToLower();
    }
}
