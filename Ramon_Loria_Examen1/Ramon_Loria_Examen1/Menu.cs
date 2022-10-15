using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Loria_Examen1
{
    class Menu
    {
        public void menu()
        {
            int opcion = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1- Artículos");
                Console.WriteLine("2 - Facturación");
                Console.WriteLine("3 - Reporte:");
               // Console.WriteLine("4 - Facturar");
                Console.WriteLine("4 - Salir");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: modificar();
                        break;

                      case 2:  ClsCalculos.Calcular();
                   // case 2:consultas.consult_Catego() ; break;
                        //case 2:vendedoresu(); break;
                        break;
                    case 3: Articulos.Reporte33();
                     break;

                  /*  case 4:
                       // ClsVendedores.vendedoresu();
                        break;
                  */

                    //case 4:ClsCalculos.Calcular();
                    // ClsDic.Listado_Vendedores();

                    //    break;



                    default:
                        break;
                }

            } while (opcion != 4);

        }


        public void modificar()
        {

            Articulos menu = new Articulos();
            menu.menu_Modificar();
            Console.WriteLine("Registro ha sido actualizado");

        }

        /*  public void vendedoresu()
          {

              Console.WriteLine("Digite el codigo del vendedor" );
              Artic_lo.Cod_Vendedor = Convert.ToInt32(Console.ReadLine());

          }
        */

        


    }
}
