using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace StPeterCollectors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("Test");
        }
    }
}