using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using OA.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OA.Domin;
using OA.Domin.Reporting;
using OA.Domin.Logging;
using OA.Domin.Settings;
using OA.Domin.Notifications;
using OA.Domin.Administration;
using OA.DataAccess.Auditing;
using OA.Domin.Auditing;
using OA.Domin.Reporting.TemplateReporting;
using OA.Domin.DSA;
using OA.Domin.DSA.Indexes;

namespace OA.DataAccess
{
    public partial class AppDbContext : IdentityDbContext<User>
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            httpContextAccessor = this.GetInfrastructure().GetRequiredService<IHttpContextAccessor>();
        }

        //Reporting
        public DbSet<ReportableTable> ReportableTables { get; set; }
        public DbSet<ReportTemplate> ReportTemplates { get; set; }
        public DbSet<ReportHeader> ReportHeaders { get; set; }
        public DbSet<ReportTextTemplate> ReportTextTemplates { get; set; }

        //Exception Log
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }

        //App Settings
        public DbSet<AppSetting> AppSettings { get; set; }

        //Notification
        public DbSet<Notification> Notifications { get; set; }

        //Administration
        public DbSet<SignupRequest> SignupRequests { get; set; }
        public DbSet<PermissionClaim> PermissionClaims { get; set; }
        public DbSet<VerificationQuestion> VerificationQuestions { get; set; }
        public DbSet<UserVerificationAnswer> UserVerificationAnswers { get; set; }

        //Auditing 
        public DbSet<Audit> Audits { get; set; }

               
        //APP DB SETS
        public DbSet<Block> Blocks { get; set; }
        public DbSet<BlockCategory> BlockCategories { get; set; }
        public DbSet<BlockTranslation> BlockTranslations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventCategoryTranslation> EventCategoryTranslations { get; set; }
        public DbSet<EventTranslation> EventTranslations { get; set; }
        public DbSet<MenueCategory> MenuCategories { get; set; }
        public DbSet<Menue> Menues { get; set; }
        public DbSet<MenueTranslation> MenueTranslations { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageTranslation> PageTranslations { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ArticleTranslation> ArticleTranslations { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Person> People { get; set; }
        public DbSet<PersonDonator> PersonDonators { get; set; }
        public DbSet<CorporateDonator> CorporateDonators { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<CorporateBeneficiary> CorporateBeneficiaries { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<DonationRequest> DonationRequests { get; set; }
        public DbSet<DonationOffer> DonationOffers { get; set; }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Project> Projects { get; set; }


        //APP Indexes
        public DbSet<City> Cities { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<AcademicQualification> AcademicQualifications { get; set; }
        public DbSet<DonationType> DonationTypes { get; set; }
        

 
        //Testing functionality
        //public DbSet<WeatherForecast> WeatherForecasts { get; set; }


    }
}
