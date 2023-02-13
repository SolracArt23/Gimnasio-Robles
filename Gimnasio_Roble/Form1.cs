using System.Linq.Expressions;

namespace Gimnasio_Roble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Respuesta from = new Respuesta();
            //Values
            try
            {
                var beneficio = 1.0;
                var sueldo_r = sueldo[Sueldo_text.Text];
                var estrato_r = estrato_fun[estrato.Text];
                var nombre_r = Nombre.Text;
                var cedula_r = cedula.Text;
                
                //Evaluar genero
                if (genero.Text =="Femenino") 
                {
                     beneficio = 0.05;
                }

                //Cambiar las variables 
                from.cedula.Text = cedula_r;
                from.nombre_r.Text = nombre_r;
                from.sueldo.Text = Sueldo_text.Text;
                from.estrato.Text = estrato.Text;
                from.genero.Text = genero.Text;

                //Llamado a la respuesta
                from.Resultado.Text ="$"+Convert.ToString(sueldo_r-(sueldo_r *(beneficio + estrato_r)));
                from.Show();
            }
            catch
            {
                Console.WriteLine("error");
            }


            }

        
    }
}