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
    public partial class SpeedConverter : ContentPage
    {
        public SpeedConverter()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, EventArgs e)
        {
            double count = Convert.ToDouble(entry.Text);
            if (first.SelectedIndex == 0)       // 0 - MilePH, 1 - KmPH, 2 - MPS.
            {
                if (second.SelectedIndex == 1)
                    count *= 1.609344;
                else if (second.SelectedIndex == 2)
                    count /= 2.23693629205;
            }
            else if (first.SelectedIndex == 1)
            {
                if (second.SelectedIndex == 0)
                    count /= 1.609344;
                else if (second.SelectedIndex == 2)
                    count = count *5/18;
            }
            else
            {
                if (second.SelectedIndex == 0)
                    count *= 2.23693629205;
                else if (second.SelectedIndex == 1)
                    count *= 3.6;
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