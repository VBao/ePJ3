using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
            Interviewer = new HashSet<Interviewer>();
            Vacancy = new HashSet<Vacancy>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Interviewer> Interviewer { get; set; }
        public virtual ICollection<Vacancy> Vacancy { get; set; }
    }
}
