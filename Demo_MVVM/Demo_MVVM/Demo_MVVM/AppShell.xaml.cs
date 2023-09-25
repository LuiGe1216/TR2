using Demo_MVVM.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Demo_MVVM.Data;
using Demo_MVVM.Models;

namespace Demo_MVVM
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void LoginBackClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Login();
        }

    }
}
