using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class InterviewDetail
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ApplicationListId { get; set; }
        public int? InterviewerId { get; set; }

        public virtual ApplicantionList ApplicationList { get; set; }
        public virtual Interviewer Interviewer { get; set; }
    }
}
