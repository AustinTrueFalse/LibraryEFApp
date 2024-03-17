using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class GetFlagHasBooksByUserByName
    {
        private IBookRepository bookRepository;
        private IUserRepository userRepository;
        public GetFlagHasBooksByUserByName(IBookRepository bookRepository, IUserRepository userRepository)
        {
            this.bookRepository = bookRepository;
            this.userRepository = userRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите Id пользователя");
            int userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите название книги");
            string name = Console.ReadLine();

            var user = userRepository.FindById(userId);

            var count = bookRepository.GetFlagHasBooksByUserByName(user, name);

            if (count)
            {
                Console.WriteLine("У пользователя есть книга с таким названием");
                return;
            }


            Console.WriteLine("У пользователей не таких книг");

        }
    }
}
