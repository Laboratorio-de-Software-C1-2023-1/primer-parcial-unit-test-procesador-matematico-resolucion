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

        public int Sumar(int primerNumero, int segundoNumero)
        {
            this._resultado = primerNumero + segundoNumero;
            if (this.EsNegativo())
            {
                this._resultado = 0;
            }

            return this._resultado;
        }

        public int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("No se acepta divisor igual a cero");
            }

            this._resultado = dividendo / divisor;
            if (this.EsNegativo())
            {
                this._resultado = 0;
            }

            return this._resultado;
        }
        private bool EsNegativo()
        {
            return (this._resultado < 0);
        }

        public int CalcularMayor(int primerNumero, int segundoNumero)
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

            return this._resultado;
        }
    }
}
