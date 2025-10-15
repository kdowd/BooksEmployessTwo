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


        private void MyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (MyDataGrid.SelectedItem is BookDTO selectedBook)

            {
                string message = $"Title: {selectedBook.Title}\n" +

                                 $"Author: {selectedBook.Author}\n" +

                                 $"Description: {selectedBook.Description}\n" +

                                 $"Pages: {selectedBook.Pages}\n" +

                                 $"Year of Publication: {selectedBook.YearOfPublication}";


                MessageBox.Show(message, "Book Details");

            }

        }

    }


}



