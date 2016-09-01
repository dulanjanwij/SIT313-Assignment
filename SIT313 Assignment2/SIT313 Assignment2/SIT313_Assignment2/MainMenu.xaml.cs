﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void Login_btn_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new Login());
        }

        public void Meals_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new meals());
        }
    }
}
