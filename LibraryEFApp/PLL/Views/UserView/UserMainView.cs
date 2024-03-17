using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.UserView
{
    public class UserMainView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Добавить пользователя (нажмите 1)");
                Console.WriteLine("Вывести список всех пользователей (нажмите 2)");
                Console.WriteLine("Найти пользователя по Id (нажмите 3)");
                Console.WriteLine("Удалить пользователя (нажмите 4)");
                Console.WriteLine("Обновить имя пользователя по Id (нажмите 5)");
                Console.WriteLine("Получить книгу из библиотеки (нажмите 6)");
                Console.WriteLine("Получить кол-во книг пользователя (нажмите 7)");

                Console.WriteLine("Выйти из программы (нажмите 8)");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.addUserView.Show();
                            break;
                        }
                    case "2":
                        {
                            Program.usersListView.Show();
                            break;
                        }
                    case "3":
                        {
                            Program.userInfoView.Show();
                            break;
                        }
                    case "4":
                        {
                            Program.userDeleteView.Show();
                            break;
                        }
                    case "5":
                        {
                            Program.userUpdateView.Show();
                            break;
                        }
                    case "6":
                        {
                            Program.getBookUserView.Show();
                            break;
                        }
                    case "7":
                        {
                            Program.getUserCountBooks.Show();
                            break;
                        }
                }
            }

        }
    }
}
