using PersonalWebsite.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalWebsite.Shared;

namespace PersonalWebsite.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experince> Experinces { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var educationEntity = modelBuilder.Entity<Education>();
            educationEntity.HasKey(education => education.EducationID);

            var skillEntity = modelBuilder.Entity<Skill>();
            skillEntity.HasKey(skill => skill.SkillID);

            var experinceEntity = modelBuilder.Entity<Experince>();
            experinceEntity.HasKey(experince => experince.ExperincenceID);

            var contactInfoEntity = modelBuilder.Entity<ContactInfo>();
            contactInfoEntity.HasKey(contactInfo => contactInfo.ContactInfoID);
        }
    }
}
