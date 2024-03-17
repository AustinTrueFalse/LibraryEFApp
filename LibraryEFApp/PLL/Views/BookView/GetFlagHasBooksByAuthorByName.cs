using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetFlagHasBooksByAuthorByName
    {
        private IBookRepository bookRepository;
        private IAuthorRepository authorRepository;
        public GetFlagHasBooksByAuthorByName(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id автора");
            int authorId = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите название книги");
            string name = Console.ReadLine();

            var author = authorRepository.FindById(authorId);

            var count = bookRepository.GetFlagHasBooksByAuthorByName(author, name);

            if (count)
            {
                Console.WriteLine("Книги есть");
                return;
            }


            Console.WriteLine("Книг нет");

        }
    }
}
