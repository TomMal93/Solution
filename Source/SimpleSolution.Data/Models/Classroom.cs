using SimpleSolution.Data.ModelsBase;
using System;
using System.Collections.Generic;

namespace SimpleSolution.Data.Models
{
    public class Classroom : EntityBase
    {
        public Guid ClassroomId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
