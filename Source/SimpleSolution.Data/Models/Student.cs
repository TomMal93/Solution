using SimpleSolution.Data.ModelsBase;
using System;

namespace SimpleSolution.Data.Models
{
    public class Student : EntityBase
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Guid ClassroomId { get; set; }

        public virtual Classroom Classroom { get; set; }
    }
}
