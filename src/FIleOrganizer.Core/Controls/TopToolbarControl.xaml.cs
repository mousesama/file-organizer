using System.Windows.Controls;
using FIleOrganizer.Core.ViewModels;

namespace FileOrganizer.Core.Controls;

public partial class TopToolbarControl : UserControl
{
    public TopToolbarViewModel ViewModel => (TopToolbarViewModel)Resources["ViewModel"];
    public TopToolbarControl()
    {
        InitializeComponent();
    }
}