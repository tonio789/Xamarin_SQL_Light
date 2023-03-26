using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BASE.Model;
using System.Collections;

namespace BASE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit : ContentPage
    {
        public Edit()
        {
            InitializeComponent();
            upload();
        }

        private void upload()
        {
            var allUsers = Repository.Instancia.GetAllDB();
            userList.ItemsSource = allUsers;
        }

        private void selecitonIsNull()
        {
            if(db = )
        }

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {


        }
        private void BtnDelete_Clicked(object sender, EventArgs e)
        {
        }
    }
}