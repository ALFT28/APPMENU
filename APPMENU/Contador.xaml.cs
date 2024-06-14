namespace APPMENU;

public partial class Contador : ContentPage
{
    private int Conteo = 10;


    public Contador()
	{
		InitializeComponent();
	}


    private async void btnStart_Clicked(object sender, EventArgs e)
    {
        // Deshabilita el botón mientras se está ejecutando la cuenta regresiva
        btnIniciar.IsEnabled = false;

        // Realiza el conteo regresivo de 10 a 1
        for (int i = Conteo; i > 0; i--)
        {
            lblCountdown.Text = i.ToString();
            await Task.Delay(1000); // Espera 1 segundo
        }

        // Restablece el valor del texto y habilita el botón nuevamente
        lblCountdown.Text = "¡Listo!";
        btnIniciar.IsEnabled = true;
    }







}