using System;
using System.Windows;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.ViewModels;

namespace VgzMedicijnenApp.Views.Windows
{
    /// <summary>
    /// Interaction logic for ViewAddNotificationFull.xaml
    /// </summary>
    public partial class ViewAddNotificationFull : Window
    {
        private readonly MainViewModel _viewModel;

        public ViewAddNotificationFull(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Notification notification = new Notification((DateTime)DateTimePicker.Value, (Drug) ComboBoxDrugs.SelectedItem);
                _viewModel.Controller.Notifications.Add(notification);
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
