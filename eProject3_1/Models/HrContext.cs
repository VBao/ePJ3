using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eProject3_1.Models
{
    public partial class HrContext : DbContext
    {
        public HrContext()
        {
        }

        public HrContext(DbContextOptions<HrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<ApplicantStatus> ApplicantStatus { get; set; }
        public virtual DbSet<ApplicantionList> ApplicantionList { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<InterviewDetail> InterviewDetail { get; set; }
        public virtual DbSet<InterviewStatus> InterviewStatus { get; set; }
        public virtual DbSet<Interviewer> Interviewer { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }
        public virtual DbSet<VacancyStatus> VacancyStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:Hr");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CvFile)
                    .HasColumnName("Cv_File")
                    .HasColumnType("text");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Applicant)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Applicant_Applicant_Status");
            });

            modelBuilder.Entity<ApplicantStatus>(entity =>
            {
                entity.ToTable("Applicant_Status");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicantionList>(entity =>
            {
                entity.ToTable("Applicantion_List");

                entity.Property(e => e.ApplicantId)
                    .HasColumnName("Applicant_Id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.VacancyId)
                    .HasColumnName("Vacancy_Id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.ApplicantionList)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_Applicantion_List_Applicant");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ApplicantionList)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("Applicantion_List_Interview_Status_id_fk");

                entity.HasOne(d => d.Vacancy)
                    .WithMany(p => p.ApplicantionList)
                    .HasForeignKey(d => d.VacancyId)
                    .HasConstraintName("FK_Applicantion_List_Vacancy");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("Department_Id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_Department");
            });

            modelBuilder.Entity<InterviewDetail>(entity =>
            {
                entity.ToTable("Interview_Detail");

                entity.Property(e => e.ApplicationListId).HasColumnName("Application_List_Id");


                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .HasColumnName("End_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InterviewerId).HasColumnName("Interviewer_Id");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start_Time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ApplicationList)
                    .WithMany(p => p.InterviewDetail)
                    .HasForeignKey(d => d.ApplicationListId)
                    .HasConstraintName("FK_Interview_Detail_Applicantion_List");

                entity.HasOne(d => d.Interviewer)
                    .WithMany(p => p.InterviewDetail)
                    .HasForeignKey(d => d.InterviewerId)
                    .HasConstraintName("FK_Interview_Detail_Interviewer");
            });

            modelBuilder.Entity<InterviewStatus>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Interview_Status_pk")
                    .IsClustered(false);

                entity.ToTable("Interview_Status");

                entity.HasIndex(e => e.Status)
                    .HasName("Interview_Status_Status_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Interviewer>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("Department_Id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Interviewer)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Interviewer_Department");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Close).HasColumnType("date");

                entity.Property(e => e.CreateAt).HasColumnType("date");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("Department_Id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");

                entity.Property(e => e.JobNumber).HasColumnName("Job_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Vacancy)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Vacancy_Department");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Vacancy)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Vacancy_Employee");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Vacancy)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Vacancy_Vacancy_Status");
            });

            modelBuilder.Entity<VacancyStatus>(entity =>
            {
                entity.ToTable("Vacancy_Status");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
