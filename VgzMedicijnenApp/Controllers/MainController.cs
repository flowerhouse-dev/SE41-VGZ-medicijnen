using System;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Windows.Data;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.Controllers
{
    public class MainController : NotifyBase
    {
        private ObservableCollection<Notification> _notifications;
        public ObservableCollection<Notification> Notifications
        {
            get { return _notifications; }
            set
            {
                _notifications = value;
                NotificationsToday = value;
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

        private ObservableCollection<Feeling> _feelings;
        public ObservableCollection<Feeling> Feelings
        {
            get { return _feelings; }
            set
            {
                _feelings = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Notification> _notificationsToday;
        public ObservableCollection<Notification> NotificationsToday
        {
            set
            {
                _notificationsToday = value;
                OnPropertyChanged();
            }
            get
            {
                try
                {
                    foreach (Notification n in Notifications)
                    {
                        if (n.Time.Day == DateTime.Now.Day)
                        {
                            _notificationsToday.Add(n);
                        }
                    }
                }
                catch
                {
                    //
                }
                return _notificationsToday;
            }
        }

        public MainController()
        {
            Notifications = new ObservableCollection<Notification>();
            Drugs = new ObservableCollection<Drug>();
            Feelings = new ObservableCollection<Feeling>();
        }
    }
}
