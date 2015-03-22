using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.ViewModels;

namespace VgzMedicijnenApp.Views.Windows
{
    /// <summary>
    /// Interaction logic for ViewAddNotification.xaml
    /// </summary>
    public partial class ViewAddNotification : Window
    {
        private readonly MainViewModel _viewModel;

        public ViewAddNotification(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Notification notification = new Notification((DateTime)DateTimePicker.Value, (Drug) ComboBoxDrugs.SelectedItem);
                _viewModel.Controller.Notifications.Add(notification);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
