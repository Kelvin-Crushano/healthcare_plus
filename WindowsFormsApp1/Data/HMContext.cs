using HospitalProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace HospitalProject.Data
{
    public partial class HMContext : DbContext
    {
       public HMContext()
        {
            Database.Migrate();
        }

        public virtual DbSet<Appointment_schedule> AppointmentSchedule { get; set; }
        public virtual DbSet<Availability> Availabilities { get; set; }
        public virtual DbSet<Custom_treatment_plan> Custom_Treatment_Plans { get; set; }
        public virtual DbSet<Fasting_blood_sugar_test_report> Fasting_Blood_Sugar_Test_Reports { get; set; }
        public virtual DbSet<CT_scan_report> CT_Scan_Reports { get; set; }
        public virtual DbSet<Illness> Illnesses { get; set; }
        public virtual DbSet<Imaging_studies_list> Imaging_Studies_Lists { get; set; }
        public virtual DbSet<Injury> Injuries { get; set; }
        public virtual DbSet<Job_role> Job_Roles { get; set; }
        public virtual DbSet<Lipid_profile_test_report> Lipid_Profile_Test_Reports { get; set; }
        public virtual DbSet<Medical_resources> Medical_Resources { get; set; }
        public virtual DbSet<Medical_test> Medical_Tests { get; set; }
        public virtual DbSet<Medication_price> Medication_Prices { get; set; }
        public virtual DbSet<Operation_theatre> Operation_Theatres { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Patient_illness> Patient_Illnesses { get; set; }
        public virtual DbSet<Patient_injury> Patient_Injuries { get; set; }
        public virtual DbSet<Physician> Physicians { get; set; }
        public virtual DbSet<Physician_availability> Physician_Availabilities { get; set; }
        public virtual DbSet<Physician_contact> Physician_Contacts { get; set; }
        public virtual DbSet<Physician_qualification> Physician_Qualifications { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Room_admission> Room_Admissions { get; set; }
        public virtual DbSet<Room_facility> Room_Facilities { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Surgery> Surgeries { get; set; }
        public virtual DbSet<Surgery_type> GetSurgery_Types { get; set; }
        public virtual DbSet<Thyroxine_test_report> Thyroxine_Test_Reports { get; set; }
        public virtual DbSet<User_account> User_Accounts { get; set; }
        public virtual DbSet<X_ray_scan_report> X_Ray_Scan_Reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HMMGT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_account>().
                HasOne<Staff>(user => user.Staff).
                WithOne(staff => staff.User_Account).
                HasForeignKey<User_account>(user => user.Staff_id).
                HasConstraintName("FK_Staff_Id");


            modelBuilder.Entity<Staff>().
                HasOne<Job_role>(staff => staff.Job_Role).
                WithMany(job => job.Staffs).
                HasForeignKey(staff => staff.Job_Role_Id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Job_Role_Id");

            modelBuilder.Entity<Physician_contact>().
                HasOne<Physician>(pcontact => pcontact.Physician).
                WithMany(physician => physician.Physician_Contacts).
                HasForeignKey(pcontact => pcontact.Physician_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Physician_id");

            modelBuilder.Entity<Physician_availability>().
                HasOne<Physician>(pavailability => pavailability.Physician).
                WithMany(physician => physician.Physician_Availabilities).
                HasForeignKey(pavailability => pavailability.Physician_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Physician_id");

            modelBuilder.Entity<Physician_availability>().
               HasOne<Availability>(pavailability => pavailability.Availability).
               WithMany(availability => availability.Physician_Availabilities).
               HasForeignKey(pavailability => pavailability.Availability_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Availability_id");

            modelBuilder.Entity<Physician_qualification>().
                HasOne<Physician>(pqualification => pqualification.Physician).
                WithMany(physician => physician.Physician_Qualifications).
                HasForeignKey(pqualification => pqualification.Physician_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Physician_id");

            modelBuilder.Entity<Physician_qualification>().
                HasOne<Qualification>(pqualification => pqualification.Qualification).
                WithMany(qualification => qualification.Physician_Qualifications).
                HasForeignKey(pqualification => pqualification.Qualification_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Qualification_id");

            modelBuilder.Entity<Appointment_schedule>().
                HasOne<Physician_availability>(appschedule => appschedule.Physician_Availability).
                WithMany(physician_availability => physician_availability.Appointment_Schedules).
                HasForeignKey(appschedule => appschedule.Pa_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Pa_id");

            modelBuilder.Entity<Appointment_schedule>().
                HasOne<Patient>(appschedule => appschedule.Patient).
                WithOne(patient => patient.Appointment_Schedule).
                HasForeignKey<Appointment_schedule>(appschedule => appschedule.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Patient_illness>().
                HasOne<Patient>(patient_ill => patient_ill.Patient).
                WithMany(patient => patient.Patient_Illnesses).
                HasForeignKey(patient_ill => patient_ill.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Patient_illness>().
               HasOne<Illness>(patient_ill => patient_ill.Illness).
               WithMany(illness => illness.Patient_Illnesses).
               HasForeignKey(patient_ill => patient_ill.Illness_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Illness_id");

            modelBuilder.Entity<Patient_injury>().
                HasOne<Patient>(patient_injury => patient_injury.Patient).
                WithMany(patient => patient.Patient_Injuries).
                HasForeignKey(patient_injury => patient_injury.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Patient_injury>().
                HasOne<Injury>(patient_injury => patient_injury.Injury).
                WithMany(injury => injury.Patient_Injuries).
                HasForeignKey(patient_injury => patient_injury.Injury_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Injury_id");


            modelBuilder.Entity<Fasting_blood_sugar_test_report>().
                HasOne<Patient>(fasting_blood_sugar_test_report => fasting_blood_sugar_test_report.Patient).
                WithOne(patient => patient.Fasting_Blood_Sugar_Test_Report).
                HasForeignKey<Fasting_blood_sugar_test_report>(fasting_blood_sugar_test_report => fasting_blood_sugar_test_report.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Fasting_blood_sugar_test_report>().
                HasOne<Medical_test>(fasting_blood_sugar_test_report => fasting_blood_sugar_test_report.Medical_Test).
                WithOne(medical_test => medical_test.Fasting_Blood_Sugar_Test_Report).
                HasForeignKey<Fasting_blood_sugar_test_report>(fasting_blood_sugar_test_report => fasting_blood_sugar_test_report.Medical_test_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Medical_test_id");


            modelBuilder.Entity<Thyroxine_test_report>().
                HasOne<Patient>(thyrox_test_report => thyrox_test_report.Patient).
                WithOne(patient => patient.Thyroxine_Test_Report).
                HasForeignKey<Thyroxine_test_report>(thyrox_test_report => thyrox_test_report.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Thyroxine_test_report>().
               HasOne<Medical_test>(thyrox_test_report => thyrox_test_report.Medical_Test).
               WithOne(medical_test => medical_test.Thyroxine_Test_Report).
               HasForeignKey<Thyroxine_test_report>(thyrox_test_report => thyrox_test_report.Medical_test_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Medical_test_id");


            modelBuilder.Entity<Lipid_profile_test_report>().
                HasOne<Patient>(lipid_profile_test_report => lipid_profile_test_report.Patient).
                WithOne(patient => patient.Lipid_Profile_Test_Report).
                HasForeignKey<Lipid_profile_test_report>(lipid_profile_test_report => lipid_profile_test_report.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Lipid_profile_test_report>().
               HasOne<Medical_test>(lipid_profile_test_report => lipid_profile_test_report.Medical_Test).
               WithOne(medical_test => medical_test.Lipid_Profile_Test_Report).
               HasForeignKey<Lipid_profile_test_report>(lipid_profile_test_report => lipid_profile_test_report.Medical_test_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Medical_test_id");







            modelBuilder.Entity<X_ray_scan_report>().
                HasOne<Patient>(x_ray_scan_report => x_ray_scan_report.Patient).
                WithOne(patient => patient.X_Ray_Scan_Report).
                HasForeignKey<X_ray_scan_report>(x_ray_scan_report => x_ray_scan_report.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<X_ray_scan_report>().
                HasOne<Imaging_studies_list>(x_ray_scan_report => x_ray_scan_report.Imaging_Studies_List).
                WithOne(imaging_studies_list => imaging_studies_list.X_Ray_Scan_Report).
                HasForeignKey<X_ray_scan_report>(x_ray_scan_report => x_ray_scan_report.Is_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Is_id");

            modelBuilder.Entity<X_ray_scan_report>().
               HasOne<Medical_resources>(x_ray_scan_report => x_ray_scan_report.Medical_Resources).
               WithOne(medical_resources => medical_resources.X_Ray_Scan_Report).
               HasForeignKey<X_ray_scan_report>(x_ray_scan_report => x_ray_scan_report.Mr_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Mr_id");

            
            modelBuilder.Entity<CT_scan_report>().
               HasOne<Patient>(ct_scan_report => ct_scan_report.Patient).
               WithOne(patient => patient.CT_Scan_Report).
               HasForeignKey<CT_scan_report>(ct_scan_report => ct_scan_report.Patient_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Patient_id");


            modelBuilder.Entity<CT_scan_report>().
               HasOne<Imaging_studies_list>(ct_scan_report => ct_scan_report.Imaging_Studies_List).
               WithOne(imaging_studies_list => imaging_studies_list.CT_Scan_Report).
               HasForeignKey<CT_scan_report>(ct_scan_report => ct_scan_report.Is_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Is_id");

            modelBuilder.Entity<CT_scan_report>().
               HasOne<Medical_resources>(ct_scan_report => ct_scan_report.Medical_Resources).
               WithOne(medical_resources => medical_resources.CT_Scan_Report).
               HasForeignKey<CT_scan_report>(ct_scan_report => ct_scan_report.Mr_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Mr_id");


            modelBuilder.Entity<Surgery>().
                HasOne<Patient>(surgery => surgery.Patient).
                WithOne(patient => patient.Surgery).
                HasForeignKey<Surgery>(surgery => surgery.Patient_id).
                OnDelete(DeleteBehavior.ClientSetNull).
                HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Surgery>().
               HasOne<Surgery_type>(surgery => surgery.Surgery_Type).
               WithOne(surgery_type => surgery_type.Surgery).
               HasForeignKey<Surgery>(surgery => surgery.Surgery_type_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Surgery_type_id");

            modelBuilder.Entity<Surgery>().
              HasOne<Operation_theatre>(surgery => surgery.Operation_Theatre).
              WithOne(operation_theatre => operation_theatre.Surgery).
              HasForeignKey<Surgery>(surgery => surgery.OT_id).
              OnDelete(DeleteBehavior.ClientSetNull).
              HasConstraintName("FK_OT_id");
            
            modelBuilder.Entity<Room_admission>().
               HasOne<Patient>(room_admission => room_admission.Patient).
               WithOne(patient => patient.Room_Admission).
               HasForeignKey<Room_admission>(room_admission => room_admission.Patient_id).
               OnDelete(DeleteBehavior.ClientSetNull).
               HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Room_admission>().
              HasOne<Room_facility>(room_admission => room_admission.Room_Facility).
              WithOne(room_facility => room_facility.Room_Admission).
              HasForeignKey<Room_admission>(room_admission => room_admission.Room_facility_id).
              OnDelete(DeleteBehavior.ClientSetNull).
              HasConstraintName("FK_Room_facility_id");

            modelBuilder.Entity<Custom_treatment_plan>().
              HasOne<Patient>(custom_treat_plan => custom_treat_plan.Patient).
              WithOne(patient => patient.Custom_Treatment_Plan).
              HasForeignKey<Custom_treatment_plan>(custom_treat_plan => custom_treat_plan.Patient_id).
              OnDelete(DeleteBehavior.ClientSetNull).
              HasConstraintName("FK_Patient_id");

            modelBuilder.Entity<Custom_treatment_plan>().
              HasOne<Medication_price>(custom_treat_plan => custom_treat_plan.Medication_Price).
              WithMany(med_price => med_price.Custom_Treatment_Plans).
              HasForeignKey(custom_treat_plan => custom_treat_plan.medication_id).
              OnDelete(DeleteBehavior.ClientSetNull).
              HasConstraintName("FK_Med_Price");






            

            

            

            


               
                


































        }
    }
}
