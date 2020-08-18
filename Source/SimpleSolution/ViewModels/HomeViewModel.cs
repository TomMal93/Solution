using SimpleSolution.Data.Models;
using System.Collections.Generic;

namespace SimpleSolution.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Classroom> Classrooms { get; set; }
    }
}