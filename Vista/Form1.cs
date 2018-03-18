using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {

        Datos.Validador o = new Datos.Validador();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ENTERO
            String valido = "";
            String inval = "";
            if (o.esEntero(txtEntero.Text)){
                valido += "Entero\n";
            }
            else {
                inval += "Entero\n";
            }
            //DECIMAL
            if (o.esDecimal(txtDecimal.Text)){
                valido += "Decimal\n";
            }
            else
            {
                inval += "Decimal\n";
            }
            //EDAD
            if (o.esEdad(txtEdad.Text)){
                valido += "Edad\n";
            }
            else
            {
                inval += "Edad\n";
            }

            //DIGITO
            //EDAD
            if (o.esDigito(txtDigito.Text))
            {
                valido += "Digito\n";
            }
            else
            {
                inval += "Digito\n";
            }

            MessageBox.Show("Validos:\n"+valido+"Invalidos:\n"+inval);
        }
    }
}
