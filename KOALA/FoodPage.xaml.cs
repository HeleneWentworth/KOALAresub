using System;
using System.Collections.Generic;
using Xamarin.Forms;

//Food page code behind
namespace KOALA
{
    public partial class FoodPage : ContentPage
    {
        public FoodPage()
        {
            InitializeComponent();
        }
        async void HomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
