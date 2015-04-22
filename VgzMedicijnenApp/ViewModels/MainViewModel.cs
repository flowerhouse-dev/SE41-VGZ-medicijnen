using VgzMedicijnenApp.Controllers;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.ViewModels
{
    public class MainViewModel : NotifyBase
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

        private bool _isOverviewSelected;
        public bool IsOverviewSelected
        {
            get { return _isOverviewSelected; }
            set
            {
                _isOverviewSelected = value;

                if (value)
                {
                    IsDrugsSelected = false;
                    IsNotificationsSelected = false;
                    IsFeelingSelected = false;
                    IsReportSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isDrugsSelected;
        public bool IsDrugsSelected
        {
            get { return _isDrugsSelected; }
            set
            {
                _isDrugsSelected = value;

                if (value)
                {
                    IsOverviewSelected = false;
                    IsNotificationsSelected = false;
                    IsFeelingSelected = false;
                    IsReportSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isNotificationsSelected;
        public bool IsNotificationsSelected
        {
            get { return _isNotificationsSelected; }
            set
            {
                _isNotificationsSelected = value;

                if (value)
                {
                    IsDrugsSelected = false;
                    IsOverviewSelected = false;
                    IsFeelingSelected = false;
                    IsReportSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isFeelingSelected;
        public bool IsFeelingSelected
        {
            get { return _isFeelingSelected; }
            set
            {
                _isFeelingSelected = value;

                if (value)
                {
                    IsDrugsSelected = false;
                    IsNotificationsSelected = false;
                    IsOverviewSelected = false;
                    IsReportSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isReportSelected;
        public bool IsReportSelected
        {
            get { return _isReportSelected; }
            set
            {
                _isReportSelected = value;

                if (value)
                {
                    IsDrugsSelected = false;
                    IsNotificationsSelected = false;
                    IsFeelingSelected = false;
                    IsOverviewSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Controller = new MainController();

            IsOverviewSelected = true;
            IsDrugsSelected = false;
            IsNotificationsSelected = false;
            IsFeelingSelected = false;
            IsReportSelected = false;
        }

        private void CheckOne()
        {
            if (!IsOverviewSelected &&
                !IsDrugsSelected &&
                !IsNotificationsSelected &&
                !IsFeelingSelected &&
                !IsReportSelected)
            {
                IsOverviewSelected = true;
            }
        }
    }
}
