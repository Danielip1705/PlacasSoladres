namespace PlacasSoladres.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Funcion que comprueba si los contenidos estan llenos, si lo estan avanza a la siguiente pagina
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="args"></param>
    private async void botonPresionado(object obj, EventArgs args)
    {

        string correo = EntryUsu.Text;
        string contraseya = EntryCon.Text;

        //Si los campos estan vacios
        if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseya))
        {
            //Mostramos una ventana emergente comentado que tiene que rellenar los cambios
            DisplayAlert("Los campos no pueden estar vacios","Rellena los cambios","Entendido");

        } 
        //Si estan rellenados
        else
        {   
            //Nos vamos a la vista Citas
            await Navigation.PushAsync(new Citas());
        }
    }
}