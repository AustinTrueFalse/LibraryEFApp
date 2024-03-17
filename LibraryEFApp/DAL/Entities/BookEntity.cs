using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LibraryEFApp.DAL.Entities
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public List<UserEntity> Users { get; set; } = new List<UserEntity>();
        public AuthorEntity AuthorEntity { get; set; }

    }
}
