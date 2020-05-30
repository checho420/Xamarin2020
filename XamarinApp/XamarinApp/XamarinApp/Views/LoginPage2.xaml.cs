using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage2 : ContentPage
    {
        public LoginPage2()
        {
            InitializeComponent();
        }

        async private void btn_login_Clicked(object sender, EventArgs e)
        {

#if DEBUG

            txt_email.Text = "checho420";
            txt_pass.Text = "admin";

#endif

            string email = txt_email.Text;
            string pass = txt_pass.Text;

            if(email =="checho420" && pass == "admin")            {

                //Autentificacion correcta
                App.Current.MainPage = new NavigationPage(new HomePage());
   
                //this.DisplayAlert("Exito", "usuario o pass correcto", "Aceptar");
            }
            else
            {
                await this.DisplayAlert("Error", "usuario o pass icorrectos", "Aceptar");
            }
           

        }
    }
}