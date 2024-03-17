using LibraryEFApp.DAL.Entities;
using LibraryEFApp.BLL.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryEFApp.DAL.Repositories
{
    
    public class UserRepository : AppContextEF, IUserRepository
    {
        IBookRepository bookRepository;
        public UserRepository(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void AddUser(UserEntity userEntity)
        {
            using (var db = new AppContextEF())
            {

                // Добавление пользователя
                db.Users.Add(userEntity);

                db.SaveChanges();
            }

        }
        public List<UserEntity> FindAll()
        {

            List<UserEntity> allUsers;
            using (var db = new AppContextEF())
            {

                allUsers = db.Users.ToList();

            }
            return allUsers;

        }
        public UserEntity FindById(int id)
        {
            using (var db = new AppContextEF())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    throw new UserNotFoundException();
                }

                return user;
            }

        }
        public void Delete(string name, string email)
        {
            using (var db = new AppContextEF())
            {
                var user = db.Users.FirstOrDefault(u => u.Name == name && u.Email == email);

                if (user == null)
                {
                    throw new UserNotFoundException();
                }
              

                db.Users.Remove(user);

                db.SaveChanges();
            }
            
        }
        public void UpdateById(int id, string name)
        {
            using (var db = new AppContextEF())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == id);
                user.Name = name;

                db.SaveChanges();
            }

        }

        public void GetBookFromLibrary(int userId, int bookId)
        {
            using (var db = new AppContextEF())
            {

                BookEntity book = db.Books.FirstOrDefault(b => b.Id == bookId);
                if (book == null)
                    throw new BookNotFoundException();


                UserEntity user = db.Users.FirstOrDefault(u => u.Id == userId);

                if (user == null)
                    throw new UserNotFoundException();


                user.Books.Add(book);
                db.SaveChanges();


            }

        }
        public int GetUserCountBooks(UserEntity userEntity)
        {
            using (var db = new AppContextEF())
            {

                int count = db.Books.Where(b => b.Users.Contains(userEntity)).ToList().Count();
                return count;
            }

        }


    }

    public interface IUserRepository
    {   
        void AddUser(UserEntity userEntity);
        public List<UserEntity> FindAll();
        UserEntity FindById(int id);
        void Delete(string name, string email);
        void UpdateById(int id, string value);
        public void GetBookFromLibrary(int userId, int bookId);
        int GetUserCountBooks(UserEntity userEntity);

    };
}
