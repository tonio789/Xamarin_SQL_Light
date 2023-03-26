using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BASE.Model;

namespace BASE
{
    public partial class App : Application
    {

         


        public App(string filename)
        {
            InitializeComponent();
            Repository.Inicializador(filename);
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        
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
