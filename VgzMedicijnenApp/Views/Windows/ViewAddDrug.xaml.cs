using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.Utility;
using VgzMedicijnenApp.ViewModels;
using VgzMedicijnenApp.ViewModels.Windows;
using Xceed.Wpf.Toolkit;

namespace VgzMedicijnenApp.Views.Windows
{
    /// <summary>
    /// Interaction logic for ViewAddDrug.xaml
    /// </summary>
    public partial class ViewAddDrug : Window
    {
        private ViewModelAddDrug _viewModel;
        private MainViewModel _main;

        public ViewAddDrug(MainViewModel viewModel)
        {
            InitializeComponent();
            _main = viewModel;
            _viewModel = new ViewModelAddDrug();
            DataContext = _viewModel;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Drug drug = new Drug(_viewModel.Name, _viewModel.Dose, _viewModel.Instructions);
                _main.Controller.Drugs.Add(drug);
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
