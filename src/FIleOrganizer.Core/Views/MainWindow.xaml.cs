using System.Windows;
using FIleOrganizer.Core.ViewModels;

namespace FileOrganizer.Core.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowVM ViewModel => (MainWindowVM)Resources["ViewModel"];
        
        public MainWindow()
        {
            InitializeComponent();
            ViewModel.Initialize();
            Loaded += delegate { ViewModel.CallOnLoaded(); };
            Unloaded += delegate { ViewModel.CallOnUnloaded(); };
        }
    }
}