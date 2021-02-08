namespace GetRequestPHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using GetRequestPHP.WebService;
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn1_click(object sender, EventArgs e)
        {
            try 
            {
                ClienteManager manager = new ClienteManager();
                var res = await manager.getUsuarios();

                if (res != null)
                {
                    listaUsuarios.ItemsSource = res;
                }
            }

            catch (Exception e1)
            {

            }
        }
    }
}
