using dawp_lecture_2.Models;
using Microsoft.EntityFrameworkCore;

namespace dawp_lecture_2.Data
{
    public class Lec2DBData(DbContextOptions<Lec2DBData> options) : DbContext(options)
    {
        public DbSet<Person> people { set; get; }
        public DbSet<Dog> Dogs { set; get; }
    }
}
