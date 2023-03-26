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
        int id;
        public EditAgenda(int id, string descripcion, int importancia)
        {
            InitializeComponent();
            this.id = id;
            entry_description.Text = descripcion;
            Dropdown.SelectedIndex = importancia;
        }


        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            string descripcion = entry_description.Text;
            int importancia = Dropdown.SelectedIndex;

            Repository.Instancia.UpdateDB(this.id, descripcion, importancia);
            ((NavigationPage)this.Parent).PushAsync(new Edit());

        }
    }
}
