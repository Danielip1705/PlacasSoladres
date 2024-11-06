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