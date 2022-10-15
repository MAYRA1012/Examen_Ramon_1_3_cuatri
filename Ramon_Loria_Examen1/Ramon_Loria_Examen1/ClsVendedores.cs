using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Loria_Examen1
{




    public class ClsVendedores
    {

        public static void vendedoresu()
        {
            try
            {
               


                Dictionary<int, String> Provincias = new Dictionary<int, string>()
            {
                {1, "Juan" },
                {2, "David"}


            };

                Console.WriteLine("Digite el codigo del vendedor");
                Artic_lo.Cod_Vendedor = Convert.ToInt32(Console.ReadLine());

                string resultado = "";


                if (Provincias.TryGetValue(Artic_lo.Cod_Vendedor, out resultado))
                {
                    // Console.WriteLine(resultado);



                }
                else
                {

                    Console.WriteLine("no existe");

                }

                Console.Read();





            }
            catch
            {


            }
            






        }

    }
}
