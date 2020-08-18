using SimpleSolution.Data.Migrations;
using SimpleSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace SimpleSolution.Data.DAL
{
    public class SimpleInitializer : MigrateDatabaseToLatestVersion<SimpleContext, Configuration>
    {
        public static void SeedSimpleData(SimpleContext context)
        {
            var classRoom = new List<Classroom>
            {
                new Classroom() {ClassroomId = Guid.Parse("bef018c6-a684-4a49-9b2f-f80b1dd9143c"), Name = "Klasa pierwsza"},
                new Classroom() {ClassroomId = Guid.Parse("9586feed-ca7d-48f6-8230-97f2874e8701"), Name = "Klasa druga"}
            };

            classRoom.ForEach(c => context.Classrooms.AddOrUpdate(c));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student() {StudentId = Guid.Parse("5bfc3adf-b6ae-4eb3-96f7-9bf4f44ca5f6"), Name = "Imie", Surname = "Nazwisko", BirthDate = DateTime.Parse("10/10/2010"), ClassroomId = Guid.Parse("bef018c6-a684-4a49-9b2f-f80b1dd9143c")},
                new Student() {StudentId = Guid.Parse("fc2f4d28-1d08-4f4c-a8dc-e0ef6e3028dd"), Name = "Imie", Surname = "Nazwisko", BirthDate = DateTime.Parse("10/10/2009"), ClassroomId = Guid.Parse("9586feed-ca7d-48f6-8230-97f2874e8701")}
            };

            students.ForEach(s => context.Students.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}

