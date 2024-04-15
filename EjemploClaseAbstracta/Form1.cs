using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploClaseAbstracta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehiculo
        {
            //tipoDeAcceso_abstract_tipoDeDatoRetorno_NombreMetodo
            public abstract double CantidadCombustible();

        }

        class Torton : Vehiculo
        {
            //Override nos permite rescribir en los metodos abstractos, igual
            // funciona para el método virtual
            public override double CantidadCombustible()
            {
                return 200; 
            }
        }

        class Sedan : Vehiculo
        {
            public override double CantidadCombustible()
            {
                return 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";
            Vehiculo vehiculo;
            vehiculo = new Torton();
            double CantidadCombustible = vehiculo.CantidadCombustible();
            texto = "La cantidad de combustible del Torton es: " + CantidadCombustible + Environment.NewLine;
            vehiculo = new Sedan();
            double CombustibleSedan = vehiculo.CantidadCombustible();
            texto += "La cantidad de combustible del Sedan es: " + CombustibleSedan + Environment.NewLine;
            textBox1.Text = texto;
        }
    }
}
