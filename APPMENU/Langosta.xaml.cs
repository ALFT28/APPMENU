namespace APPMENU;

public partial class Langosta : ContentPage
{

    int np = 0;
    double total = 0;

    public Langosta()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        np = Convert.ToInt32(entry1.Text);

        if (np > 300)
        {
            total = np * 75;
        }
        else if (np > 200)
        {
            total = np * 85;
        }
        else
        {
            total = np * 95;
        }
        entryPresupuesto.Text = Convert.ToString(total);

    }




}