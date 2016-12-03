using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPStrangeBindingBehavior.Views
{
    public sealed partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        private async void TestButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var tag = button.Tag;
            await new MessageDialog(tag?.ToString() ?? "null").ShowAsync();
        }
    }
}