using CommunityToolkit.Mvvm.ComponentModel;

namespace KretaProject.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        public object _currentView = new object();
    }
}
