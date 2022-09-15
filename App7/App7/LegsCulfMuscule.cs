using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class LegsCulfMuscule: ContentPage
    {
        public LegsCulfMuscule()
        {
            Label lbl = new Label();
            lbl.Text = "CulfMuscule";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;
            Image img = new Image();
            img.Source = "CulfMuscle.jpg";
            Content = new StackLayout

            {
                Children = {lbl, img

                }
            };


            
        }
    }
}