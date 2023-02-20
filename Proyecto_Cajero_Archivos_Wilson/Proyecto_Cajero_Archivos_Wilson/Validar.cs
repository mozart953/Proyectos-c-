using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cajero_Archivos_Wilson
{
    class Validar
    {

        public int ValidaPin(string pin) {
            int a = 0;
            int contador = 0;
            string pin2 = "";
            //Aqui se llena un array con los numeros del 0-9
            string []numeros= new string [10];
            for (int cont=0;cont<10;cont++) {
                numeros[cont]=Convert.ToString(cont);
            }

            

            //Aqui se decide si el pin tiene 4 posiciones numericas
            if (pin.Length == 4)
            {
                for (int i = 0; i <4; i++)
                {
                    pin2 += pin[i];
                    for (int o=0;o<10;o++) {
                        
                        if (pin2==numeros[o])
                        {
                            contador++;
                        }
                        else { }
                        
                    }
                    pin2 = "";
                }

                if (contador == 4)
                {
                    a = 1; // si es 1 todo correcto
                }
                else
                {
                    a = 2; // si es 2 los caracteres no son numeriocos
                }


            }
            else { a = 0; } // si es 0 la longitud no es correcta

            

            return a;

        } 

        public int ValidaTar(string tarjeta)
        {
            int a = 0;
            int contador = 0;
            string pin2 = "";
            //Aqui se llena un array con los numeros del 0-9
            string[] numeros = new string[10];
            for (int cont = 0; cont < 10; cont++)
            {
                numeros[cont] = Convert.ToString(cont);
            }



            //Aqui se decide si el pin tiene 16 posiciones numericas
            if (tarjeta.Length == 16)
            {
                for (int i = 0; i <16; i++)
                {
                    pin2 += tarjeta[i];
                    for (int o = 0; o < 10; o++)
                    {

                        if (pin2 == numeros[o])
                        {
                            contador++;
                        }
                        else { }

                    }
                    pin2 = "";
                }

                if (contador == 16)
                {
                    a = 1; // si es 1 todo correcto
                }
                else
                {
                    a = 2; // si es 2 los caracteres no son numeriocos
                }


            }
            else { a = 0; } // si es 0 la longitud no es correcta



            return a;
        }

        public int validarNum(string numero) {
            int a = 0;
            int contador = 0;
            string pin2 = "";
            //Aqui se llena un array con los numeros del 0-9
            string[] numeros = new string[10];
            for (int cont = 0; cont < 10; cont++)
            {
                numeros[cont] = Convert.ToString(cont);
            }

            for (int i = 0; i < numero.Length; i++)
            {
                pin2 += numero[i];
                for (int o = 0; o < 10; o++)
                {

                    if (pin2 == numeros[o])
                    {
                        contador++;
                    }
                    else { }

                }
                pin2 = "";
            }

            if (contador == numero.Length)
            {
                a = 1; // si es 1 todo correcto
            }
            else
            {
                a = 2; // si es 2 los caracteres no son numeriocos
            }



            return a;
        }


    }
}
