using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryEFApp.BLL.Services;
using LibraryEFApp.DAL.Entities;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class UsersListView
    {
        UserService userService;
        public UsersListView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show()
        {
            Console.WriteLine("Пользователи");

            var users = userService.FindAll();

            if (users.Count() == 0)
            {
                Console.WriteLine("Пользователей нет");
                return;
            }

            users.ToList().ForEach(user =>
            {
                Console.WriteLine("Имя: {0}", user.Name);
                Console.WriteLine("Email: {0}", user.Email);
            });
        }
    }
}
