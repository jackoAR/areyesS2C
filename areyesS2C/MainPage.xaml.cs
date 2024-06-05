namespace areyesS2C
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public partial class NewPage1 : ContentPage
        {
            public NewPage1()
            {
                InitializeComponent();
            }

            private void btnCalcular_Clicked(object sender, EventArgs e)
            {
                if (datos <= 0)
                {
                    string datos = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
                    DisplayAlert("Alerta", datos, "Aceptar");
                }
                else
                {
                    DisplayAlert("Error", "Esta fuera de rango", "aceptar");
                }

                string fecha = DPfecha.Date.ToString();

            }
        }
    }

}
