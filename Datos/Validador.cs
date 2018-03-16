using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Validador
    {
        //ENTEROS
        public Boolean esEntero(String entero)
        {
            int ne;
            if (int.TryParse(entero, out ne))
            {
                if (entero.Contains(',') || entero.Contains('.'))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else {
                return false;
            }
           
        }

        //DECIMALES
        public Boolean esDecimal(String decim)
        {
            Decimal nd;
            if (Decimal.TryParse(decim, out nd))
            {
                if (decim.Contains(',') || decim.Contains('.'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


        //EDADES
        public Boolean esEdad(String edad) {
            int nedad;
            if (int.TryParse(edad, out nedad))
            {
                if (nedad>0 && nedad<=110)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
