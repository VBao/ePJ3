using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class Applicant
    {
        public Applicant()
        {
            ApplicantionList = new HashSet<ApplicantionList>();
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Dob { get; set; }
        
        public bool? Gender { get; set; }
        public string CvFile { get; set; }
        public int? StatusId { get; set; }

        public virtual ApplicantStatus Status { get; set; }
        public virtual ICollection<ApplicantionList> ApplicantionList { get; set; }
    }
}
