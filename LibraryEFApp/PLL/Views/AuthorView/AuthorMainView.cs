using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.AuthorView
{
    public class AuthorMainView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Добавить автора (нажмите 1)");
                Console.WriteLine("Вывести список всех авторов (нажмите 2)");
                Console.WriteLine("Найти автора по Id (нажмите 3)");
                Console.WriteLine("Удалить автора (нажмите 4)");
                Console.WriteLine("Обновить данные автора (нажмите 5)");

                Console.WriteLine("Выйти из программы (нажмите 8)");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.addAuthorView.Show();
                            break;
                        }
                    case "2":
                        {
                            Program.authorsListView.Show();
                            break;
                        }
                    case "3":
                        {
                            Program.authorInfoView.Show();
                            break;
                        }
                    case "4":
                        {
                            Program.authorDeleteView.Show();
                            break;
                        }
                    case "5":
                        {
                            Program.authorUpdateView.Show();
                            break;
                        }
                }
            }

        }
    }
}
