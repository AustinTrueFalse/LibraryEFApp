using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.DAL.Entities
{
    public class AppContextEF : DbContext
    {
        // Объекты таблицы
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }

        public AppContextEF()
        {
            Database.EnsureCreated();
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AUSTIN69\SQLEXPRESS01;Database=EFLibrary;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
        }
    }


}
