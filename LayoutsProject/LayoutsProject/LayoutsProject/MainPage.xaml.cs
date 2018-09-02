using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToStackLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutFolder.StackLayoutPage());
        }
        private void ToAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutFolder.AbsoluteLayoutPage());
        }
        private void ToRelativeLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutFolder.RelativeLayoutPage());
        }
        private void ToGridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridFolder.GridLayoutPage());
        }
    }
}
