using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KOALA.Views;
using Xamarin.Forms;

//Main page code behind
namespace KOALA
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void PlayButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlayPage());
        }

        async void FoodButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FoodPage());
        }

        async void TodoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TodoItemPage());
        }

    }
}
