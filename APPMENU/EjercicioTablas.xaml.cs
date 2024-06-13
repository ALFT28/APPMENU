namespace APPMENU;

public partial class EjercicioTablas : ContentPage
{
	public EjercicioTablas()
	{
		InitializeComponent();

        // Se crea una etiqueta para las tablas de multiplicar
        var tablaLabel = new Label
        {
            Text = "Tablas de Multiplicar\n"
        };

        // Generamos las tablas de multiplicar
        for (int i = 1; i <= 10; i++)
        {
            tablaLabel.Text += $"\nTabla del {i}:\n";
            for (int j = 1; j <= 10; j++)
            {
                tablaLabel.Text += $"{i} x {j} = {i * j}\n";
            }
        }

        // Añadimos la etiqueta al contenido de la página
        Content = new ScrollView
        {
            Content = tablaLabel
        };
    }
}