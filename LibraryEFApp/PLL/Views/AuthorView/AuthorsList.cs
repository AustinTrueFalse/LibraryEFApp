using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;

namespace LibraryEFApp.PLL.Views.AuthorView
{
    public class AuthorsListView
    {
        private IAuthorRepository authorRepository;
        public AuthorsListView(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        public void Show()
        {
            Console.WriteLine("Авторы");

            var authors = authorRepository.FindAll();

            if (authors.Count() == 0)
            {
                Console.WriteLine("Авторов нет");
                return;
            }

            authors.ToList().ForEach(author =>
            {
                Console.WriteLine("Имя: {0}", author.FirstName);
                Console.WriteLine("Email: {0}", author.LastName);
            });
        }
    }
}
