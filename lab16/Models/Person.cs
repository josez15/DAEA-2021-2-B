using System;

namespace persons.Models 
{
    public class Person
    {
        public int? PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public DateTime? HireDate { get; set; }
    }
}