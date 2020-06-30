using System;
using System.Collections.Generic;


namespace patronDecorador_CSharp
{
    public class StrikerEureka : IJaeger
    {
        public string getNombre() => "Striker Eureka";
        public int getNoBrasos() => 2;
        public string getEspecialidad() => "Ataques a media distancia";
        public int getHabilidad() => 68;
        public int getVelocidad() => 45; // KM/H
        public int getDefensa() => 46;

    }
}