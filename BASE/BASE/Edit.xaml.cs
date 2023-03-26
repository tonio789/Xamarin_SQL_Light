using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BASE.Model;

namespace BASE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit : ContentPage
    {
        public Edit()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
            var allUsers = Repository.Instancia.GetAllDB();
            dbList.ItemsSource = allUsers;
        }

        private bool selectionIsValid()
        {
            if(dbList.SelectedItem != null)
            { 
                return true;
            }
            else { 
                DisplayAlert("Error", "Primero selecciona una opcion", "Ok"); 
                return false;
            }
        }

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            if (selectionIsValid())
            {
                var selectedItem = dbList.SelectedItem as db;
                ((NavigationPage)this.Parent).PushAsync(new EditAgenda(selectedItem.Id, selectedItem.Description, selectedItem.Importancia));
            }


        }
        private void BtnDelete_Clicked(object sender, EventArgs e)
        {
            

            if (selectionIsValid())
            {
                var selectedItem = dbList.SelectedItem as db;
                int id = selectedItem.Id;
                Repository.Instancia.DeleteDB(id);
            }
            update();


        }
    }
}