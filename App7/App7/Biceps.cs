using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class Biceps : ContentPage
    {
        public Biceps()
        {
            Label lbl = new Label();
            lbl.Text = "Biceps";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;
            Image img = new Image();
            img.Source = "Biceps.jpg";
            Content = new StackLayout

            {
                Children = {lbl, img

                }
            };


            
        }
    }
}