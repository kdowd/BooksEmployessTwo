using BooksEmployess.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BooksEmployess.Windows
{
    /// <summary>
    /// Interaction logic for ShowBook.xaml
    /// </summary>
    public partial class ShowBook : Window
    {
        public ShowBook(Dictionary<string, string> BookData)
        {
            init();

            title.Text = BookData["title"];
            description.Text = BookData["description"];
            author.Text = BookData["author"];
            pages.Text = BookData["pages"];
            year.Text = BookData["year"];


            Image myImage = new Image();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(BookData["imagepath"], UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad; // Ensures the image is fully loaded
            bitmap.EndInit();
            myImage.Source = bitmap;
            poster.Source = bitmap;
            //OR
            //MyStackPanel.Children.Add(myImage);
            //MyStackPanel.Children.Insert(1, myImage);



        }





        private void init()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;

        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
