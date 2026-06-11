using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Servicio service = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarNumero_Click(object sender, EventArgs e)
        {
            //Leer Valor del textBox registrar
            int valor = Convert.ToInt32(tbIngresarNumero.Text);

            //Pasarle el valor al método atravez del objeto
            service.registrarValor(valor);

            //Limpiar box
            tbIngresarNumero.Clear();
        }

        private void btnActualizar1_Click(object sender, EventArgs e)
        {
            //Guarda el retorno del metodo calcular.M de clase servicio.
            double maximo = service.CalcularMaximo();
            //Convierte e imprime para mostrar en el lb.
            lbMaximo.Text = maximo.ToString();

            double minimo = service.CalcularMinimo();
            lbMinimo.Text = minimo.ToString();
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            double promedio = service.CalcularPromedio();
            lbPromedio.Text = promedio.ToString();
        }

        private void btnActualizar3_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = service.contador.ToString();
        }
        private void btnListaO_Click(object sender, EventArgs e)
        {
            service.OrdenarLista();
            lsbCantidadIngresados.Items.Clear();

            for (int i = 0; i < service.contador; i++)
            {
                lsbCantidadIngresados.Items.Add(service.Lista[i]);
            }

        }

        private void btnListaSupProm_Click(object sender, EventArgs e)
        {
            lsbCantidadIngresados.Items.Clear();
            int contadorSuperiores = 0;
            int[] resultado = service.ListaSuperioresAlPromedio(out contadorSuperiores);
            for (int i = 0; i < contadorSuperiores; i++)
            {
                lsbCantidadIngresados.Items.Add(resultado[i]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscado = Convert.ToInt32(tbBuscar.Text);
            lbValorABuscar.Text = service.BuscarValor(buscado).ToString();
        }
    }
}
