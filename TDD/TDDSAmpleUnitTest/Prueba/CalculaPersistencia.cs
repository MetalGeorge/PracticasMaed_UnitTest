using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class CalculaPersistencia
    {
        public int Calcula(long numero)
        {
            /// contar las veces que el resultado de la multiplicación de los dígitos devuelve un número de más de un dígito
            int suma = 0;
            var resultado = 1;
            var resultadoCadena = numero.ToString();
            int longitudCadena = resultadoCadena.Length;
            while (resultadoCadena.Length > 1)
            {
                for (int pos = 0; pos <= resultadoCadena.Length-1; pos++ )
                {
                    resultado *= Convert.ToInt32(resultadoCadena[pos].ToString());
                }
                suma++;
                resultadoCadena = resultado.ToString();
                resultado = 1;
            }
            
            return suma;
        }




    }
}

