using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace KOALA
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
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
            await Navigation.PushModalAsync(new TodoPage());
        }

    }
}
