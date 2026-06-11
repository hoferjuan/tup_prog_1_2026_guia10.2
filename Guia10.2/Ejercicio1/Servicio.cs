using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Servicio
    {
        public int[] Lista = new int[1000];
        public int contador = 0;

        public Servicio()
        {
        }
        public void registrarValor(int valor)
        {
            if (contador < 1000 && contador >= 0)
            {
                Lista[contador] = valor;
                contador++;
            }
        }
        public double CalcularPromedio()
        {
            double acum = 0;
            for (int i = 0; i < contador; i++)
            {
                acum += Lista[i];
            }
            double promedio = acum / contador;
            return promedio;
        }
        public double CalcularMaximo()
        {
            //Validación
            if (contador == 0)
            {
                return 0;
            }

            int maximo = Lista[0];

            for (int i = 1; i < contador; i++)
            {
                if (Lista[i] > maximo)
                {
                    maximo = Lista[i];
                }
            }
            return maximo;
        }
        public double CalcularMinimo()
        {
            if (contador == 0)
            {
                return 0;
            }
            int minimo = Lista[0];

            for (int i = 1; i < contador; i++)
            {
                if (Lista[i] < minimo)
                {
                    minimo = Lista[i];
                }
            }
            return minimo;
        }
        public void OrdenarLista()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (Lista[i] > Lista[j])
                    {
                        Intercambiar(i, j);
                    }
                }
            }
        }
        private void Intercambiar(int i, int j)
        {
            int aux = Lista[i];
            Lista[i] = Lista[j];
            Lista[j] = aux;
        }
        public int BuscarValor(int buscado)
        {
            int n = 0;
            int pos = -1;
            while (pos == -1 && n < contador)
            {
                if (Lista[n] == buscado)
                {
                    pos = n;
                }
                n++;
            }
            return pos;
        }
        public int[] ListaSuperioresAlPromedio(out int contadorSuperiores)
        {
            double promedio = CalcularPromedio();
            contadorSuperiores = 0;

            for (int n = 0; n < contador; n++)
            {
                if (Lista[n] > promedio)
                {
                    contadorSuperiores++;
                }
            }
            int[] resultado = new int[contadorSuperiores];
            int pos = 0;

            for (int n = 0; n < contador; n++)
            {
                if (Lista[n] > promedio)
                {
                    resultado[pos] = Lista[n];
                    pos++;
                }
            }
            return resultado;
        }
    }
}
