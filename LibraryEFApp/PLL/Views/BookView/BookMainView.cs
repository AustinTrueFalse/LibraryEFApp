using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.PLL.Views.BookView
{
    public class BookMainView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Добавить книгу (нажмите 1)");
                Console.WriteLine("Вывести список всех книг (нажмите 2)");
                Console.WriteLine("Найти книгу по Id (нажмите 3)");
                Console.WriteLine("Удалить книгу (нажмите 4)");
                Console.WriteLine("Обновить год выпуска по Id (нажмите 5)");

                Console.WriteLine("Выйти из программы (нажмите 8)");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.addBookView.Show();
                            break;
                        }
                    case "2":
                        {
                            Program.booksListView.Show();
                            break;
                        }
                    case "3":
                        {
                            Program.bookInfoView.Show();
                            break;
                        }
                    case "4":
                        {
                            Program.bookDeleteView.Show();
                            break;
                        }
                    case "5":
                        {
                            Program.bookUpdateView.Show();
                            break;
                        }
                }
            }

        }
    }
}
