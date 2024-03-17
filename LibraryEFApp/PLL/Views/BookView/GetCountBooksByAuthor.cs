using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetCountBooksByAuthor
    {
        private IBookRepository bookRepository;
        private IAuthorRepository authorRepository;
        public GetCountBooksByAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id автора");
            int authorId = int.Parse(Console.ReadLine());

            var author = authorRepository.FindById(authorId);

            var count = bookRepository.GetCountBooksByAuthor(author);

            if (count == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }


            Console.WriteLine("Книг: {0}", count);

        }
    }
}
