using System;

namespace Factory
{

    interface IPokemon
    {
        string nombre { get; }
        string category { get; }
        string type { get; }
        int attack { get; }
        void grito();

        void descripcion()
        {
            Console.WriteLine("{0} es de tipo {1} y tiene un ataque basico de {2}", nombre, type, attack);
        }
    }

}