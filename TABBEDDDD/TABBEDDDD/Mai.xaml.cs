using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TABBEDDDD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mai : ContentPage
    {
        Button btn1;
        public Mai()
        {
            InitializeComponent();

            btn1 = new Button();
            btn1.BackgroundColor = Color.Red;
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://xn--riigiphad-v9a.ee/et/kevadp%C3%BCha");
            Browser.OpenAsync(uri);
        }
        void OnButtonClicked1(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://xn--riigiphad-v9a.ee/et/nelip%C3%BChade+1.+p%C3%BCha");
            Browser.OpenAsync(uri);
        }
    }
}