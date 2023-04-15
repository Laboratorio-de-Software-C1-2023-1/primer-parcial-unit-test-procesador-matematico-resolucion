using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_unit_test_procesador_matematico
{
    public class ProcesadorMatematico
    {
        private int _resultado;

        public void Sumar(int primerNumero, int segundoNumero)
        {
            this._resultado = primerNumero + segundoNumero;
            if (this.EsNegativo())
            {
                this._resultado = 0;
            }
        }

        public void Dividir(int dividendo, int divisor)
        {
            this._resultado = dividendo / divisor;
            if (this.EsNegativo())
            {
                this._resultado = 0;
            }
        }
        private bool EsNegativo()
        {
            return (this._resultado < 0);
        }

        public void CalcularMayor(int primerNumero, int segundoNumero)
        {
            if (primerNumero > segundoNumero)
            {
                this._resultado = primerNumero;
            }
            else if (primerNumero < segundoNumero)
            {
                this._resultado = segundoNumero;
            }
            else
            {
                this._resultado = segundoNumero;
            }
        }
    }
}
