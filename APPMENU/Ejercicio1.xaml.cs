namespace APPMENU;

public partial class Ejercicio1 : ContentPage
{
	public Ejercicio1()
	{
		InitializeComponent();
        //Se agrega el metodo MostrarPares para que se ejecute al iniciar el progrma
        MostrarPares();
    }

    //Se crea un metodo llamado MostrarPares
    private void MostrarPares()
    {
        //Se declara una lista de enteros llamada NumerosPares
        List<int> NumerosPares = new List<int>();

        //Se inicia crea un bucle que comienza con i igual a cero
        //y se incrementa en 2 en cada interacion hasta que i,
        //sea mayor o igual a 100
        for (int i = 0; i <= 100; i += 2)
        {
            //En el bucle en cada iteración, el valor actual de i se añade a la lista NumerosPares.
            //Dado que i se incrementa de 2 en 2, solo se añadirán números pares a la lista.
            NumerosPares.Add(i);
        }

        //Se crea una cadena llamada NumerosParesTexto 
        //que contiene todos los números en la lista NumerosPares que son separados por comas.
        string NumerosParesTexto = string.Join(",", NumerosPares);


        //el valor de NumerosParesTexto al texto de NumeroParesText.
        //Esto mostrará todos los números pares generados en la lista separados por comas.
        NumeroParesText.Text = NumerosParesTexto;


    }




}