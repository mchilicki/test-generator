using MatrixTransposition.UserInterface.Services;
using MatrixTransposition.UserInterface.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace MatrixTransposition.UserInterface
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry
                .Register<SettingsReaderWriter>();
        }
    }
}
