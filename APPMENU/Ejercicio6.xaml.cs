namespace APPMENU;

public partial class Ejercicio6 : ContentPage
{
	public Ejercicio6()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //El entry1 se convierte a numero tipo double se realiza con double.TryParse y que vuleve verdadero si la convercion es exitosa.
        //si es exitosa el valor convertido se asigna ala variable PesoMexicano.
        if (double.TryParse(Entry1.Text, out double PesoMexicano))
        {
            //Se define una variable llamada tasa de tipo double la cual almacena la tasa de cambio de pesos mexicanos a dolares.
            //1 peso mexicano equivale hoy en dia a 0.056 dolares.
            double Tasa = 0.056;


            //Se calcula el valor del dolar multiplicando la cantidad de pesos mexicanos por la tasa de cambio
            //El resultado se almacena en la  variable llamada Dolar tipo double
            double Dolar = PesoMexicano * Tasa;

            //En el entry 2 se asigna 
            //el valor calculado en dólares,
            //formateado con dos decimales y precedido por el signo $. N2 es un especificador de formato
            //que asegura que el número se muestre con dos decimales.
            Entry2.Text = $"${Dolar:N2} dólares";
        }
        else
        {
            //Si la conversion es falsa mandara un mensaje de error en el entry2
            Entry2.Text = "Ingrese una cantidad válida en pesos mexicanos.";
        }
    }

    private void Limpiar_Button(object sender, EventArgs e)
    {
        Entry1.Text = "";
        Entry2.Text = "";
    }


}