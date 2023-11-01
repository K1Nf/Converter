using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;



using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace Converter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LongConverter : ContentPage
    {
        public LongConverter()
        {
            InitializeComponent();
        }
        
        public void Button_Click(object sender, EventArgs e) 
        {
            double count = Convert.ToDouble(entry.Text);
            if (first.SelectedIndex == 0)       // 0 - sm, 1 - m, 2 - km.
            {
                if (second.SelectedIndex == 1)
                    count /= 100;
                else if (second.SelectedIndex == 2)
                    count /= 100000;
            }
            else if (first.SelectedIndex == 1)
            {
                if (second.SelectedIndex == 0)
                    count *= 100;
                else if (second.SelectedIndex == 2)
                    count /= 1000;
            }
            else
            {
                if (second.SelectedIndex == 0)
                    count *= 100000;
                else if (second.SelectedIndex == 1)
                    count *= 1000;
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
