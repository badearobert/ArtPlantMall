using ArtPlantMall.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    public partial class ArtPlantMallView : ContentPage
    {
        const uint ExpandAnimationDuration = 500;
        const uint CollapseAnimationDuration = 300;
        double _pageHeight;
        public ArtPlantMallView()
        {
            InitializeComponent();
            BindingContext = new PlantMallViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CartPopup.OnExpand += OnExpand;
            CartPopup.OnCollapse += OnCollapse;
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            _pageHeight = height;
            CartPopup.TranslationY = _pageHeight - CartPopup.PageHeader;
            base.OnSizeAllocated(width, height);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CartPopup.OnExpand -= OnExpand;
            CartPopup.OnCollapse -= OnCollapse;

        }
        private void OnExpand()
        {
            var height = _pageHeight - CartPopup.PageHeader;
            CartPopup.TranslateTo(0, Height - height, ExpandAnimationDuration);
        }
        private void OnCollapse()
        {
            CartPopup.TranslateTo(0, _pageHeight - CartPopup.PageHeader, CollapseAnimationDuration);
        }
    }
}