﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Models;
using System.Reflection.Metadata;

namespace ProjectFinal1.Data;

public class ProjectDbContext : IdentityDbContext<AppilcationUser>
{
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
        : base(options)
    {
    }
    public DbSet<AppilcationUser> AspNetUsers { get; set; }
    public DbSet<DataUser> DataUsers { get; set; }
    public DbSet<CsCourse> CsCourse { get; set; }
    public DbSet<CsCourseStruc> CsCourseStruc { get; set; }
    public DbSet<CsSubgroup> CsSubgroup { get; set; }
    public DbSet<CsSubtype> CsSubtype { get; set; }
    public DbSet<TraCourse> TraCourse { get; set; }
    public DbSet<TraSub> TraSub { get; set; }
    public DbSet<TransferSub> TransferSub { get; set; }
    public DbSet<TransferCourse> TransferCourse { get; set; }
    public DbSet<TableTransfer> TableTransfer { get; set; }
    public DbSet<V_CourseCss> V_CourseCss { get; set; }
    public DbSet<V_CourseTra> V_CourseTra { get; set; }
    public DbSet<V_CourseCsTra> V_CourseCsTra { get; set; }
    public DbSet<V_TransferSub> V_TransferSub { get; set; }
    public DbSet<V_User_Tranfer_Course> V_User_Tranfer_Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder
      .Entity<DataUser>()
      .HasMany(e => e.Tranfers)
      .WithOne(e => e.User)
      .OnDelete(DeleteBehavior.ClientCascade);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

}
