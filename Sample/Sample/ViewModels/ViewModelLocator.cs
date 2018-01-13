/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Sample.IViewModels;
using Xamarin.Forms.Navigation;

namespace Sample.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IHomeViewModel, HomeViewModel>();
            DependencyService.Register<IHideableToolbarItemViewModel, HideableToolbarItemViewModel>();

            DependencyService.Register<INavigationService, NavigationService>();
        }

        public IHomeViewModel Home
        {
            get
            {
                return DependencyService.Get<IHomeViewModel>();
            }
        }

        public IHideableToolbarItemViewModel HideableToolbarItem
        {
            get
            {
                return DependencyService.Get<IHideableToolbarItemViewModel>();
            }
        }
    }
}
