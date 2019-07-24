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
            ComposeSqlServer();
            Application.Current.MainWindow.Show();
        }

        private static void ComposeSqlServer()
        {
            var reader = new SqlServerReader(ConfigurationManager.AppSettings["sqlServerConnectionString"]);
            var viewModel = new PetsViewModel(reader);
            Application.Current.MainWindow = new PetViewerWindow(viewModel);
        }

        private static void ComposeCsv()
        {
            var reader = new CsvReader();
            var viewModel = new PetsViewModel(reader);
            Application.Current.MainWindow = new PetViewerWindow(viewModel);
        }

        private static void ComposeService()
        {
            var reader = new ServiceReader();
            var viewModel = new PetsViewModel(reader);
            Application.Current.MainWindow = new PetViewerWindow(viewModel);
        }
    }
}
