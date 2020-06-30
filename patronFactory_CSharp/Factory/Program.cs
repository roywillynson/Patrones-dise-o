using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonFactory fabrica = new PokemonFactory();

            IPokemon charmaleon = fabrica.getPokemon(PokemonFactory.Pokemon.CHARMALEON);
            IPokemon pikachu = fabrica.getPokemon(PokemonFactory.Pokemon.PIKACHU);
            IPokemon nidoran = fabrica.getPokemon(PokemonFactory.Pokemon.NIDORAN);

            //Nidoran
            nidoran.grito();
            nidoran.descripcion();

            //Nidoran
            pikachu.grito();
            pikachu.descripcion();

            //Charmaleon
            charmaleon.grito();
            charmaleon.descripcion();
        }
    }
}
