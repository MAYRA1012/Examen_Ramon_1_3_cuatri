using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Loria_Examen1
{

    public static class Extensions
    {



        public static bool find<T>(this List<T> list, T target)
        {
            return list.IndexOf(target) != -1;
        }
    }


    /// </summary>

    public class ClsCategoria
    {

        //

        public virtual void Promocion()
        {
            Console.WriteLine("Descuentos y promociones");

        }


    }

    class ClsCategoria1 : ClsCategoria
    {



        public override void Promocion()
        {


            Console.WriteLine("Descuento de 15 % ");
        }




    }

    class ClsCategoria2 : ClsCategoria
    {
        public override void Promocion()
        {


            Console.WriteLine("Promoción 2x1");
        }





    }








    class ClsCategoria3 : ClsCategoria
    {

        public override void Promocion()
        {

            Console.WriteLine("Todo a mitad de precio");
        }
    }




    public class consultas
    {

        public static void Listado_Categorias()
        {
            Console.WriteLine("Descuentos y promociones");




        }
        public static void consult_Catego()
        {
            Console.Clear();

            List<int> List_Categorias = new List<int> { 1, 2, 3, };

            Console.WriteLine("Digite el codigo de la categoria");

            int target = Convert.ToInt32(Console.ReadLine());

            Artic_lo.Categoria_23 = target;

            bool isExist = List_Categorias.find(target);
            if (isExist)
            {
                //Console.WriteLine("La Categoria si existe");

                if (target == 1)
                {

                    ClsCategoria1 cat = new ClsCategoria1();
                    cat.Promocion();
                    Artic_lo.desc = 0.15 ;
                }
                if (target == 2)
                {

                    ClsCategoria2 cat = new ClsCategoria2();
                    cat.Promocion();
                    Artic_lo.desc = 0.5;
                }
                if (target == 3)
                {

                    ClsCategoria3 cat = new ClsCategoria3();
                    cat.Promocion();

                    Artic_lo.desc = 0.5;
                }


            }
            else
            {
                Console.WriteLine("El numero de Categoria no existe");
            }


            Console.ReadLine();


        }







    }






















}
