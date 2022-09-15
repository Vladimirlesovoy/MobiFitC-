using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class LegsSquatt: ContentPage
    {
        public LegsSquatt()
        {
            Label lbl = new Label();
            lbl.Text = "Squatt";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;
            Image img = new Image();
            img.Source = "LegsSquatt.jpg";
            Content = new StackLayout

            {
                Children = {lbl, img

                }
            };


            
        }
    }
}