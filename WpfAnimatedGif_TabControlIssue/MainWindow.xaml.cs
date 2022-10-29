using System;
using System.Windows;
using System.Windows.Media.Imaging;
namespace WpfAnimatedGif_TabControlIssue
{
    public partial class MainWindow : Window
    {
        public string Src { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Src = "pack://application:,,,/Resources/res.gif";

            // WTF?????
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
