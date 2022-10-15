using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Loria_Examen1
{

    class Artic_lo
    {
        public static int Cod_Vendedor { get; set; }
        public static string nombre { get; set; }

        public static int unidades { get; set; }

        public static int Categoria_23 { get; set; }
        public static double desc { get; set; }


        public  Artic_lo() { }
        public Artic_lo(int ced, string nomb)
        {
            Cod_Vendedor = ced;
            nombre = nombre;
        }
    }





    class ClsDic
    {
        public static Dictionary<int, String> Vendedor = new Dictionary<int, string>()
            {
                {1, "Manue" },
                {2, "Ricardo" },


            };

        public static void Listado_Vendedores()
        {

     


            string resultado = "";
            if (Vendedor.TryGetValue(Artic_lo.Cod_Vendedor, out resultado))
            {
                Console.WriteLine(resultado);
               

            }
         
            Console.Read();

            return;


        }



    }
}
