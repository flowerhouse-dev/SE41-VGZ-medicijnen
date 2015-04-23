using System;
using System.Windows;
using VgzMedicijnenApp.Domain;
using VgzMedicijnenApp.ViewModels;
using VgzMedicijnenApp.ViewModels.Windows;

namespace VgzMedicijnenApp.Views.Windows
{
    /// <summary>
    /// Interaction logic for ViewAddNotificationFull.xaml
    /// </summary>
    public partial class ViewAddFeeling : Window
    {
        private readonly MainViewModel _main;
        private readonly ViewModelAddFeeling _viewModel;

        public ViewAddFeeling(MainViewModel viewModel)
        {
            InitializeComponent();
            _main = viewModel;
            _viewModel = new ViewModelAddFeeling();
            DataContext = _viewModel;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Feeling feeling = new Feeling(_viewModel.Title, _viewModel.Feeling, _viewModel.Body);
                _main.Controller.Feelings.Add(feeling);
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
