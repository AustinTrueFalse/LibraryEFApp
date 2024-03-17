using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class GetUserCountBooks
    {
        private IUserRepository userRepository;
        public GetUserCountBooks(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Show()
        {
            Console.WriteLine("Введите id пользователя");
            int userId = int.Parse(Console.ReadLine());

            var user = userRepository.FindById(userId);

            var count = userRepository.GetUserCountBooks(user);

            if (count == 0)
            {
                Console.WriteLine("Книг нет");
                return;
            }


            Console.WriteLine("Книг: {0}", count);

        }
    }
}
