using System;
using System.Collections.Generic;
using eProject3_1.Models;

namespace eProject3_1.Services
{
    public interface IContextContextRepository
    {
        public Vacancy Test();

        // TODO Work with Vacancy
        public List<Vacancy> GetVacancies();
        public Vacancy GetVacancy(string id);
        public Vacancy GetVacancyForm();
        public bool CreateVacancy(Vacancy vac);
        public bool EditVacancy(Vacancy vac);
        public List<VacancyStatus> GetVacancyStatus();
        public bool SetVacancyStatus(string vId, int vStat);


        // TODO Work with Employee
        public List<Employee> GetEmployees();

        //Department
        public List<Department> GetDepartments();

        // Vacancy status
        public List<VacancyStatus> GetStatusVacancy();

        // TODO Work with Applicant
        public List<Applicant> GetChosenApplicants(string vId);
        public List<Applicant> GetApplicants();
        public Applicant GetApplicant(string id);
        public Applicant GetApplicantForm();
        public bool CreateApplicant(Applicant app);
        public void EditApplicant(Applicant app);
        public bool SetApplicantStatus(string aId, int aStat);
        public List<ApplicantStatus> GetApplicantStatus();

        // Interview function
        public List<ApplicantionList> GetListInterview();
        public List<Vacancy> GetVacanciesBaseDepartment(int idDepart);
        public List<InterviewStatus> GetInterviewStatus();
        public bool CreateListInterview(ApplicantionList inter);
        public bool SetInterviewStatus(int iId, int stats);
        
        
        // Interview detail function
        public bool CheckTime(DateTime start, DateTime end,int interviewerId);
        public InterviewDetail GetScheduleForm(int interId,int interviewerId);
        public bool CreateSchedule(InterviewDetail de);
        public List<Interviewer> GetInterviewers(string vacancyId = null,string interviewListId=null);
    }
}