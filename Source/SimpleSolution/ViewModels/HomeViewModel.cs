using SimpleSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSolution.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Classroom> Classrooms { get; set; }
    }
}