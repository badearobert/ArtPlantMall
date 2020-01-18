using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    public partial class CartPopupView : ContentView
    {
        public delegate void TapDelegate();
        public CartPopupView()
        {
            InitializeComponent();
        }
        public int PageHeader { get; private set; } = 80;

        public TapDelegate OnExpand { get; set; }
        public TapDelegate OnCollapse { get; set; }
        private void OnExpandTapped(object sender, EventArgs e)
        {
            GoToState("Expanded");
            OnExpand?.Invoke();
        }
        private void OnCollapseTapped(object sender, EventArgs e)
        {
            GoToState("Collapsed");
            OnCollapse?.Invoke();
        }
        private void GoToState(string visualState)
        {
            VisualStateManager.GoToState(SummaryBasket, visualState);
            VisualStateManager.GoToState(CollapseButton, visualState);
            VisualStateManager.GoToState(ExpandButton, visualState);

        }

    }
}