using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class Vacancy
    {
        public Vacancy()
        {
            ApplicantionList = new HashSet<ApplicantionList>();
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int? JobNumber { get; set; }
        [DisplayName("Close Date")]
        public DateTime? Close { get; set; }
        [DisplayName("Create Date")]
        public DateTime? CreateAt { get; set; }
        [DisplayName("Status")]
        public int? StatusId { get; set; }
        [DisplayName("Employee")]
        public int? EmployeeId { get; set; }
        [DisplayName("Department")]
        public string DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual VacancyStatus Status { get; set; }
        public virtual ICollection<ApplicantionList> ApplicantionList { get; set; }
    }
}
