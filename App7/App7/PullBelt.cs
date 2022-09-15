using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class PullBelt : ContentPage
    {
        public PullBelt()
        {
            Label lbl = new Label();
            lbl.Text = "PullBelt";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "Pullbelt.jpg";
            Content = new StackLayout
            {
                Children = {lbl,img
                   
                }
            };
        }
    }
}