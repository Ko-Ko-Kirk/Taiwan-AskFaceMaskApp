﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Taiwan_AskFaceMaskApp.Pages
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            //TODO 尚未針對深色模式最佳化。
            BackgroundColor =(Color)Application.Current.Resources["TmpBackgroundColor"];
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            (App.Current as App).CurrentPageViewModel = BindingContext as ViewModels.BasePageViewModel;
            (App.Current as App).CurrentPageViewModel.IsOnInternet = JamestsaiTW.Utilities.ConnectivityHelper.Instance.IsOnInternet;
        }
    }
}