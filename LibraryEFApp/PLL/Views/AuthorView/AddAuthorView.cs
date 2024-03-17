using LibraryEFApp.PLL.Helpers;
using LibraryEFApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.DAL.Repositories;

namespace LibraryEFApp.PLL.Views.AuthorView
{
    public class AddAuthorView
    {
        private IAuthorRepository authorRepository;
        public AddAuthorView(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public void Show()
        {
            var author = new AuthorEntity();

            Console.WriteLine("Введите имя автора:");
            author.FirstName = Console.ReadLine();

            Console.Write("Введите фамилию автора:");
            author.LastName = Console.ReadLine();

            author.Books = new List<BookEntity>();

           
            try
            {
                this.authorRepository.AddAuthor(author);

                SuccessMessage.Show("Данные записаны");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка добавления.");
            }
        }
 
    }
}
