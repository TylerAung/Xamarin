using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();
            //MainPage = new Page1
            MainPage = new Page2();


            //MainPage is Root Page for Application
            //ContentPage is one of the Layouts for defining UI on the device

            //Advised to create control seperately

            //Codes from here got extracted to Page1.cs
            //Label label = new Label
            //{
            //    Text = "Hello From XAML.CS"
            //};

            //int counter = 1;
            //Button btn = new Button
            //{
            //    Text = "Click Me"
            //};
            //btn.Clicked += (sender, args) =>
            //{
            //    btn.Text = $"Clicked {counter++} times";
            //};

            //MainPage = new ContentPage //But not this line of code
            //{
            //    //Stack Layout is type of layout
            //    Content = new StackLayout { 
            //        Orientation = StackOrientation.Vertical,
            //        HorizontalOptions = LayoutOptions.Center,
            //        VerticalOptions = LayoutOptions.Center,
            //            //Properties of layout
            //            Children = {
            //                        label,
            //                        btn
            //                        // new Label
            //                        //{
            //                        //    Text = "I am Written from XAML.CS"
            //                        //},
            //                        // new Button
            //                        // {
            //                        //     Text= "Click me",
            //                        //     FontSize = 20
            //                        // }
            //                    }
            //            }
            //};
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
