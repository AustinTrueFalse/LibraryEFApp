using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.DAL.Repositories
{
    public class AuthorRepository : AppContextEF, IAuthorRepository
    {
       
        public void AddAuthor(AuthorEntity authorEntity)
        {
            using (var db = new AppContextEF())
            {

                // Добавление пользователя
                db.Authors.Add(authorEntity);

                db.SaveChanges();
            }

        }
        public List<AuthorEntity> FindAll()
        {

            List<AuthorEntity> allAuthors;
            using (var db = new AppContextEF())
            {

                allAuthors = db.Authors.ToList();

            }
            return allAuthors;

        }
        public AuthorEntity FindById(int id)
        {
            using (var db = new AppContextEF())
            {
                var author = db.Authors.FirstOrDefault(u => u.Id == id);
                if (author == null)
                {
                    throw new UserNotFoundException();
                }

                return author;
            }

        }
        public void Delete(string name, string lastname)
        {
            using (var db = new AppContextEF())
            {
                var author = db.Authors.FirstOrDefault(a => a.FirstName == name && a.LastName == lastname);

                if (author == null)
                {
                    throw new UserNotFoundException();
                }


                db.Authors.Remove(author);

                db.SaveChanges();
            }

        }
        public void UpdateById(int id, string name, string lastname)
        {
            using (var db = new AppContextEF())
            {
                var author = db.Authors.FirstOrDefault(a => a.Id == id);
                author.FirstName = name;
                author.LastName = lastname;

                db.SaveChanges();
            }

        }
        
    }

    public interface IAuthorRepository
    {
        void AddAuthor(AuthorEntity authorEntity);
        public List<AuthorEntity> FindAll();
        AuthorEntity FindById(int id);
        void Delete(string name, string lastname);
        void UpdateById(int id, string name, string lastname);


    }
}
