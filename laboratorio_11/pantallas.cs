using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_11
{
    public class pantallas
    {
        public static int[] notas = new int[300];
        public static int contador = 0;
        public static int pantallaPrincipal()
        {
            Console.Write(""+
                "================================\n" +
                "Casos con arreglos\n" +
                "================================\n" +
                "1: Registrar notas\n" +
                "2: Hallar la nota mayor\n" +
                "3: Hallar la nota menor\n" +
                "4: Encontrar una nota\n" +
                "5: Modificar una nota\n" +
                "6: Ver notas registradas\n" +
                "7: Salir\n" +
                "================================\n"); 
             return operaciones.getEntero("Ingrese una opción:");
        }
        public static int registrarNota()
        {
            Console.Clear();
            Console.Write("" +
                "===============================\n" +
                " Registrar una nota\n" +
                " ================================\n");
            int registrarnota = operaciones.getEntero("Ingresa la nota Nro 1:");
           if(contador == 300)
           {
                Console.WriteLine("LA LISTA YA ESTA LLENA");
           }
            notas[contador] = registrarnota;
            contador++;
            Console.Write(""+
                   "===============================\n" +
                "1: Registrar otra nota\n" +
                "2: Regresar\n");


            int opcion =  operaciones.getEntero("Ingrese una opción:");
            if (opcion == 2) return 0;
            return opcion;
        }
        public static int NotaMayor()
        {
            
            Console.Clear();
            Console.Write("" +
                "================================\n" +
                "La nota mayor\n" +
                "================================\n"+
                if (contador == 0)
                {
                   Console.WriteLine("No existe ninguna nota todavia");
                }
               else
               {
                    float mayor = notas[0];
                    int posicionMayor = 0;
                   for (int i = 0; i < contador; i++)
                   {
                        if (notas[i] > mayor)
                        {
                           mayor = notas[i];
                           posicionMayor = i;
                        }
                   }
                  int registrarNota = notas[posicionMayor];
               }
            int NotaMayor = 



            "================================\n" +
                "1: Regresar\n" ;
            int opcion= operaciones.getEntero("Ingrese una opción:");
            if (opcion == 1) return 0;
            return opcion;

        }
        public static int NotaMenor()
        {
            Console.Clear();
            Console.Write("" +
                "================================\n" +
                "La nota menor\n" +
                "================================\n" +
                "La nota mayor es: 10\n" +
                "15 16 18 [10] 12 15 13" +
                "================================\n" +
                "1: Regresar\n");
            int opcion = operaciones.getEntero("Ingrese una opción:");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int BuscarNota()
        {
            Console.Clear();
            Console.Write("" +
                "================================\n" +
                "Buscar nota\n" +
                "=============================\n");
            int registrarnota = operaciones.getEntero("Ingrese la nota a buscar:");
            Console.WriteLine("La nota está en la posición: " + contador);
            for (int i = 0; i < contador; i++) 
            {
                Console.WriteLine(i + "->" + notas[i]);
                
            }
            
            Console.Write("" +
                "================================\n" +
                "1: Regresar\n");
            int opcion = operaciones.getEntero("Ingrese una opción:");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int ModificarNota()
        {
            Console.Clear();
            Console.Write("" +
                "================================\n" +
                "Modificar nota\n" +
                "================================\n" +
                "Ingrese la posición: 3\n" +
                "Ingrese el nuevo valor: 19\n" +
                "================================\n" +
                "Antes:15 16 18 [10] 12 15 13\n" +
                "Después:15 16 18 [19] 12 15 13\n" +
                "================================\n" +
                "1: Regresar\n");
            int opcion = operaciones.getEntero("Ingrese una opción:");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int NotasRegistradas()
        {
            Console.Clear();
            Console.Write("" +
                "================================\n" +
                "Notas Registradas\n" +
                "================================\n" +
                "Notas actuales\n:" +
                "15 - 16 – 18 – 19 - 12 - 15 – 13\n" +
                "Siguiente posición será: 7\n" +
                "================================\n" +
                "1: Regresar\n");
            int opcion = operaciones.getEntero("Ingrese una opción:");
            if (opcion == 1) return 0;
            return opcion;
        }

    }
}
