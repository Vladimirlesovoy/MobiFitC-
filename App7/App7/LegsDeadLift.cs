using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class LegsDeadLift : ContentPage
    {
        public LegsDeadLift()
        {
            Label lbl = new Label();
            lbl.Text = "DeadLift";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;
            Image img = new Image();
            img.Source = "LegsDeadLift.jpg";
            Content = new StackLayout

            {
                Children = {lbl, img

                }
            };


            
        }
    }
}