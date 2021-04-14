using System;
using System.Linq;
using System.Threading.Tasks;

using ePub.Core.Models;
using ePub.Core.Services;
using ePub.Helpers;

namespace ePub.ViewModels
{
    public class LibraryDetailViewModel : Observable
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public LibraryDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
