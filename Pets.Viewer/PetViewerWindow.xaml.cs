using Pets.Presentation;
using System.Windows;

namespace Pets.Viewer
{

    public partial class PetViewerWindow : Window
    {
        PetsViewModel viewModel;

        public PetViewerWindow()
        {
            InitializeComponent();
            viewModel = new PetsViewModel();
            this.DataContext = viewModel;
        }

        private void ShowRepositoryType()
        {
            RepositoryTypeTextBlock.Text = viewModel.DebugDataReader;
        }

        private void ClearRepositoryType()
        {
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RefreshPets();
            ShowRepositoryType();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearPets();
            ClearRepositoryType();
        }
    }
}
