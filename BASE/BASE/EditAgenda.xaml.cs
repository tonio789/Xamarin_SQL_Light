using BASE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace BASE
{
    public partial class EditAgenda : ContentPage
    {
        public EditAgenda()
        {
            InitializeComponent();
        }


        private void displayAlert()
        {
            DisplayAlert("Estado", Repository.Instancia.EstadoMensaje, "OK");
        }
        private void clean()
        {
            entry_description.Text = "";
            Dropdown.SelectedIndex = -1;
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            string descripcion = entry_description.Text;
            int importancia = Dropdown.SelectedIndex;
            Repository.Instancia.AddNewDB(descripcion, importancia);
            clean();
        }
        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Edit());
        }
        private void BtnClean_Clicked(object sender, EventArgs e)
        {
            clean();
        }
    }
}
