using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class PullUps : ContentPage
    {
        public PullUps()
        {
            Label lbl = new Label();
            lbl.Text = "PullUps";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "PullUps.jpg";
            Content = new StackLayout
            {
                Children = {lbl,img
                   
                }
            };
        }
    }
}