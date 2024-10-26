using System.Diagnostics;
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
using TRPO_lab7.Models;
using TRPO_lab7.View;

namespace TRPO_lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArtistDbContext db = new ArtistDbContext();

        List<Artwork> allArtworks;
        List<Artist> allArtists;
        public MainWindow()
        {
            InitializeComponent();
            //this.Width = SystemParameters.PrimaryScreenWidth;
            //this.Height = SystemParameters.PrimaryScreenHeight;
            allArtists = db.Artists.ToList();
            allArtworks = db.Artworks.ToList();

            UpdateWorks();
        }
        private void UpdateWorks()
        {
            var listViewData = from Artwork in allArtworks
                               select new
                               {
                                   Name = Artwork.Title,
                                   Price = Artwork.Price,
                               };
            lvArts.ItemsSource = listViewData.ToList();
        }
        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is System.Windows.Controls.ListViewItem listViewItem)
            {
                Artwork currentArtwork = null;
                using (ArtistDbContext db = new ArtistDbContext())
                {
                    var selectedItem = listViewItem.Content as dynamic;
                    string name = selectedItem.Name;

                    currentArtwork = db.Artworks.FirstOrDefault(b => b.Title == name);

                    ArtworkDetailsWindow wDetails = new ArtworkDetailsWindow(currentArtwork);
                    wDetails.Show();
                    Close();
                }
            }
        }
        private void TelegramImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/Natalie_Pintel") { UseShellExecute = true });
        }

        private void VKImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://vk.com/natalie.natalie9") { UseShellExecute = true });
        }
        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}