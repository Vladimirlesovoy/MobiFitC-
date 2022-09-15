using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class PullChest : ContentPage
    {
        public PullChest()
        {
            Label lbl = new Label();
            lbl.Text = "PullChest";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "PullChest.jpg";
            Content = new StackLayout
            {
                Children = {lbl,img
                   
                }
            };
        }
    }
}