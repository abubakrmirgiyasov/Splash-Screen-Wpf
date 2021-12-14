using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SplashScreen
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OnLoading();
        }

        private async void OnLoading()
        {
            await Task.Run(() =>
            {
            for (int i = 0; i <= 100; i++)
            {
                    this.progressBar.Dispatcher.Invoke(new Action(() =>
                    {
                        progressBar.Value = i;
                        textBlock.Text = $"{i} %";
                    }));
                    Thread.Sleep(20);
                }
            });
            AnotherWindow anotherWindow = new AnotherWindow();
            anotherWindow.Show();
            Close();
        }
    }
}
