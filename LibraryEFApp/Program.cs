using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;
using LibraryEFApp.PLL.Views;
using LibraryEFApp.PLL.Views.UserView;
using LibraryEFApp.PLL.Views.BookView;
using LibraryEFApp.PLL.Views.AuthorView;
public class Program
{
    static IAuthorRepository authorRepository = new AuthorRepository();
    static IBookRepository bookRepository = new BookRepository();
    static IUserRepository userRepository = new UserRepository(bookRepository);

    public static MainView mainView;

    public static UserMainView userMainView;
    public static AddUserView addUserView;
    public static UsersListView usersListView;
    public static UserInfoView userInfoView;
    public static UserDeleteView userDeleteView;
    public static UserUpdateView userUpdateView;
    public static GetBookUserView getBookUserView;
    public static GetUserCountBooks getUserCountBooks;

    public static BookMainView bookMainView;
    public static AddBookView addBookView;   
    public static BooksListView booksListView;
    public static BooksListOrderByName booksListOrderByName;
    public static BooksListOrderByYear booksListOrderByYear;
    public static BookInfoView bookInfoView;    
    public static BookDeleteView bookDeleteView;
    public static BookUpdateView bookUpdateView;
    public static GetBookListByGenreByYear getBookListByGenreByYearView;
    public static GetCountBooksByGenre getCountBooksByGenre;
    public static GetCountBooksByAuthor getCountBooksByAuthor;
    public static GetFlagHasBooksByAuthorByName getFlagHasBooksByAuthorByName;
    public static GetFlagHasBooksByUserByName getFlagHasBooksByUserByName;
    public static GetNewestBook getNewestBook;


    public static AuthorMainView authorMainView;
    public static AddAuthorView addAuthorView;
    public static AuthorsListView authorsListView;
    public static AuthorInfoView authorInfoView;
    public static AuthorDeleteView authorDeleteView;
    public static AuthorUpdateView authorUpdateView;
    public static JoinBookToAuthorView joinBookToAuthorView;


    static void Main(string[] args)
    {

        mainView = new MainView();
        
        userMainView = new UserMainView();
        addUserView = new AddUserView(userRepository);
        usersListView = new UsersListView(userRepository);
        userInfoView = new UserInfoView(userRepository);
        userDeleteView = new UserDeleteView(userRepository);
        userUpdateView = new UserUpdateView(userRepository);
        getBookUserView = new GetBookUserView(userRepository);
        getUserCountBooks = new GetUserCountBooks(userRepository);

        bookMainView = new BookMainView();
        addBookView = new AddBookView(bookRepository);
        booksListView = new BooksListView(bookRepository);
        booksListOrderByName = new BooksListOrderByName(bookRepository);
        booksListOrderByYear = new BooksListOrderByYear(bookRepository);
        bookInfoView = new BookInfoView(bookRepository);
        bookDeleteView = new BookDeleteView(bookRepository);
        bookUpdateView = new BookUpdateView(bookRepository);
        getBookListByGenreByYearView = new GetBookListByGenreByYear(bookRepository);
        getCountBooksByGenre = new GetCountBooksByGenre(bookRepository);
        getCountBooksByAuthor = new GetCountBooksByAuthor(bookRepository, authorRepository);
        getFlagHasBooksByAuthorByName = new GetFlagHasBooksByAuthorByName(bookRepository, authorRepository);
        getFlagHasBooksByUserByName = new GetFlagHasBooksByUserByName(bookRepository, userRepository);
        getNewestBook = new GetNewestBook(bookRepository);

        authorMainView = new AuthorMainView();
        addAuthorView = new AddAuthorView(authorRepository);
        authorsListView = new AuthorsListView(authorRepository);
        authorInfoView = new AuthorInfoView(authorRepository);
        authorDeleteView = new AuthorDeleteView(authorRepository);
        authorUpdateView = new AuthorUpdateView(authorRepository);
        joinBookToAuthorView = new JoinBookToAuthorView(authorRepository);


        while (true)
        {
            mainView.Show();
        }
    }

}