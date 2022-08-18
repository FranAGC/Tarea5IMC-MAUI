namespace Tarea5IMC;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
	{
		double estatura = 0;
		double peso = 0;
		double res = 0;

        try
        {
            if(rbCms.IsChecked == true)
            {
                //conversion a metros
                estatura = Convert.ToDouble(txtEstatura.Text) / 100;
            }
            else if(rbPlgs.IsChecked == true)
            {
                estatura = Convert.ToDouble(txtEstatura.Text) * 0.0254;
            }

            if (rbLbs.IsChecked == true)
            {
                //conversion a kilogramos
                peso = Convert.ToDouble(txtPeso.Text) * 0.4536;
            }
            else if (rbKgms.IsChecked == true)
            {
                peso = Convert.ToDouble(txtPeso.Text);
            }


        }
        catch(Exception ex)
        {
        }

		res = peso / (estatura * estatura);

        if (res < 18.5 && res > 0)
		{
            txtRes.Text = "Tu IMC es de: " + Math.Round(res, 2) + " - Peso inferior" + "\n*El peso normal se tiene con un IMC entre 18.5 y 25";
        }
		else if(res >= 18.5 && res < 25)
		{
            txtRes.Text = "Tu IMC es de: " + Math.Round(res, 2) 
                + " - Peso normal" + "\n*El peso normal se tiene con un IMC entre 18.5 y 25";
        }
        else if (res >= 25 && res < 30)
        {
            txtRes.Text = "Tu IMC es de: " + Math.Round(res, 2) 
                + " - Sobrepeso" + "\n*El peso normal se tiene con un IMC entre 18.5 y 25";
        }
        else if (res >= 30)
        {
            txtRes.Text = "Tu IMC es de: " + Math.Round(res, 2) 
                + " - Obesidad" + "\n*El peso normal se tiene con un IMC entre 18.5 y 25";
        }
        else if (estatura <= 0 || peso <= 0)
        {
            txtRes.Text = "Campos obligatorios y deben ser numeros mayores a 0";
        }

    }


    void Onplgs(object sender, CheckedChangedEventArgs e)
    {
        txtEstatura.Placeholder = "Ingresa tu estatura en pulgadas";
    }
    void Oncms(object sender, CheckedChangedEventArgs e)
    {
        txtEstatura.Placeholder = "Ingresa tu estatura en centimetros";
    }
    void Onkgs(object sender, CheckedChangedEventArgs e)
    {
        txtPeso.Placeholder = "Ingresa tu peso en kilogramos";
    }
    void Onlbs(object sender, CheckedChangedEventArgs e)
    {
        txtPeso.Placeholder = "Ingresa tu peso en libras";
    }





}

