/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;

namespace Xamarin.Forms.ToolKit.Controls
{
    public class HideableToolbarItem : ToolbarItem
    {
        #region BindableObject
        public static readonly BindableProperty IsVisibleProperty = BindableProperty.Create(nameof(IsVisible), typeof(bool), typeof(HideableToolbarItem), default(bool), BindingMode.TwoWay, propertyChanged: OnIsVisibleChanged);
        public bool IsVisible
        {
            get { return (bool)GetValue(IsVisibleProperty); }
            set { SetValue(IsVisibleProperty, value); }
        }
        #endregion

        #region Init
        protected override void OnParentSet()
        {
            base.OnParentSet();
            InitVisibility();
        }
        private void InitVisibility()
        {
            OnIsVisibleChanged(this, false, IsVisible);
        }
        #endregion

        #region OnPropertyChanged
        private static void OnIsVisibleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var item = bindable as HideableToolbarItem;

            var newValueBool = (bool)newValue;
            var oldValueBool = (bool)oldValue;

            if (item.Parent == null)
                return;

            var parent = (item.Parent) as Page;

            if (parent == null)
                return;

            var items = parent.ToolbarItems;

            if (newValueBool && !items.Contains(item))
            {
                items.Add(item);
            }
            else if (!newValueBool && items.Contains(item))
            {
                items.Remove(item);
            }
        }
        #endregion
    }
}
