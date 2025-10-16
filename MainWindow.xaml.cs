using BooksEmployess.Database;
using BooksEmployess.ORM;
using MongoDB.Driver;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using BooksEmployess.Pages;
using BooksEmployess.Windows;
namespace BooksEmployess
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAppLoaded(object sender, RoutedEventArgs e)
        {

            new Connection();
            IMongoDatabase? db = Connection.database;

            if (db != null)
            {
                var collection = db.GetCollection<BookDTO>("books").AsQueryable();
                List<BookDTO> allBooks = collection.ToList<BookDTO>();

                Trace.WriteLine(allBooks.Count);

                MyDataGrid.ItemsSource = allBooks;
                MyDataGrid.Columns[0].Visibility = Visibility.Hidden;
            }



        }
        private void OnAboutClick(object sender, RoutedEventArgs e)

        {




        }

        private void openBooksDetailWindow(Dictionary<string, string> BookData)
        {
            Window win2 = new ShowBook(BookData);
            win2.Owner = Application.Current.MainWindow;
            win2.ShowDialog();
        }

        private void MyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DataGrid clickedElement = (DataGrid)sender;
            BookDTO selectedBook = (BookDTO)clickedElement.SelectedItem;



            if (clickedElement != null && selectedBook != null)

            {
                Dictionary<string, string> BookData = new Dictionary<string, string>();
                BookData.Add("title", $"Title:\n{selectedBook.Title}");
                BookData.Add("author", $"Author:\n{selectedBook.Author}");
                BookData.Add("description", $"Description:\n{selectedBook.Description}");
                BookData.Add("pages", $"Pages:\n{selectedBook.Pages}\n");
                BookData.Add("year", $"Year of Publication:\n{selectedBook.YearOfPublication}\n");
                BookData.Add("imagepath", selectedBook.ImageLink);




                string message = $"Title: {selectedBook.Title}\n" +

                                 $"Author: {selectedBook.Author}\n" +

                                 $"Description: {selectedBook.Description}\n" +

                                 $"Pages: {selectedBook.Pages}\n" +

                                 $"Year of Publication: {selectedBook.YearOfPublication}";

                openBooksDetailWindow(BookData);
                //MessageBox.Show(message, "Book Details");

            }

        }

    }


}



