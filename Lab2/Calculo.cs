using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab2
{
    public class Calculo
    {
        public static double multiplicarNumeros(double n1, double n2)
        {
            return n1 * n2;
        }
        public static void escribirBitacora(string textoGuardar)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\Users\Dell\source\repos\Lab2Guillermo\bitacoraSistema.txt", true))
            {
                objStrem.WriteLine(textoGuardar);
                objStrem.Flush(); //Guardar en el archivo bitacoraSistema.txt
            }
           
        }
    }
}