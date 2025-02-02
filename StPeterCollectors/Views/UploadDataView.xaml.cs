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
using StPeterCollectors.ViewModels;

namespace StPeterCollectors.Views
{
    /// <summary>
    /// Interaction logic for UploadDataView.xaml
    /// </summary>
    public partial class UploadDataView : UserControl
    {
        public UploadDataView()
        {
            InitializeComponent();
            DataContext = new UploadDataViewModel();
        }
    }
}
