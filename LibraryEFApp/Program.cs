using LibraryEFApp.BLL.Services;
using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Views;
using LibraryEFApp.PLL.Views.UserView;
using LibraryEFApp.PLL.Views.BookView;

public class Program
{
    static UserService userService;
    static BookService bookService;

    public static MainView mainView;

    public static UserMainView userMainView;
    public static BookMainView bookMainView;

    public static AddUserView addUserView;
    public static AddBookView addBookView;

    public static UsersListView usersListView;
    public static BooksListView booksListView;

    public static UserInfoView userInfoView;
    public static BookInfoView bookInfoView;

    public static UserDeleteView userDeleteView;
    public static BookDeleteView bookDeleteView;

    public static UserUpdateView userUpdateView;
    public static BookUpdateView bookUpdateView;

    static void Main(string[] args)
    {
        userService = new UserService();
        bookService = new BookService();

        mainView = new MainView();
        
        userMainView = new UserMainView();
        addUserView = new AddUserView(userService);
        usersListView = new UsersListView(userService);
        userInfoView = new UserInfoView(userService);
        userDeleteView = new UserDeleteView(userService);
        userUpdateView = new UserUpdateView(userService);

        bookMainView = new BookMainView();
        addBookView = new AddBookView(bookService);
        booksListView = new BooksListView(bookService);
        bookInfoView = new BookInfoView(bookService);
        bookDeleteView = new BookDeleteView(bookService);
        bookUpdateView = new BookUpdateView(bookService);


        while (true)
        {
            mainView.Show();
        }
    }

}