/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using Xamarin.Forms;
using Sample.IViewModels;
using System.Windows.Input;

namespace Sample.ViewModels
{
    public class HideableToolbarItemViewModel : BaseViewModel, IHideableToolbarItemViewModel
    {
        private Boolean _isVisible;
        private String _btnContent;

        public Boolean IsVisible
        {
            get { return _isVisible; }
            set {
                _isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }
        public String BtnContent
        {
            get { return _btnContent; }
            set {
                _btnContent = value;
                OnPropertyChanged(nameof(BtnContent));
            }
        }

        public ICommand UpdateVisibilityCommand { get; set; }

        public HideableToolbarItemViewModel()
        {
            UpdateVisibilityCommand = new Command(UpdateVisibility);

            IsVisible = false;
            BtnContent = "Show";
        }

        private void UpdateVisibility()
        {
            IsVisible = !IsVisible;
            BtnContent = IsVisible ? "Hide" : "Show";
        }
    }
}
