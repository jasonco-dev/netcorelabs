
using Microsoft.EntityFrameworkCore;
using mvc_web_api.Models;

namespace mvc_web_api.Persistence
{
    public class PersonContext: DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options): base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}