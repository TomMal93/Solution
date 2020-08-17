using SimpleSolution.Data.ModelsBase;
using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleSolution.Data.Models
{
    public class Student : EntityBase
    {
        public Guid StudentId { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić imię.")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwisko.")]
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Guid ClassroomId { get; set; }

        public virtual Classroom Classroom { get; set; }
    }
}
