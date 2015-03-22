using System.CodeDom;
using System.Collections.ObjectModel;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.Controllers
{
    class MainController : NotifyBase
    {
        private ObservableCollection<Notification> _notifications;
        public ObservableCollection<Notification> Notifications
        {
            get { return _notifications; }
            set
            {
                _notifications = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Drug> _drugs;
        public ObservableCollection<Drug> Drugs
        {
            get { return _drugs; }
            set
            {
                _drugs = value;
                OnPropertyChanged();
            }
        }

        public MainController()
        {
            Notifications = new ObservableCollection<Notification>();
        }
    }
}
