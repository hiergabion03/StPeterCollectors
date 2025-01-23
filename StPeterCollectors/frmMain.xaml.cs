using System.Windows;

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
            if (rbtnMale.IsChecked == true)
            {
                MessageBox.Show($"Hello {rbtnMale.Content}");
            }
            else { 
                MessageBox.Show( $" Hello {rbtnFemale.Content}" );
            }
        }
        
    }
}