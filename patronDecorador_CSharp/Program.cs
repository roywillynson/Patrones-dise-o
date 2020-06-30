
/*
Este es un ejemplo del Patron Decorador de la pelicula Pacific rim
*/

using System;

namespace patronDecorador_CSharp
{
    class Program
    {


        public static void Main(string[] args)
        {

            //Striker Eureca
            Console.WriteLine("-------------------STRIKER EUREKA----------------------");
            //Sin decorador
            IJaeger strikerEureka = new StrikerEureka();

            //Con Decorador basico
            IJaeger strikerEurekaWithTurbine = new JaegerTurbinaDecorador(strikerEureka);


            //Decorador Anidado 
            IJaeger strikerEurekaWithTurbineAndArmour = new JaegerArmasonDeAceroDecorador(strikerEurekaWithTurbine);


            //Imprimir detalle de la maquina 
            Console.WriteLine(strikerEureka.description());

            Console.WriteLine(strikerEurekaWithTurbine.description());

            Console.WriteLine(strikerEurekaWithTurbineAndArmour.description());

            //Striker Eureca
            Console.WriteLine("-------------------CHERNO ALPHA----------------------");
            //Sin decorador
            IJaeger chernoAlpha = new ChernoAlpha();

            //Con Decorador basico
            IJaeger chernoAlphaWithTurbine = new JaegerTurbinaDecorador(chernoAlpha);


            //Decorador Anidado 
            IJaeger chernoAlphaWithTurbineAndArmour = new JaegerArmasonDeAceroDecorador(chernoAlphaWithTurbine);


            //Imprimir detalle de la maquina 
            Console.WriteLine(chernoAlpha.description());

            Console.WriteLine(chernoAlphaWithTurbine.description());

            Console.WriteLine(chernoAlphaWithTurbineAndArmour.description());



        }



    }
}
