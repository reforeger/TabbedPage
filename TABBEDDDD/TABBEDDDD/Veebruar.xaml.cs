﻿using System;
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
    public partial class Veebruar : ContentPage
    {
        Button btn1;
        public Veebruar()
        {
            InitializeComponent();

            btn1 = new Button();
            btn1.BackgroundColor = Color.Red;
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://xn--riigiphad-v9a.ee/et/iseseisvusp%C3%A4ev%2C+eesti+vabariigi+aastap%C3%A4ev");
            Browser.OpenAsync(uri);
        }
    }
}