using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VgzMedicijnenApp.Utility;

namespace VgzMedicijnenApp.ViewModels.Windows
{
    class ViewModelAddDrug : NotifyBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _dose;
        public string Dose
        {
            get { return _dose; }
            set
            {
                _dose = value;
                OnPropertyChanged();
            }
        }

        private string _instructions;
        public string Instructions
        {
            get { return _instructions; }
            set
            {
                _instructions = value;
                OnPropertyChanged();
            }
        }
    }
}
