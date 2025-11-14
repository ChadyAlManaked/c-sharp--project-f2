using ConsoleApp3;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

public class StudentContext : DbCont

// This DbSet represents the col

public DbSet<Student> Students {


protected override void OnConfig

{

// Configure the connection string to your local database
        // The database will be created for you if it doesn't exist
        optionsBuilder.UseSqlServer("Server=.;Database=StudentDataBase;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
