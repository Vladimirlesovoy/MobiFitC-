using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public class BenchLying : ContentPage
    {
        public BenchLying()
        {
            Label lbl = new Label();
            lbl.Text = "BenchLying";
            lbl.FontSize = 25;
            lbl.TextColor = Color.Black;

            Image img = new Image();
            img.Source = "Benchlying.jpg";

            Image gif1 = new Image();
            gif1.Source = "GYM.gif";
            Content = new StackLayout();
            StackLayout stackLayout=new StackLayout()

            {//дочерние элементы от StackLayout
                Children = {lbl,img,gif1                 
                }
            };
            //scrolling
            stackLayout.Spacing= 20;
            this.Content = stackLayout;
            for(int i = 1; i < 2; i++)
            {
                Label label = new Label
                {
                };
                stackLayout.Children.Add(label);
            }
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            this.Content = scrollView;

        }
    }
}