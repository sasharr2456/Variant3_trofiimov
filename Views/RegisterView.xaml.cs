using System;
using System.Windows;
using Variant3_trofimov.ViewModels;

namespace Variant3_trofimov.Views
{
    public partial class RegisterView : Window
    {
        private readonly RegisterViewModel _viewModel;

        public RegisterView()
        {
            InitializeComponent();
            _viewModel = new RegisterViewModel();
            DataContext = _viewModel;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var password = PasswordBox.Password;

            if (_viewModel.TryRegister(password))
            {
                MessageBox.Show("Пользователь успешно зарегистрирован.", "Готово", MessageBoxButton.OK, MessageBoxImage.Information);
                Close(); // вернуться к LoginView
            }
            else
            {
                MessageBox.Show("Логин уже существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
