using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class UsersListView
    {
        private IUserRepository userRepository;
        public UsersListView(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Show()
        {
            Console.WriteLine("Пользователи");

            var users = userRepository.FindAll();

            if (users.Count() == 0)
            {
                Console.WriteLine("Пользователей нет");
                return;
            }

            users.ToList().ForEach(user =>
            {
                Console.WriteLine("Имя: {0} Email: {1}", user.Name, user.Email);
            });
        }
    }
}
