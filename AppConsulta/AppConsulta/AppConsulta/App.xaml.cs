﻿using AppConsulta.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConsulta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedPageMain());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}