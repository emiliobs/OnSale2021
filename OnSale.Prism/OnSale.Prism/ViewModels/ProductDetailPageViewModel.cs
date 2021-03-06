using Onsale.Common.Entities;
using Onsale.Prism.Helpers;
using OnSale.Common.Responses;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace OnSale.Prism.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase
    {
        private ProductResponse _product;
        private ObservableCollection<ProductImage> _images;


        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.Product;
        }



        public ObservableCollection<ProductImage> Images
        {
            get => _images;
            set => SetProperty(ref _images, value);
        }


        public ProductResponse Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            //hew recived the parameter of the page previos:
            if (parameters.ContainsKey("product"))
            {
                Product = parameters.GetValue<ProductResponse>("product");
                Title = Product.Name;
                Images = new ObservableCollection<ProductImage>(Product.ProductImages);

            }
            base.OnNavigatedTo(parameters);
        }
    }
}
