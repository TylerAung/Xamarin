using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinForm
{
    /// <summary>
    /// Imperative way of using C# to 
    /// </summary>
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Label label = new Label
            {
                Text = "Hello From XAML.CS"
            };

            int counter = 1;
            Button btn = new Button
            {
                Text = "Click Me"
            };
            btn.Clicked += (sender, args) =>
            {
                btn.Text = $"Clicked {counter++} times";
            };

            //Stack Layout is type of layout
            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                //Properties of layout
                Children = {
                                    label,
                                    btn}
            };
            
        }
    }
}