using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PARKJS.WORK.STUDY04.Models.CustomIdentityModel;
using PARKJS.WORK.STUDY04.Models.Actress;

namespace PARKJS.WORK.STUDY04.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Actress_JP> Actress_JP { get; set; }
    }
}
