using System.Windows;
using Variant3_trofimov.Models;
using Variant3_trofimov.ViewModels;

namespace Variant3_trofimov.Views
{
    public partial class MainView : Window
    {
        public MainView(User currentUser)
        {
            InitializeComponent();
            DataContext = new MainViewModel(currentUser);
        }
    }
}
