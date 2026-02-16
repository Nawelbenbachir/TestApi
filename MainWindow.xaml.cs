using TestApi.ViewModels;
using System.Windows;
using TestApi.Services;
namespace TestApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = new DocumentViewModel();
        }
    }
}