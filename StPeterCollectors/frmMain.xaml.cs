using StPeterCollectors.ViewModels;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;


namespace StPeterCollectors
{

    public partial class MainWindow : Window
    {
        public UploadDataViewModel ViewModel { get; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new UploadDataViewModel();
            DataContext = ViewModel; // ✅ Set DataContext
        }

    }
}