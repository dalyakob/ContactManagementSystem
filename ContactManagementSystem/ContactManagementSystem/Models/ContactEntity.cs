using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagementSystem.Models
{
    public class ContactEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [StringLength(250, ErrorMessage = "Name is too long.")]
        public string LastName { get; set; }

        [StringLength(250, ErrorMessage = "Name is too long.")]
        public string FirstName { get; set; }

        [StringLength(15, ErrorMessage = "Phone Number is too long.")]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
