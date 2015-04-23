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

            _viewModel.Controller.Feelings.Add(new Feeling("Wat een dag!", Feeling.Feelings.Excited, "Vandaag heb ik helemaal geen last gehad van pijn! \n Ik denk dat de medicijnen helpen. Ik heb ook.."));
            _viewModel.Controller.Feelings.Add(new Feeling("Het gaat beter", Feeling.Feelings.Happy, "Al wat minder last gehad van de pijn, hopelijk gaat het morgen beter."));
            _viewModel.Controller.Feelings.Add(new Feeling("Minder pijn", Feeling.Feelings.Neutral, "De pijn van een paar uur geleden is al aan het minderen."));
            _viewModel.Controller.Feelings.Add(new Feeling("Auw!", Feeling.Feelings.Pain, "Wat een pijn! ik had gisteren mijn medicijnen gewoon moeten innemen."));

            _viewModel.Controller.Notifications.Add(
                new Notification(
                    new DateTime(2015, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0), 
                    //2015, 3, 22, 10, 0, 0
                    new Drug("Medicijn A", "1 Tablet", "Oraal innemen")));
            _viewModel.Controller.Notifications.Add(
                new Notification(
                    new DateTime(2015, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0),
                    new Drug("Medicijn B", "1 Tablet", "Oraal innemen")));
            _viewModel.Controller.Notifications.Add(
                new Notification(
                    new DateTime(2015, DateTime.Now.Month, DateTime.Now.Day, 19, 0, 0),
                    new Drug("Medicijn C", "1 Tablet", "Oraal innemen")));

            DataContext = _viewModel;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewAddNotificationFull viewAddNotification = new ViewAddNotificationFull(_viewModel);
            Action showViewAddNotification = () => viewAddNotification.Show();
            Dispatcher.BeginInvoke(showViewAddNotification);
        }

        private void AddDrug_Click(object sender, RoutedEventArgs e)
        {
            ViewAddDrug viewAddDrug = new ViewAddDrug(_viewModel);
            Action showViewAddDrug = () => viewAddDrug.Show();
            Dispatcher.BeginInvoke(showViewAddDrug);
        }

        private void AddFeeling_Click(object sender, RoutedEventArgs e)
        {
            ViewAddFeeling viewAddFeeling = new ViewAddFeeling(_viewModel);
            Action showViewAddFeeling = () => viewAddFeeling.Show();
            Dispatcher.BeginInvoke(showViewAddFeeling);
        }
    }
}
