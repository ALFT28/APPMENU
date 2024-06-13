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

        // Botón que calcula y muestra el resultado del pago
        var calcularButton = new Button
        {
            Text = "Calcular",
            // Botón que maneja el evento Clicked
            Command = new Command(() =>
            {
                // Maneja el cálculo del sueldo semanal cuando se hace clic en el botón
                if (double.TryParse(horasEntry.Text, out double horas) && double.TryParse(tarifaEntry.Text, out double tarifa))
                {
                    double sueldo = horas * tarifa * 7; // 7 días en una semana
                    resultadoLabel.Text = $"Sueldo de la semana: {sueldo.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"))}";
                }
                else
                {
                    resultadoLabel.Text = "Ingrese valores numéricos válidos.";
                }
            })
        };

        // Elemento de la página
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