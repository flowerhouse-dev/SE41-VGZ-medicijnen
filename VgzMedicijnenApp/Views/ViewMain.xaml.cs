using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.ViewModels;
using VgzMedicijnenApp.Views.Windows;

namespace VgzMedicijnenApp.Views
{
    /// <summary>
    /// Interaction logic for ViewMain.xaml
    /// </summary>
    public partial class ViewMain : Window
    {
        private MainViewModel _viewModel;

        public ViewMain()
        {
            InitializeComponent();

            _viewModel = new MainViewModel();

            _viewModel.Controller.Drugs.Add(new Drug("Medicijn A", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn B", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn C", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn D", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn E", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn F", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn G", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn H", "1 Tablet", "Oraal innemen"));
            _viewModel.Controller.Drugs.Add(new Drug("Medicijn I", "1 Tablet", "Oraal innemen"));

            _viewModel.Controller.Notifications.Add(
                new Notification(
                    new DateTime(2015, 3, 22, 10, 0, 0), 
                    new Drug("Medicijn A", "1 Tablet", "Oraal innemen")));
            _viewModel.Controller.Notifications.Add(
                new Notification(
                    new DateTime(2015, 3, 22, 16, 0, 0),
                    new Drug("Medicijn B", "1 Tablet", "Oraal innemen")));
            _viewModel.Controller.Notifications.Add(
                new Notification(
                    new DateTime(2015, 3, 22, 19, 0, 0),
                    new Drug("Medicijn C", "1 Tablet", "Oraal innemen")));

            DataContext = _viewModel;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewAddNotificationFull viewAddNotification = new ViewAddNotificationFull(_viewModel);
            Action showViewAddNotification = () => viewAddNotification.Show();
            this.Dispatcher.BeginInvoke(showViewAddNotification);
        }
    }
}
