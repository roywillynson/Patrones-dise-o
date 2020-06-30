using System;

namespace patronStrategy_CSharp
{

    //Este es el contexto
    class FinalStrategy
    {
        private IHistoria strategyHistoria;
        public FinalStrategy(IHistoria strategyHistoria)
        {
            this.strategyHistoria = strategyHistoria;
        }

        public void desenlace()
        {
            this.strategyHistoria.accion();
        }

    }
}
