using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Extensions;
using System.Diagnostics;

namespace ReproducingLeavingPageBehavior
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            Debugger.Break(); //Calling ShowPopupAsync should not cause us to leave the page, but it does, and OnDisappearing fires when it should not.

        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            await this.ShowPopupAsync(new SimplePopup());
        }
    }
}
