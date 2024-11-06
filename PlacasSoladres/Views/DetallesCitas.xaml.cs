using Citas;

namespace PlacasSoladres.Views;

public partial class DetallesCitas : ContentPage
{
	public DetallesCitas(Cita cita)
	{
		InitializeComponent();
		BindingContext = cita;
	}
		/// <summary>
		/// Funcion que vuelve a la pagina anterior
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="args"></param>
		private async void botonPresionado(object obj, EventArgs args)
		{
		await Navigation.PopAsync();
		}
		/// <summary>
		/// Funcion que cuando se presiona el boton muestra un mensaje de que se ha guardado el informe
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="args"></param>
		private async void GuardarInforme(object obj, EventArgs args)
		{
		DisplayAlert("Guardado con exito", "Se ha guardado el informe.", "Ok");
		}

    /// <summary>
    /// Funcion que dependiendo del check escribe en el label si es apto o no
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="args"></param>
    public void aptoONo(object obj, CheckedChangedEventArgs args){


        if (args.Value){

			labelApto.Text="Apto";

		} else {
			labelApto.Text = "No apto";	
			
		}

	}

}