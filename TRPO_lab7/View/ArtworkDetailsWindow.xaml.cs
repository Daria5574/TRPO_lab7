using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
using TRPO_lab7.Models;

namespace TRPO_lab7.View
{
    /// <summary>
    /// Логика взаимодействия для ArtworkDetailsWindow.xaml
    /// </summary>
    public partial class ArtworkDetailsWindow : Window
    {
        Artwork a;
        public ArtworkDetailsWindow(Artwork currentArtwork)
        {
            a = currentArtwork;
            InitializeComponent();
            titleLabel.Content = a.Title;
            descriptionLabel.Content = a.Description;
            priceLabel.Content = a.Price + " $";
            if (a.ArtworkUrl != null)
            {
                string localPath = @"D:\4 курс\диплом\" + a.ArtworkUrl;
                BitmapImage bitmap = new BitmapImage(new Uri(localPath));
                paintLabel.Source = bitmap;
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
