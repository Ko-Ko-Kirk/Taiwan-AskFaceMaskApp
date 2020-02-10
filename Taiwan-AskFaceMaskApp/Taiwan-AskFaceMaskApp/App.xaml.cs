﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;

namespace Taiwan_AskFaceMaskApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

		public ViewModels.BasePageViewModel CurrentPageViewModel { get;  set; }

        protected override void OnStart()
        {
			AppCenter.LogLevel = LogLevel.Verbose;
			AppCenter.Start("ios={Your AppCenter Secret for iOS};android={Your AppCenter Secret for Android}",typeof(Analytics), typeof(Crashes));
		}

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
