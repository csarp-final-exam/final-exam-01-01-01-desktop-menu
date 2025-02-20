using CommunityToolkit.Mvvm.ComponentModel;

namespace KretaProject.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly StudentViewModel _studentViewModel= new StudentViewModel();
        private readonly SchoolClassViewModel _schoolClassViewModel = new SchoolClassViewModel();
        private readonly ControlPanelViewModel _controlPanelViewModel = new ControlPanelViewModel();

        [ObservableProperty]
        public object _currentView = new object();

        public MainWindowViewModel()
        {
            _currentView = _controlPanelViewModel;
        }
    }
}
