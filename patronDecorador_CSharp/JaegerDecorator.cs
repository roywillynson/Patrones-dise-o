using System;
using System.Collections.Generic;


namespace patronDecorador_CSharp
{


    public abstract class JaegerDecorador : IJaeger
    {
        protected IJaeger jaeger;

        public JaegerDecorador(IJaeger jaeger)
        {
            this.jaeger = jaeger;
        }

        //Implementacion
        public virtual string getNombre() => jaeger.getNombre();
        public virtual int getNoBrasos() => jaeger.getNoBrasos();
        public virtual string getEspecialidad() => jaeger.getEspecialidad();
        public virtual int getHabilidad() => jaeger.getHabilidad();
        public virtual int getVelocidad() => jaeger.getVelocidad(); // KM/H
        public virtual int getDefensa() => jaeger.getDefensa();
        public virtual string getTituloDeBatalla() => jaeger.getTituloDeBatalla();

        public virtual string description()
        {
            return String.Format("Jaeger {0}: \nNombre: {1} \nNumero de brasos: {2} \nEspecialidad: {3} \nHabilidad: {4} \nVelocidad: {5} KM/H \nDefensa: {6}\n", this.getTituloDeBatalla(), this.getNombre(), this.getNoBrasos(), this.getEspecialidad(), this.getHabilidad(), this.getVelocidad(), this.getDefensa());
        }
    }

    public class JaegerTurbinaDecorador : JaegerDecorador
    {

        public JaegerTurbinaDecorador(IJaeger jaeger) : base(jaeger)
        {

        }

        //Implementacion
        public override string getNombre() => base.getNombre();
        public override string getEspecialidad() => base.getEspecialidad() + " y Experto en turbina";
        public override int getHabilidad() => base.getHabilidad() + 20;
        public override int getVelocidad() => base.getVelocidad() + 40; // KM/H
        public override string getTituloDeBatalla() => "Dead Machine!!";


        public string addedTurbine()
        {
            return ("Turbina Agregada + , velocidad + 40, habilidad + 20\n");
        }

        public override string description()
        {
            return base.description() + this.addedTurbine();
        }
    }

    //Segundo Decorador

    public class JaegerArmasonDeAceroDecorador : JaegerDecorador
    {

        public JaegerArmasonDeAceroDecorador(IJaeger jaeger) : base(jaeger)
        {

        }

        //Implementacion
        public override string getNombre() => base.getNombre();
        public override string getEspecialidad() => base.getEspecialidad() + " y Defensa de Acero!";
        public override int getHabilidad() => base.getHabilidad() + 24;
        public override int getVelocidad() => base.getVelocidad() - 30; // KM/H
        public override int getDefensa() => base.getDefensa() + 100;
        public override string getTituloDeBatalla() => "Armour Tank Destroyer!";


        public string addedArmason()
        {
            return ("Armason + , velocidad  - 30, habilidad + 24, defensa + 100!! Ni king jon un va poder con este \n");
        }

        public override string description()
        {
            return base.description() + this.addedArmason();
        }
    }

}