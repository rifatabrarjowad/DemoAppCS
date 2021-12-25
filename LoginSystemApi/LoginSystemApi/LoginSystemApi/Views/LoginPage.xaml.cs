using LoginSystemApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginSystemApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            //await label.RelRotateTo(360, 1000);
            string usrName = usr.Text;
            string usrPass = passs.Text;
            if (usrName != null || usrPass != null)
            {
                if (usrName == usrPass)
                {
                    await Shell.Current.GoToAsync("//AboutPage");
                }
                else
                {
                    label.Text = "faild";
                    await label.RelRotateTo(360, 1000);
                }
            }
            else
            {
                alt.Text = "pls give us your information ";
                alt.BackgroundColor = Color.Red;
                alt.IsVisible = true;
            }
           
        }
        async void OnButtonSingUp(object sender, EventArgs args)
        {
            sing.IsVisible = false;
            label.Text = "Sing In ";
            log.IsVisible = true;
            singbtn.IsVisible = true;
            logbtn.IsVisible = false;
        }
        async void OnButtonLogin(object sender, EventArgs args)
        {
            sing.IsVisible = false;
            label.Text = "Log IN ";
            log.IsVisible = true;
            singbtn.IsVisible = false;
            logbtn.IsVisible = true;
            
        }
    }
}