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
    public partial class Detsember : ContentPage
    {
        Button btn1;
        public Detsember()
        {
            InitializeComponent();

            btn1 = new Button();
            btn1.BackgroundColor = Color.Red;
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.tthk.ee");
            Browser.OpenAsync(uri);
        }
        void OnButtonClicked1(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.tthk.ee");
            Browser.OpenAsync(uri);
        }
        void OnButtonClicked2(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.tthk.ee");
            Browser.OpenAsync(uri);
        }
    }
}