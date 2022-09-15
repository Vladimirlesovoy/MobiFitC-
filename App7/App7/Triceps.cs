using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class Triceps : ContentPage
    {
        public Triceps()
        {
            Label lbl = new Label();
            lbl.Text = "Triceps";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;
            Image img = new Image();
            img.Source = "Triceps.jpg";
            Content = new StackLayout

            {
                Children = {lbl, img

                }
            };


            
        }
    }
}