using System.Collections.Generic;
using System.Linq;
using KOALA.Interfaces;
using Xamarin.Forms;




namespace KOALA.Components
{
    public class DragAndDropSample3ReceivingView : Frame, IDragAndDropHoverableView, IDragAndDropReceivingView
    {


        public void OnHovered(List<IDragAndDropMovingView> views)
        {
            Opacity = views.Any() ? .3 : 1;
        }

        public void OnDropReceived(IDragAndDropMovingView view)
        {
            if (view is DragAndDropSample3MovingView sender)
            {
                BackgroundColor = sender.BackgroundColor;
           
                //new MainPage().UpdateUI();
                MessagingCenter.Send<App>((App)Application.Current, "CallMethod");
            }
        }
    }
}