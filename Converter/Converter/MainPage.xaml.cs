using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Converter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string classId = button.ClassId;

            
            switch (classId)
            {
                case "Long":
                    await Navigation.PushAsync(new LongConverter());
                    break;
                case "Speed":
                    await Navigation.PushAsync(new SpeedConverter());
                    break;
                case "Power":
                    await Navigation.PushAsync(new PowerConverter());
                    break;
                case "Temperature":
                    await Navigation.PushAsync(new TemperatureConverter());
                    break;
                case "Weight":
                    await Navigation.PushAsync(new WeightConverter());
                    break;                
                default:
                    break;
            }
        }
    }
}
