using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int w, q, n;
            int cantidad, numero, suma = 0;
            double o, l, respuesta;
            string continuar;



            Console.WriteLine("Hola me llamo BMO, soy un chatbot ¿Como te llamas?");
                string Nombre = Console.ReadLine();
            Console.Clear();
            do
            {
                Console.WriteLine("Hola {0} ¿Cómo puedo ayudarte?\n", Nombre);
                Console.WriteLine("Menú\n");
                Console.WriteLine("1.- Realizar una operación matemática");
                Console.WriteLine("2.- Calcular el área");
                Console.WriteLine("3.- Salir\n");
                Console.WriteLine("Ingrese una respuesta, para continuar");
                q = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (q == 1)

                {
                    do
                    {
                        Console.WriteLine("Realizar una operación matemática\n");
                        Console.WriteLine("Menú\n");
                        Console.WriteLine("1.- Suma ");
                        Console.WriteLine("2.- Resta");
                        Console.WriteLine("3.- Multiplicación");
                        Console.WriteLine("4.- División");
                        Console.WriteLine("5.- Salir\n");
                        Console.WriteLine("Ingrese una respuesta, para continuar");
                        int p = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        switch (p)
                        {



                            case 1: //Operacion "suma de n numeros"
                                Console.WriteLine("Suma\n");
                                Console.WriteLine("Ingresa la cantidad de datos a sumar");
                                cantidad = int.Parse(Console.ReadLine());
                                Console.Clear();

                                suma = 0;

                                for (int i = 0; i < cantidad; i++)


                                {
                                    Console.WriteLine("Ingresa la cantidad");
                                    numero = int.Parse(Console.ReadLine());
                                    suma = suma + numero;
                                }

                                Console.WriteLine("El resultado es: {0}\n", suma);




                                break;


                            case 2: //Operacion "Resta"
                                Console.WriteLine("Resta\n");
                                Console.WriteLine("Ingresa la cantidad de datos a restar");
                                cantidad = int.Parse(Console.ReadLine());
                                Console.Clear();

                                suma = 0;

                                for (int i = 0; i < cantidad; i++)
                                {
                                    Console.WriteLine("Ingresa la cantidad");
                                    numero = int.Parse(Console.ReadLine());


                                    suma = suma - numero;
                                }
                                Console.WriteLine("");
                                Console.WriteLine("El resultado es: {0}", suma);



                                break;
                                    


                            case 3: // Operacion "Multiplicación"

                                suma = 0;
                                Console.WriteLine("Multiplicación\n");
                                Console.WriteLine("Ingresa la cantidad de datos a multiplicar");
                                cantidad = int.Parse(Console.ReadLine());
                                Console.Clear();

                                for (int i = 0; i < cantidad; i++)


                                {
                                    Console.WriteLine("Ingresa la cantidad");
                                    numero = int.Parse(Console.ReadLine());
                                    suma = numero * numero;
                                }

                                Console.WriteLine("El resltado es: {0}", suma);

                                break;




                            case 4: //Operacion "División"

                                Console.WriteLine("División\n");
                                Console.WriteLine("Ingresa el valor del dividendo");
                                o = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingresa el valor del divisor");
                                l = Convert.ToDouble(Console.ReadLine());

                                respuesta = o / l;
                                Console.WriteLine("Es resultado es: {0}", respuesta);
                                break;

                            case 5:
                                //Agregar una funcion que permita regresar a el menu principal
                                break;



                        }


                        Console.WriteLine("¿Deseas continuar?  (y/n)\n");
                        continuar = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Clear();



                    }


                    while (continuar != "n");
                }


                else if (q == 2)

                {
                    do
                    {

                        Console.WriteLine("Calcular el area\n");
                        Console.WriteLine("Menu\n");
                        Console.WriteLine("1.- Circulo");
                        Console.WriteLine("2.- Cuadrado");
                        Console.WriteLine("3.- Triangulo rectangulo");
                        Console.WriteLine("4.- Rectangulo");
                        Console.WriteLine("5.- Salir\n");
                        Console.WriteLine("Ingrese una respuesta, para continuar");
                        int y = Convert.ToInt32(Console.ReadLine());

                        switch (y)
                        {

                            case 1:
                                Console.WriteLine("Circulo\n");
                                Console.WriteLine("Ingrese el valor del radio");
                                w = Convert.ToInt32(Console.ReadLine());
                                respuesta = 3.131592 * (w ^ 2);
                                Console.WriteLine("El area del circulo es: {0}", respuesta);

                                break;


                            case 2:
                                Console.WriteLine("Cuaudrado\n");
                                Console.WriteLine("Ingresa el valor de algun de los lados del cuadrado");
                                cantidad = int.Parse(Console.ReadLine());

                                respuesta = cantidad ^ 2;
                                Console.WriteLine("El resultado es: {0}",respuesta);

                                break;

                            case 3:
                                Console.WriteLine("Triangulo rectangulo\n");
                                Console.WriteLine("Ingresa el valor de la base");
                                cantidad = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el valor del lado que coincida con la altura");
                                n = int.Parse(Console.ReadLine());

                                respuesta = cantidad * n / 2;
                                Console.WriteLine("El resultado es: {0}",respuesta);
                                break;

                            case 4:
                                Console.WriteLine("Rectabgulo\n");
                                Console.WriteLine("Ingresa el valor del largo del cuadrado");
                                cantidad = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingresa el valor del ancho del cuadrado");
                                n = int.Parse(Console.ReadLine());

                                respuesta = cantidad * n;
                                Console.WriteLine("El resultado es: {0}",respuesta);

                                break;

                        }

                        Console.WriteLine("¿Deseas continuar?  (y/n)\n");
                        continuar = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Clear();

                    }

                    while (continuar != "n");



                }







                Console.WriteLine("¿Deseas salir?  (y/n)");
                continuar = Console.ReadLine();
                Console.WriteLine("");
                Console.Clear();
            }

            while (continuar != "y");








        }
    }
}