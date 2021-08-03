using Onsale.Common.Entities;
using OnSale.Common.Responses;
using OnSale.Prism.Views;
using Prism.Commands;
using Prism.Navigation;

namespace OnSale.Prism.ItemViewModel
{
    public class ProductItemViewModel : ProductResponse
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectProductCommand;

        public ProductItemViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        public DelegateCommand SelectProductCommand => _selectProductCommand ??
                                                      (_selectProductCommand = new DelegateCommand(SelectProductAsync));

        private async void SelectProductAsync()
        {
            //pass parameter: of a page to anothe page:
            var parameters = new NavigationParameters
            {
                { "product", this }
            };
            await _navigationService.NavigateAsync(nameof(ProductDetailPage), parameters);
        }
    }
}
