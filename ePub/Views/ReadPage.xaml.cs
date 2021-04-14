using System;

using ePub.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ePub.Views
{
    public sealed partial class ReadPage : Page
    {
        public ReadViewModel ViewModel { get; } = new ReadViewModel();

        public ReadPage()
        {
            InitializeComponent();
        }
    }
}
