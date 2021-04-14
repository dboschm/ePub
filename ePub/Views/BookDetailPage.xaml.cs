using System;

using ePub.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ePub.Views
{
    public sealed partial class BookDetailPage : Page
    {
        public BookDetailViewModel ViewModel { get; } = new BookDetailViewModel();

        public BookDetailPage()
        {
            InitializeComponent();
            Loaded += BookDetailPage_Loaded;
        }

        private async void BookDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
