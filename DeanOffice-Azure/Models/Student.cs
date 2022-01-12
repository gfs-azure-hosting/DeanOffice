using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeanOffice_Azure.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public int Phone { get; set; }

        [Required]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Group")]
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
