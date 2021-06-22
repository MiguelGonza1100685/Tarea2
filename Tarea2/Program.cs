using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                int opcion;

                Funciones errores = new Funciones();



                Console.WriteLine("=======================================================================");
                Console.WriteLine("Miguelangel Gonzalez 1100685");
                Console.WriteLine("=======================================================================");
                Console.WriteLine("1.Error OverFlow");
                Console.WriteLine("2.Error Overflow2");
                Console.WriteLine("3.Error Underflow");
                Console.WriteLine("0.Para salir");
                Console.WriteLine("=======================================================================");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 0:
                        Console.WriteLine("Bye.");

                        break;

                    case 1:
                        errores.Overflow();

                        break;

                    case 2:
                        errores.Overflow2();

                        break;


                    case 3:
                        errores.Underflow();

                        break;




                };


            }

        }

        class Funciones

        {
            public void Overflow2()
            {

                {

                    int t = 10;
                    int i = checked(-1234567891 * t);

                }

            }



            public void Overflow()
            {
                {
                    byte a = 0;

                    while (a <= 500)
                    {

                        Console.WriteLine($"El resultado es: {a}");
                        a++;
                    }



                }
            }


            public void Underflow()
            {
                {

                    SByte a = -128;

                    while (a <= 500)
                    {

                        Console.WriteLine($"El resultado es: {a}");
                        a++;
                    }





                }
            }




        }
    }


}
    }
}
