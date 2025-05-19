using System.Windows;
using Variant3_trofimov.Models;
using Variant3_trofimov.ViewModels;

namespace Variant3_trofimov.Views
{
    public partial class RequestEditView : Window
    {
        public RequestEditViewModel ViewModel { get; }

        public RequestEditView(Request? request = null)
        {
            InitializeComponent();
            ViewModel = new RequestEditViewModel(request);
            DataContext = ViewModel;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.Save())
            {
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка при сохранении. Проверьте данные.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
