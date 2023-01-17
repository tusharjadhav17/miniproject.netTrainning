using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyConsoleApplication1.Model;

public partial class TrainingDbContext : DbContext
{
    public TrainingDbContext()
    {
    }

    public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auther> Authers { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Depatment> Depatments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<MyTestTable> MyTestTables { get; set; }

    public virtual DbSet<Salary> Salaries { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentInfo> StudentInfos { get; set; }
    public object Book { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=10.10.10.8\\ISG_MSSQLSERVER;initial catalog=TrainingDB;user id=sa;password=pq+V2%g5gN!7;MultipleActiveResultSets=True;Persist Security Info=True;Integrated Security=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auther>(entity =>
        {
            entity.ToTable("Auther");

            entity.Property(e => e.AddedDate).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(512);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.Property(e => e.AddedDate).HasColumnType("date");
            entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Publisher).HasMaxLength(512);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_Auther");
        });

        modelBuilder.Entity<Depatment>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("Depatment");

            entity.Property(e => e.DeptId)
                .ValueGeneratedNever()
                .HasColumnName("dept_id");
            entity.Property(e => e.DeptLocation)
                .HasMaxLength(512)
                .HasColumnName("dept_location");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .HasColumnName("dept_name");
            entity.Property(e => e.EmpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("emp_id");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("Employee");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.DeptId)
                .HasMaxLength(512)
                .HasColumnName("dept_id");
            entity.Property(e => e.Email).HasMaxLength(512);
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("Emp_name");
            entity.Property(e => e.JobName)
                .HasMaxLength(50)
                .HasColumnName("job_name");
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<MyTestTable>(entity =>
        {
            entity.ToTable("MyTestTable");

            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(512);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Salary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Salary");

            entity.Property(e => e.EmpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("emp_id");
            entity.Property(e => e.Gread)
                .HasMaxLength(50)
                .HasColumnName("gread");
            entity.Property(e => e.MaxSalary)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("max_salary");
            entity.Property(e => e.MinSalary)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("min_salary");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .HasColumnName("SName");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<StudentInfo>(entity =>
        {
            entity.HasKey(e => e.StudantId);

            entity.ToTable("StudentInfo");

            entity.Property(e => e.StudantId).HasColumnName("StudantID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(512)
                .HasColumnName("EmailID");
            entity.Property(e => e.Sdept)
                .HasMaxLength(50)
                .HasColumnName("SDept");
            entity.Property(e => e.Slocation)
                .HasMaxLength(50)
                .HasColumnName("SLocation");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .HasColumnName("SName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
