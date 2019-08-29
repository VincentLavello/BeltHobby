using Microsoft.EntityFrameworkCore;
namespace BeltExam.Models
{
    public class BeltExamContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public BeltExamContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Hobby> Hobbies {get;set;}
        public DbSet<Enthusiast> Enthusiasts {get;set;}
    }
}
