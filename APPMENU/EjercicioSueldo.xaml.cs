namespace APPMENU;

public partial class EjercicioSueldo : ContentPage
{
	public EjercicioSueldo()
	{
		InitializeComponent();

        // Campos de entrada y etiquetas para dar el resultado
        var horasEntry = new Entry { Placeholder = "Horas trabajadas", Keyboard = Keyboard.Numeric };
        var tarifaEntry = new Entry { Placeholder = "Pago por hora", Keyboard = Keyboard.Numeric };
        var resultadoLabel = new Label();

        // Bot�n que calcula y muestra el resultado del pago
        var calcularButton = new Button
        {
            Text = "Calcular",
            // Bot�n que maneja el evento Clicked
            Command = new Command(() =>
            {
                // Maneja el c�lculo del sueldo semanal cuando se hace clic en el bot�n
                if (double.TryParse(horasEntry.Text, out double horas) && double.TryParse(tarifaEntry.Text, out double tarifa))
                {
                    double sueldo = horas * tarifa * 7; // 7 d�as en una semana
                    resultadoLabel.Text = $"Sueldo de la semana: {sueldo.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"))}";
                }
                else
                {
                    resultadoLabel.Text = "Ingrese valores num�ricos v�lidos.";
                }
            })
        };

        // Elemento de la p�gina
        Content = new StackLayout
        {
            Margin = new Thickness(20),
            Children =
            {
                horasEntry,
                tarifaEntry,
                calcularButton,
                resultadoLabel
            }
        };

    }
}