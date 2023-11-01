using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = pantallas.pantallaPrincipal();
            do
            { 
                Console.Clear();
              switch(opcion)
              {
                case 1:
                    opcion = pantallas.registrarNota();
                    break;
                    case 2:
                        opcion= pantallas.NotaMayor();
                    break;
                    case 3:
                        opcion=pantallas.NotaMenor();
                    break;
                    case 4:
                        opcion=pantallas.BuscarNota();
                    break;
                    case 5:
                        opcion=pantallas.ModificarNota();
                    break;
                    case 6:
                        opcion=pantallas.NotasRegistradas();
                    break;
                case 0:
                default:
                    opcion = pantallas.pantallaPrincipal();
                        break;
              }
            }while( opcion != 7 ); 
             
            Console.ReadLine();



              

        }
    }
}
