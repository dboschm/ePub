using System;

using ePub.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ePub.Views
{
    public sealed partial class LibraryPage : Page
    {
        public LibraryViewModel ViewModel { get; } = new LibraryViewModel();

        public LibraryPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
