using CommunityToolkit.Mvvm.ComponentModel;

namespace KretaProject.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        public object _currentView = new object();
    }
}
