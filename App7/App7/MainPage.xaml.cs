using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MobiFit
{
    partial class MainPage : ContentPage
    {
        public MainPage() //конструктор
        {         
            //Button1
            Button btn1 = new Button();
            btn1.Text = "Chest: BenchLying";
            btn1.TextColor = Color.Black;
            btn1.BackgroundColor = Color.Blue;
            btn1.FontSize = 25;
            //пописка на обработчик события нажатия на кнопку
            btn1.Clicked += Btn_Clicked; 

            //Button2
            Button btn2 = new Button();
            btn2.Text = "Chest: BenchLyingDownHead";
            btn2.TextColor = Color.Black;
            btn2.BackgroundColor = Color.Blue;
            btn2.FontSize = 25;
            btn2.Clicked += Btn2_Clicked;

            //Button3
            Button btn3 = new Button();
            btn3.Text = "Chest: BreedLying";
            btn3.TextColor = Color.Black;
            btn3.BackgroundColor = Color.Blue;
            btn3.FontSize = 25;
            btn3.Clicked += Btn3_Clicked;

            //Button4
            Button btn4 = new Button();
            btn4.Text = "Back: PullBelt";
            btn4.TextColor = Color.Black;
            btn4.BackgroundColor = Color.Gray;
            btn4.FontSize = 25;
            btn4.Clicked += Btn4_Clicked;

            //Button5
            Button btn5 = new Button();
            btn5.Text = "Back: PullChest";
            btn5.TextColor = Color.Black;
            btn5.BackgroundColor = Color.Gray;
            btn5.FontSize = 25;
            btn5.Clicked += Btn5_Clicked;

            //Button6
            Button btn6 = new Button();
            btn6.Text = "Back: PullUps";
            btn6.TextColor = Color.Black;
            btn6.BackgroundColor = Color.Gray;
            btn6.FontSize = 25;
            btn6.Clicked += Btn6_Clicked;

            //Button7
            Button btn7 = new Button();
            btn7.Text = "Soulders: SeatedBench";
            btn7.TextColor = Color.Black;
            btn7.BackgroundColor = Color.Green;
            btn7.FontSize = 25;
            btn7.Clicked += Btn7_Clicked;

            //Button8
            Button btn8 = new Button();
            btn8.Text = "Soulders: SideBreeding";
            btn8.TextColor = Color.Black;
            btn8.BackgroundColor = Color.Green;
            btn8.FontSize = 25;
            btn8.Clicked += Btn8_Clicked;

            //Button9
            Button btn9 = new Button();
            btn9.Text = "Hands: Biceps";
            btn9.TextColor = Color.Black;
            btn9.BackgroundColor = Color.Yellow;
            btn9.FontSize = 25;
            btn9.Clicked += Btn9_Clicked;

            //Button10
            Button btn10 = new Button();
            btn10.Text = "Hands: Triceps";
            btn10.TextColor = Color.Black;
            btn10.BackgroundColor = Color.Yellow;
            btn10.FontSize = 25;
            btn10.Clicked += Btn10_Clicked;

            //Button11
            Button btn11 = new Button();
            btn11.Text = "Legs: Squatt";
            btn11.TextColor = Color.Black;
            btn11.BackgroundColor = Color.Red;
            btn11.FontSize = 25;
            btn11.Clicked += Btn11_Clicked;

            //Button12
            Button btn12 = new Button();
            btn12.Text = "Legs: DeadLift";
            btn12.TextColor = Color.Black;
            btn12.BackgroundColor = Color.Red;
            btn12.FontSize = 25;
            btn12.Clicked += Btn12_Clicked;

            //Button13
            Button btn13 = new Button();
            btn13.Text = "Legs: CulfMuscule";
            btn13.TextColor = Color.Black;
            btn13.BackgroundColor = Color.Red;
            btn13.FontSize = 25;
            btn13.Clicked += Btn13_Clicked;

            //Button14
            Button btn14 = new Button();
            btn14.Text = "Press";
            btn14.TextColor = Color.Black;
            btn14.BackgroundColor = Color.Purple;
            btn14.FontSize = 25;
            btn14.Clicked += Btn14_Clicked;



            // новый StackLayout и в него помещаются элементы
            StackLayout stackLayout = new StackLayout()
            {
                Children = { btn1, btn2, btn3, btn4, btn5, btn6, 
                btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14 }
            };
            stackLayout.Spacing = 20;
            this.Content = stackLayout;

            //Прокрутка
            for (int i = 1; i < 2; i++)
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


        //обработчик события нажатия на кнопку (его реализация)
        private async void Btn14_Clicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new Press());
        }
        private async void Btn13_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LegsCulfMuscule());
        }
        private async void Btn12_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LegsDeadLift());
        }
        private async void Btn11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LegsSquatt());
        }
        private async void Btn10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Triceps());
        }
        private async void Btn9_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Biceps());
        }
        private async void Btn8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SideBreeding());
        }
        private async void Btn7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeatedBench());
        }
        private async void Btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PullUps());
        }
        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PullChest());
        }
        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PullBelt());
        }
        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BreedLying());
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BenchLyingDownHead());
        }

        private async void Btn_Clicked(object sender, EventArgs e) 
        {

            await Navigation.PushAsync(new BenchLying());
        }
 
    }
    
}
