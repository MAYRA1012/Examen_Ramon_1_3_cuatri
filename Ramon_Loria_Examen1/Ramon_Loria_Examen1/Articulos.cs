using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Loria_Examen1
{
    class Articulos
    {

        public static float[] Id_Prod = new float[5];
        public static string[] Nom_Prod = new string[5];
        public static float dato;
        public static float[] Cost_Prod = new float[5];
       // public static float[] Hora_fin = new float[10];
        public static float[] Precio = new float[5];
        public static float[] Venta = new float[5];

        public static int indice = 0;





        public void menu_Modificar()


        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1 - Agregar Articulo");
                Console.WriteLine("2 - Borrar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("4 - Salir");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Agregar(); break;
                    case 2:// Borrar(); break;
                    case 3: Consultar3(); break;



                    default:
                        break;
                }
            } while (opcion != 4);


        }

        public static void Agregar()
        {
            int opcion = 0;
            int dato;
            try
            {
                do
                {
                    Console.WriteLine("Digite el codigo del Articulo");
                    Id_Prod[indice] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el nombre del Articulo");
                    Nom_Prod[indice] = Console.ReadLine();
                    Console.WriteLine("Digite el Precio del Articulo ");
                    Cost_Prod[indice] = Convert.ToInt32(Console.ReadLine());
                    indice++;
                    Console.WriteLine("Desea continuar 1-Si o 2-No");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion >= 1 && opcion != 2);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ya no puede ingresar mas Articulos");

                indice = 4;
            }
            finally
            {
                Console.WriteLine("Mensaje de finally");

            }

        }



        public static int Consultar()
        {
            //int posicion;
            // posicion = 0;
            int i = 0;   // indice para recorrer el arreglo
            Console.WriteLine("Digite el codigo del Articulo:");
            // string Id_Prod = Console.ReadLine();
            float Id_Prod2 = Convert.ToInt32(Console.ReadLine());

            while ((i <= indice) && (!Id_Prod2.Equals(Id_Prod[i])))
            {
                i++;
            }

            if (i > indice - 1)
            {
                i = -1;   // 
            }
            return i;
        }






        public static void Mod_Id_Prod()
        {

            int pos = Consultar();
            int opcion = 0;
            int dato;
            try
            {
                do
                {


                    float[] Id_Prod_Nueva = new float[10];
                    Console.WriteLine("Digite la Correccion de la  Id_Prod delarticulo");
                    Id_Prod[pos] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Desea continuar 1-Si o 2-No");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion >= 1 && opcion != 2);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ya no puede ingresar mas Articulos");

                indice = 4;
            }
            finally
            {
                Console.WriteLine("Mensaje de finally");

            }

        }

        public static void Consultar3()
        {
            int pos2 = Consultar();
            //porciento = 0;
            float PORC = 0;



            if (pos2 < 0)
            {
                Console.WriteLine("El Articulo no existe");
            }
            else
            {
                Console.WriteLine("Id_Prod: \n" + Id_Prod[pos2] + "  ");
                Console.WriteLine("Nom_Prodiculo: \n" + Nom_Prod[pos2] + "   ");
                Console.WriteLine("Cost_Prod: \n" + "    " + Cost_Prod[pos2]);
               // Console.WriteLine("Hora_fin: \n" + "   " + Hora_fin[pos2]);
                Console.WriteLine("Precio: \n" + "    " + Precio[pos2]);
                //Console.WriteLine("Monto a cancelar: \n");


                //  Console.WriteLine($"{Id_Prod[pos2]}  {c}  {Cost_Prod[pos2]} {"    "} { Hora_fin[pos2]} {"    "} { Precio[pos2]} ");

                //Console.WriteLine($"{Id_Prod[i]}  {Nom_Prod[i]}");



            }








        }

        public static void Reporte33()
        {
            Console.WriteLine("Id Producto  Descripcion Costo");
            for (int i = 0; i < indice; i++)
            {
                if (!Id_Prod[i].Equals(""))
                {
                    Console.WriteLine($"{Id_Prod[i]}  {Nom_Prod[i]}  {Cost_Prod[i]}   ");

                    //Console.WriteLine($"{placa[i]}  {tipo_veh[i]}");
                }

            }
            Console.WriteLine("-------------------------------");
        }




    }
}
