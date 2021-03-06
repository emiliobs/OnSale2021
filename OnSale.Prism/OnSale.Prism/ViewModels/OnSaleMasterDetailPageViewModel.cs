using Newtonsoft.Json;
using Onsale.Common.Helpers;
using Onsale.Common.Models;
using Onsale.Common.Responses;
using Onsale.Prism.Helpers;
using OnSale.Prism.ItemViewModel;
using OnSale.Prism.Views;
using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace OnSale.Prism.ViewModels
{
    public class OnSaleMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private UserResponse _user;

        public OnSaleMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
            LoadUser();
        }


        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        public UserResponse User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private void LoadMenus()
        {
            List<Menu> menus = new List<Menu>
        {
            new Menu
            {
                Icon = "ic_card_giftcard",
                PageName = $"{nameof(ProductsPage)}",
                Title = Languages.Products
            },
            new Menu
            {
                Icon = "ic_shopping_cart",
                PageName = $"{nameof(ShowCarPage)}",
                Title = Languages.ShowShoppingCar
            },
            new Menu
            {
                Icon = "ic_history",
                PageName = $"{nameof(ShowHistoryPage)}",
                Title = Languages.ShowPurchaseHistory,
                IsLoginRequired = true
            },
            new Menu
            {
                Icon = "ic_person",
                PageName = $"{nameof(ModifyUserPage)}",
                Title = Languages.ModifyUser,
                IsLoginRequired = true
            },
            new Menu
            {
                Icon = "ic_exit_to_app",
                PageName = $"{nameof(LoginPage)}",
                Title = Settings.IsLogin ? Languages.Logout : Languages.Login,
            }
        };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title,
                    IsLoginRequired = m.IsLoginRequired
                }).ToList());
        }

        private void LoadUser()
        {
            if (Settings.IsLogin)
            {
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);
                User = tokenResponse.User;
            }
        }


    }
}
