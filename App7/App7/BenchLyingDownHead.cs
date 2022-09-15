using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class BenchLyingDownHead : ContentPage
    {
        public BenchLyingDownHead()
        {
            Label lbl = new Label();
            lbl.Text = "BenchLyingDownHead";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "BenchLyingDownHead.jpg";
            Content = new StackLayout
            {
                Children = {lbl, img
                    
                }
            };
        }
    }
}