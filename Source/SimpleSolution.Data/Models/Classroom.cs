using SimpleSolution.Data.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleSolution.Data.Models
{
    public class Classroom : EntityBase
    {
        public Guid ClassroomId { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwę.")]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
