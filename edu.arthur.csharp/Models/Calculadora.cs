using System;

namespace edu.arthur.csharp.Model
{
    public class Calculadora
    {
        private double PrimeiroValor, SegundoValor;

        // Função de realizar soma
        public double Somar()
        {
            return (GetPrimeiroValor() + GetSegundoValor());
        }
        
        // Função de realizar subtração
        public double Subtrair()
        {
            return (GetPrimeiroValor() - GetSegundoValor());
        }
        
        // Função de realizar multiplicação
        public double Multiplicar()
        {
            return (GetPrimeiroValor() * GetSegundoValor());
        }
        
        // Função de realizar divisão
        public double Dividir()
        {
            return (GetPrimeiroValor() / GetSegundoValor());
        }
        

        /* Getters e Setters Abaixo */
        
        public double GetPrimeiroValor()
        {
            return this.PrimeiroValor;
        }
        public void SetPrimeiroValor(double PrimeiroValor)
        {   
            this.PrimeiroValor = PrimeiroValor;
        }


        public double GetSegundoValor()
        {
            return this.SegundoValor;
        }
        public void SetSegundoValor(double SegundoValor)
        {
            this.SegundoValor = SegundoValor;
        }
    }
}
