using System;


namespace Factory
{

    //Pokemon Charmanleon
    class Charmaleon : IPokemon
    {

        public string nombre => "Charmaleon";

        public string category => "Fuego";

        public string type => "Fuego";

        public int attack => 12;

        public void grito()
        {
            Console.WriteLine("Charr Charrmaleonn!!");
        }
    }

    //Pokemon Nidoran
    class Nidoran : IPokemon
    {

        public string nombre => "Nidoran";

        public string category => "Raton Venenoso";

        public string type => "Venenoso";

        public int attack => 7;

        public void grito()
        {
            Console.WriteLine("Nido nidoraann!!!");
        }
    }


    //Pokemon Pikachu
    public class Pikachu : IPokemon
    {

        public string nombre => "Pikachu";

        public string category => "Raton";

        public string type => "Electrico";

        public int attack => 10;

        public void grito()
        {
            Console.WriteLine("Pika pika...Chuu!!!");
        }
    }

}