using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemperatureConverter : ContentPage
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, EventArgs e)
        {
            double count = Convert.ToDouble(entry.Text);
            if (first.SelectedIndex == 0)       // 0 - Celsius, 1 - Kelvin, 2 - Fahrenheit.
            {
                if (second.SelectedIndex == 1)
                    count += 273.15;
                else if (second.SelectedIndex == 2)
                    count = 1.8 * count  + 32;
            }
            else if (first.SelectedIndex == 1)
            {
                if (second.SelectedIndex == 0)
                    count -= 273.15;
                else if (second.SelectedIndex == 2)
                    count = 9 * (count - 273.15)/5 + 32; // from Kelvin to Fahrenheit
            }
            else
            {
                if (second.SelectedIndex == 0)
                    count = (count - 32) *5/9;
                else if (second.SelectedIndex == 1)
                    count = 5 * (count - 32) / 9 + 273.15;// from Fahrenheit to Kelvin
            }
            entry2.Text = count.ToString();
        }

        private void Button_Click_Reverse(object sender, EventArgs e)
        {
            int first1 = first.SelectedIndex;
            int second2 = second.SelectedIndex;

            first1 = first1 + second2;
            second2 = first1 - second2;
            first1 = first1 - second2;

            first.SelectedIndex = first1;
            second.SelectedIndex = second2;
        }
    }
}