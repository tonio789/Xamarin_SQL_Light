using BASE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BASE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditAgenda : ContentPage
    {
        int id;
        public EditAgenda(int id,string descripcion,int importancia)
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
            Repository.Instancia.UpdateDB(id, descripcion, importancia);
            ((NavigationPage)this.Parent).PushAsync(new Edit());
        }


    }
}