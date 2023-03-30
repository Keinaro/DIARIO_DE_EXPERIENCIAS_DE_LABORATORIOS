using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_JFMP
{
    public class automovil
    {
        //declarra atributos privados de nuestra clase para que se utilicen posteriormente.
        private int modelo;
        private double precio, tipoCambioDolar, descuentoAplicado;
        private string marca;
        private bool disponible;

        //Métodos get y set que nos permiten enviar y recibir variables.
        public int Modelo { get { return modelo; } }
        public double Precio { get { return precio; } }
        public double TipoCambioDolar { get { return tipoCambioDolar; } }
        public double DescuentoAplicado { get { return descuentoAplicado; } }
        public string Marca { get { return marca; } }

        public automovil()
        {
            modelo = 2019;
            precio = 10000.00;
            marca = string.Empty;
            disponible = false;
            tipoCambioDolar = 7.50;
            descuentoAplicado = 0;
        }

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }

        public void DefinirMarca(string unaMarca)
        {
            marca = unaMarca;
        }

        public void DefinirCambioDolar(double unTipoCambio)
        {
            tipoCambioDolar = unTipoCambio;
        }

        public void CambiarDisponibilidad(bool Disponible)
        {
            disponible = Disponible;

            if (disponible)
            {
                disponible = true;
            }
            else
            {
                disponible = false;
            }
        }

        public string MostrarDisponibilidad()
        {
            if (disponible)
            {
                return "No se encuentra disponible actualmente"; 
            }
            else
            {
                return "Disponible";
            }
        }

        public double Conversion()
        {
            return precio / TipoCambioDolar;
        }
        
        public void AplicarDescuento(double miDescuento)
        {
            descuentoAplicado = miDescuento;
            double nuevoPrecio = precio - descuentoAplicado;
            DefinirPrecio(nuevoPrecio);
            Conversion();
        }

        public string MostrarInformacion()
        {
            return $"Marca: {marca}.\r\nModelo: {modelo}.\r\nPrecio de venta: {precio}.\r\nPrecio en dolares: ${Conversion()}.\r\n{MostrarDisponibilidad()}.";
        }
    }
}
