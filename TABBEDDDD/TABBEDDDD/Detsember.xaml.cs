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
            Uri uri = new Uri("https://et.wikipedia.org/wiki/J%C3%B5ululaup%C3%A4ev");
            Browser.OpenAsync(uri);
        }
        void OnButtonClicked1(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://et.wikipedia.org/wiki/J%C3%B5ulud");
            Browser.OpenAsync(uri);
        }
        void OnButtonClicked2(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://et.wikipedia.org/wiki/J%C3%B5ulud");
            Browser.OpenAsync(uri);
        }
    }
}