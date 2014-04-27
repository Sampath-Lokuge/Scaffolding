using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScaffoldingMVC5.Models
{
    public class Pet
    {
        public Pet() { Id = Guid.NewGuid(); Created = DateTime.Now; }

        public Guid Id { get; set; }

        [StringLength(50), Required]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Created { get; set; }

        [Display(Name = "Birth Date"), DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required]
        public double Weight { get; set; }

    }
}