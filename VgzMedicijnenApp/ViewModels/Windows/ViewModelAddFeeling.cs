using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.ViewModels.Windows
{
    class ViewModelAddFeeling : NotifyBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _body;
        public string Body
        {
            get { return _body; }
            set
            {
                _body = value;
                OnPropertyChanged();
            }
        }

        public Feeling.Feelings Feeling { get; set; }

        private bool _isNeutralSelected;
        public bool IsNeutralSelected
        {
            get { return _isNeutralSelected; }
            set
            {
                _isNeutralSelected = value;

                if (value)
                {
                    Feeling = Domain.Feeling.Feelings.Neutral;
                    IsHappySelected = false;
                    IsExcitedSelected = false;
                    IsSadSelected = false;
                    IsPainSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isHappySelected;
        public bool IsHappySelected
        {
            get { return _isHappySelected; }
            set
            {
                _isHappySelected = value;

                if (value)
                {
                    Feeling = Domain.Feeling.Feelings.Happy;
                    IsNeutralSelected = false;
                    IsExcitedSelected = false;
                    IsSadSelected = false;
                    IsPainSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isExcitedSelected;
        public bool IsExcitedSelected
        {
            get { return _isExcitedSelected; }
            set
            {
                _isExcitedSelected = value;

                if (value)
                {
                    Feeling = Domain.Feeling.Feelings.Excited;
                    IsHappySelected = false;
                    IsNeutralSelected = false;
                    IsSadSelected = false;
                    IsPainSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isSadSelected;
        public bool IsSadSelected
        {
            get { return _isSadSelected; }
            set
            {
                _isSadSelected = value;

                if (value)
                {
                    Feeling = Domain.Feeling.Feelings.Sad;
                    IsHappySelected = false;
                    IsExcitedSelected = false;
                    IsNeutralSelected = false;
                    IsPainSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        private bool _isPainSelected;
        public bool IsPainSelected
        {
            get { return _isPainSelected; }
            set
            {
                _isPainSelected = value;

                if (value)
                {
                    Feeling = Domain.Feeling.Feelings.Pain;
                    IsHappySelected = false;
                    IsExcitedSelected = false;
                    IsSadSelected = false;
                    IsNeutralSelected = false;
                }

                CheckOne();
                OnPropertyChanged();
            }
        }

        public ViewModelAddFeeling()
        {
            IsNeutralSelected = true;
        }

        private void CheckOne()
        {
            if (!IsNeutralSelected &&
                !IsHappySelected &&
                !IsExcitedSelected &&
                !IsSadSelected &&
                !IsPainSelected)
            {
                IsNeutralSelected = true;
            }
        }
    }
}
