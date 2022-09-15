using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class SideBreeding : ContentPage
    {
        public SideBreeding()
        {
            Label lbl = new Label();
            lbl.Text = "SideBreeding";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "SideBreeding.jpg";
            Content = new StackLayout
            {
                Children = {lbl,img
                   
                }
            };
        }
    }
}