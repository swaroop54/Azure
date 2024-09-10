using Microsoft.EntityFrameworkCore;
using mvc4.Models;
namespace mvc4.Data;

public class CustomerDbContext:DbContext{
    private const string conn="Server=tcp:sql-server-customerr.database.windows.net,1433;Initial Catalog=customer;Persist Security Info=False;User ID=Customer;Password=Swaroop@27;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer(conn);
    }
    public DbSet<Customer> Customers { get; set;}
}