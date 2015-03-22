using VgzMedicijnenApp.Controllers;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.ViewModels
{
    class MainViewModel : NotifyBase
    {
        private MainController _controller;
        public MainController Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Controller = new MainController();
        }
    }
}
