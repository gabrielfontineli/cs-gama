using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo moto = new Veiculo();
            moto.conduzir();
            Aviao boeing = new Aviao();
            boeing.conduzir();
            Carro l200 = new Carro();
            l200.conduzir();
        }
    }
    class Aviao : Veiculo
    {
        public virtual void conduzir()
        {
            Console.WriteLine("Estou pilotando!");
        }
    }
    class Veiculo
    {
        private void ligarMotor()
        {
            Console.WriteLine("Motor ligado!!");
        }
        private void desligarMotor()
        {
            Console.WriteLine("Motor desligado!!");
        }
        public void conduzir()
        {
            Console.WriteLine("Estou conduzindo!");
        }

    }
    class Carro : Veiculo
    {
        public virtual void conduzir()
        {
            Console.WriteLine("Estou dirigindo");
        }
    }
}
