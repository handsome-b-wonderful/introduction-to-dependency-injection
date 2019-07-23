using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Pets.DataAccess;
using Pets.Presentation;

namespace Pets.Viewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Compose();
            Application.Current.MainWindow.Show();
        }

        private static void Compose()
        {
            var reader = new ServiceReader();
            var viewModel = new PetsViewModel(reader);
            Application.Current.MainWindow = new PetViewerWindow(viewModel);
        }
    }
}
