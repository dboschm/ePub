using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using ePub.Core.Models;
using ePub.Core.Services;
using ePub.Helpers;

using Microsoft.Toolkit.Uwp.UI.Controls;

namespace ePub.ViewModels
{
    public class BookDetailViewModel : Observable
    {
        private SampleOrder _selected;

        public SampleOrder Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public BookDetailViewModel()
        {
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetMasterDetailDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (viewState == MasterDetailsViewState.Both)
            {
                Selected = SampleItems.First();
            }
        }
    }
}
