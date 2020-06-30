/*
Esta es una referencia la juego The Last of Us 2, implementado en patron Strategy

Esto es basado en una post apocaliptica y realista de supervivvencia

Es ficticio
*/

using System;

namespace patronStrategy_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Historia: Un hombre que se llama Joel es asesinado, porque en el pasado cometio actos atroces uno de esos actos actroces tiene hija la pequeña llamada << Abby >> se queda guerfana y esta por eso lo asesino. Una prueba de que la culpa siempre nos alcanza.\n");

            Console.WriteLine("Una joven que era como una hija para Joel llamada Ellie ve este Acto de Maldad y No Perdona a Abby sin saber sus razones\n");

            Console.WriteLine("Si fueras Ellie que harias (Razona como si tu fueras Ellie, el Final se dira luego): \n");

            Console.WriteLine("1. Te vengarias de Abby\n");
            Console.WriteLine("2. La perdonarias\n");
            Console.WriteLine("3. O Quizas quisieras igualar las cosas\n");

            Console.WriteLine("\nSelecciona un numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            FinalStrategy finalIntermedio = new FinalStrategy(new FinalIntermedio());
            FinalStrategy finalFeliz = new FinalStrategy(new FinalFeliz());
            FinalStrategy finalTriste = new FinalStrategy(new FinalTriste());


            switch (n)
            {
                case 1:
                    Console.WriteLine("Resultado es un final agridulce: ");
                    finalIntermedio.desenlace();
                    break;
                case 2:
                    Console.WriteLine("Resultado es un final feliz: ");
                    finalFeliz.desenlace();
                    break;
                case 3:
                    Console.WriteLine("Resultado es un final triste: ");
                    finalTriste.desenlace();
                    break;

                default:
                    Console.WriteLine("Esa opcion no se encuentra lo siento");
                    break;
            }
        }
    }
}
