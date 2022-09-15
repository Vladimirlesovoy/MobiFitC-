using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class SeatedBench : ContentPage
    {
        public SeatedBench()
        {
            Label lbl = new Label();
            lbl.Text = "SeatedBench";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "SeatedBench.jpg";
            Content = new StackLayout
            {
                Children = {lbl,img
                   
                }
            };
        }
    }
}