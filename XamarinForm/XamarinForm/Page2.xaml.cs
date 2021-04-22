using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private int _counter;

        public Page2()
        {
            InitializeComponent();
            _counter = 1;
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            btn.Text = $"Clicked {_counter++} times";
        }
    }
}