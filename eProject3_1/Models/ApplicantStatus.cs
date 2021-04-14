﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class ApplicantStatus
    {
        public ApplicantStatus()
        {
            Applicant = new HashSet<Applicant>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Applicant> Applicant { get; set; }
    }
}
