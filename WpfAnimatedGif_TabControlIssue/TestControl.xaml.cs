using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace WpfAnimatedGif_TabControlIssue
{
    /// <summary>
    /// Interaction logic for TestControl.xaml
    /// </summary>
    public partial class TestControl : UserControl
    {
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
                nameof(Source),
                typeof(Uri),
                typeof(TestControl),
                new FrameworkPropertyMetadata(default(Uri), FrameworkPropertyMetadataOptions.None, SourceChanged));

        public Uri Source
        {
            get => (Uri)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        private static void SourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
            => ((TestControl)d).SourceChanged(e);

        private void SourceChanged(DependencyPropertyChangedEventArgs e)
        {
            var uri = e.NewValue as Uri;

            if (uri != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.Default;
                bitmapImage.UriSource = uri;
                bitmapImage.EndInit();
                ImageBehavior.SetAnimatedSource(imageControl, bitmapImage);
            }
        }

        public TestControl()
        {
            InitializeComponent();
        }
    }
}
