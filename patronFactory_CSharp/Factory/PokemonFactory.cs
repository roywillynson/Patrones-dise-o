using System;

namespace Factory
{
    class PokemonFactory
    {

        public enum Pokemon
        {
            CHARMALEON,
            PIKACHU,
            NIDORAN
        }

        public IPokemon getPokemon(Pokemon tipo)
        {

            if (tipo == Pokemon.CHARMALEON)
            {

                return new Charmaleon();

            }
            else if (tipo == Pokemon.NIDORAN)
            {

                return new Nidoran();

            }
            else if (tipo == Pokemon.PIKACHU)
            {

                return new Pikachu();

            }

            return null;

        }

    }
}