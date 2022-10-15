using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Loria_Examen1
{
    class ClsCalculos
    {

        public static void Calcular()
        {  Console.Clear();
            consultas.consult_Catego();
           // ClsVendedores.vendedoresu();


            float und;
           

            double total, unidad, costo, monto,descon;
            int pos2 = Articulos.Consultar();
            //porciento = 0;
            float PORC = 0;



            if (pos2 < 0)
            {
                Console.WriteLine("El codigo no existe");
            }
            else
            {

                Console.WriteLine("Cuantas unidades Vendio");
                Artic_lo.unidades = Convert.ToInt32(Console.ReadLine());
                //unidad = Artic_lo.unidades;
                descon = Artic_lo.desc;
                unidad = Artic_lo.unidades;

                //salida = Hora_fin[pos2];
                monto = Articulos.Cost_Prod[pos2];
                total = (unidad * monto)-((unidad* monto)*descon);






                //Console.WriteLine("placa  tipo_veh Hora_Ing Hora_fin Precio total");

                Console.Clear();
                // Console.WriteLine($"{placa[pos2]}  {tipo_veh[pos2]}  {Hora_Ing[pos2]}  { Hora_fin[pos2]}  { Precio[pos2]} {total}");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("------------------------------RUTA UTOPIA----------------------------------");

                Console.WriteLine("\n\n\nNombre de Articulo  " + Articulos.Nom_Prod[pos2]);
                Console.WriteLine("Codigo Producto:  " + Articulos.Id_Prod[pos2]);

                Console.WriteLine("Unidades Vendidas  " + Artic_lo.unidades);
                Console.WriteLine("costo Unitario:  " + Articulos.Cost_Prod[pos2]);
                Console.WriteLine("Descuento  " + Artic_lo.desc);
                Console.WriteLine("Total:  " + total);

                Console.WriteLine("\n\n\n---------------------------------------------------------------------------");
            }


        }








    }
}
