
global using Microsoft.EntityFrameworkCore;

namespace DemoApp.framework;

public class ShopDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\DACIIT;Database=EmployeeAssign");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .ToTable("Department")
            .Property(p => p.Id)
            .HasColumnName("DeptNo");
        modelBuilder.Entity<Employee>()
            .ToTable("Employee")
            .Property(p => p.Id)
            .HasColumnName("EmpNo");
        modelBuilder.Entity<Employee>()
            .Property(p => p.Salary)
            .HasColumnName("EmpSalary");
        modelBuilder.Entity<Employee>()
            .Property(p => p.DepartmentId)
            .HasColumnName("DeptNo");
    }
}