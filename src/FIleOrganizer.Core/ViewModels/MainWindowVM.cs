namespace FIleOrganizer.Core.ViewModels;

public class MainWindowVM : ViewModel
{
    private string _title = "File Organizer";
    
    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }
}