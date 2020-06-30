/*
Jaegers es un robot gigante mecanico
*/
using System;

namespace patronDecorador_CSharp
{

    public interface IJaeger
    {
        string getNombre();
        int getNoBrasos();
        string getEspecialidad();
        int getHabilidad() => 10;
        int getVelocidad() => 10; // KM/H
        int getDefensa() => 10;
        string getTituloDeBatalla() => "Maquina de Guerra";

        string description()
        {
            return String.Format("Jaeger {0}: \nNombre: {1} \nNumero de brasos: {2} \nEspecialidad: {3} \nHabilidad: {4} \nVelocidad: {5} KM/H \nDefensa: {6}\n", this.getTituloDeBatalla(), this.getNombre(), this.getNoBrasos(), this.getEspecialidad(), this.getHabilidad(), this.getVelocidad(), this.getDefensa());
        }
    }

}