using System;
using System.Windows;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;

namespace WpfAnimatedGif_TabControlIssue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/Resources/res.gif");

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.CacheOption = BitmapCacheOption.Default;
            bitmapImage.UriSource = uri;
            bitmapImage.EndInit();

            ImageBehavior.SetAnimatedSource(imageControl, bitmapImage);

            // WTF?????
        }
    }
}
