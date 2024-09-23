using Avalonia.Controls;
using Tasks.ViewModels;

namespace Tasks.Views // Ensure this matches your project name
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
