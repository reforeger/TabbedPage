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
    public partial class August : ContentPage
    {
        Button btn1;
        public August()
        {
            InitializeComponent();

            btn1 = new Button();
            btn1.BackgroundColor = Color.Red;
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://et.wikipedia.org/wiki/Taasiseseisvumisp%C3%A4ev");
            Browser.OpenAsync(uri);
        }
    }
}