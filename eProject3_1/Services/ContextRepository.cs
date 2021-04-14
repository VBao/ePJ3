using System;
using System.Collections.Generic;
using eProject3_1.Models;
using System.Linq;

namespace eProject3_1.Services
{
    public class ContextRepository : IContextContextRepository
    {
        private readonly HrContext _ctx;

        public ContextRepository(HrContext context)
        {
            _ctx = context;
        }

        public Vacancy Test()
        {
            Vacancy a = _ctx.Vacancy.First();
            a.Department = _ctx.Department.First(v => v.Id == a.DepartmentId);
            return a;
        }

        public List<Vacancy> GetVacancies()
        {
            List<Vacancy> vacancies = _ctx.Vacancy.ToList();
            foreach (Vacancy vacancy in vacancies)
            {
                vacancy.Employee = _ctx.Employee.First(e => e.Id == vacancy.EmployeeId);
                vacancy.Department = _ctx.Department.First(d => d.Id == vacancy.DepartmentId);
                vacancy.Status = _ctx.VacancyStatus.First(s => s.Id == vacancy.StatusId);
            }

            return vacancies;
        }

        public Vacancy GetVacancy(string id)
        {
            Vacancy vac = _ctx.Vacancy.First(u => u.Id == id);
            vac.Department = _ctx.Department.First(d => d.Id == vac.DepartmentId);
            vac.Status = _ctx.VacancyStatus.First(s => s.Id == vac.StatusId);
            vac.Employee = _ctx.Employee.First(e => e.Id == vac.EmployeeId);
            return vac;
        }

        public Vacancy GetVacancyForm()
        {
            Vacancy vac = new Vacancy {CreateAt = DateTime.Now.Date, Close = DateTime.Now.Date};
            string sId = _ctx.Vacancy.OrderByDescending(b => b.Id).FirstOrDefault()?.Id;
            if (string.IsNullOrEmpty(sId))
            {
                sId = "V0001";
            }

            else
            {
                sId = sId.Remove(0);
                int iId = Convert.ToInt32(sId) + 1;
                sId = iId.ToString();
                iId = iId.ToString().Length;
                for (int i = 0; i < 4 - iId; i++)
                {
                    sId = sId.Insert(0, "0");
                }

                sId = sId.Insert(0, "V");
            }

            vac.Id = sId;
            return vac;
        }

        public bool CreateVacancy(Vacancy vac)
        {
            _ctx.Vacancy.Add(vac);
            return _ctx.SaveChanges() > 0;
        }

        public bool EditVacancy(Vacancy vac)
        {
            Vacancy oldVac = _ctx.Vacancy.First(v => v.Id == vac.Id);
            oldVac.Title = vac.Title;
            oldVac.Details = vac.Details;
            oldVac.EmployeeId = vac.EmployeeId;
            oldVac.Close = vac.Close;
            oldVac.StatusId = vac.StatusId;
            return _ctx.SaveChanges() > 0;
        }

        public List<VacancyStatus> GetVacancyStatus()
        {
            return _ctx.VacancyStatus.ToList();
        }

        public bool SetVacancyStatus(string vId, int vStat)
        {
            Vacancy updateStat = _ctx.Vacancy.First(v => v.Id == vId);
            updateStat.StatusId = vStat;
            return _ctx.SaveChanges() > 0;
        }

        //Employee
        public List<Employee> GetEmployees()
        {
            return _ctx.Employee.ToList();
        }

        //Department

        public List<Department> GetDepartments()
        {
            return _ctx.Department.ToList();
        }

        // Vacancy Status
        public List<VacancyStatus> GetStatusVacancy()
        {
            return _ctx.VacancyStatus.ToList();
        }

        public List<Applicant> GetChosenApplicants(string vId)
        {
            List<ApplicantionList> list = _ctx.ApplicantionList.Where(v => v.VacancyId == vId)
                .Where(v => v.StatusId == 2)
                .ToList();
            List<Applicant> appList = new List<Applicant>();
            foreach (var item in list)
            {
                appList.Add(_ctx.Applicant.First(a => a.Id == item.ApplicantId));
            }

            return appList;
        }

        //Applicant
        public List<Applicant> GetApplicants()
        {
            List<Applicant> apps = _ctx.Applicant.ToList();
            foreach (Applicant app in apps)
            {
                app.Status = _ctx.ApplicantStatus.First(a => a.Id == app.StatusId);
            }
            return apps;
        }

        public Applicant GetApplicant(string id)
        {
            return _ctx.Applicant.First(u => u.Id == id);
        }

        public Applicant GetApplicantForm()
        {
            Applicant vac = new Applicant();
            string sId = _ctx.Applicant.OrderByDescending(b => b.Id).FirstOrDefault()?.Id;
            if (string.IsNullOrEmpty(sId))
            {
                vac.Id = "A0001";
            }
            else
            {
                sId = sId.Remove(0);
                int iId = Convert.ToInt32(sId) + 1;
                sId = iId.ToString();
                iId = iId.ToString().Length;
                for (int i = 0; i < 4 - iId; i++) sId = sId.Insert(0, "0");
                sId = sId.Insert(0, "A");
                vac.Id = sId;
            }
            return vac;
        }

        public bool CreateApplicant(Applicant app)
        {
            _ctx.Applicant.Add(app);
            return _ctx.SaveChanges() > 0;
        }

        public void EditApplicant(Applicant app)
        {
            Applicant oldVac = _ctx.Applicant.First(v => v.Id == app.Id);
            oldVac.Password = app.Password;
            oldVac.Name = app.Name;
            oldVac.Email = app.Email;
            oldVac.Phone = app.Phone;
            oldVac.Dob = app.Dob;
            oldVac.Gender = app.Gender;
            oldVac.CvFile = app.CvFile;
            oldVac.StatusId = app.StatusId;
            _ctx.SaveChanges();
        }

        public bool SetApplicantStatus(string aId, int aStat)
        {
            Vacancy updateStat = _ctx.Vacancy.First(v => v.Id == aId);
            updateStat.StatusId = aStat;
            return _ctx.SaveChanges() > 0;
        }

        public List<ApplicantStatus> GetApplicantStatus()
        {
            return _ctx.ApplicantStatus.ToList();
        }
    }
}