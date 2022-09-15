using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobiFit
{
    public partial class App : Application
    {
        public App ()
        {// стандартная инициализация модели представления
            InitializeComponent ();
            MainPage=new NavigationPage( new MainPage());
          
           
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
