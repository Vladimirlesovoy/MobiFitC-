using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobiFit
{
    public partial class Splashpage : ContentPage

       
    {//задаем переменную splashpage типа Image
        Image splashImage;

        //создаем конструктор
        public Splashpage() 
        {
           
            splashImage = new Image
            {
                Source = "SplashPage.jpg",
               
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, 
            AbsoluteLayoutFlags.PositionProportional);
                  
        }

        //метод для масштабирования картинки и создания mainpage
        protected override async void OnAppearing() 
        {
            base.OnAppearing();
            await splashImage.ScaleTo(5, 5000);
            await splashImage.ScaleTo(1.1, 5000, Easing.Linear);

            Application.Current.MainPage = new MainPage();

        }
    }
}

