using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace Citrus.Avalonia.Sandbox
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            this.WhenActivated(disposables => { });
        }

        private void MenuItem_OnClick(object? sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            
            window.Show();
        }
    }
}
