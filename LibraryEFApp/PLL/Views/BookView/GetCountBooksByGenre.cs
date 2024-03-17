using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetCountBooksByGenre
    {
        private IBookRepository bookRepository;
        public GetCountBooksByGenre(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите жанр");
            string genre = Console.ReadLine();
   

            var count = bookRepository.GetCountBooksByGenre(genre);

            if (count == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }

            
            Console.WriteLine("Книг: {0}", count);         

        }
    }
}
