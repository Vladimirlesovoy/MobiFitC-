using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class BreedLying : ContentPage
    {
        public BreedLying()
        {
            Label lbl = new Label();
            lbl.Text = "BreedLying";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "BreedLying.jpg";
            Content = new StackLayout
            {
                Children = {lbl,img

                }
            };
        }
    }
}