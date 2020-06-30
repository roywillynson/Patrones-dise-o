
using System;
using System.Collections.Generic;


namespace patronDecorador_CSharp
{
    public class ChernoAlpha : IJaeger
    {
        public string getNombre() => "Cherno Alpha";
        public int getNoBrasos() => 2;
        public string getEspecialidad() => "defensa";
        public int getHabilidad() => 40;
        public int getVelocidad() => 30; // KM/H
        public int getDefensa() => 60;

    }
}