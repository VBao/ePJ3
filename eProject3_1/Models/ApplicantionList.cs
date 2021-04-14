using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class ApplicantionList
    {
        public ApplicantionList()
        {
            InterviewDetail = new HashSet<InterviewDetail>();
        }

        public int Id { get; set; }
        public string ApplicantId { get; set; }
        public string VacancyId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreateAt { get; set; }

        public virtual Applicant Applicant { get; set; }
        public virtual InterviewStatus Status { get; set; }
        public virtual Vacancy Vacancy { get; set; }
        public virtual ICollection<InterviewDetail> InterviewDetail { get; set; }
    }
}
