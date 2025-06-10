using System.Runtime.InteropServices;
using edu.arthur.csharp.Model; // Importando a Model para poder utilizar os métodos e atributos da classe Calculadora

namespace edu.arthur.csharp.Controller
{
    public class CalculadoraController
    {
        private Calculadora calculadora = new Calculadora(); // Instanciando a classe Calculadora para poder utilizar os métodos e atributos dela
        public double ExecutarFuncao()
        {
            Console.WriteLine("""
                              
                              [1] Somar
                              [2] Subtrair
                              [3] Multiplicar
                              [4] Dividir
                              
                              """);
            while (true)
            {

                Console.Write("Escolha: ");

                // Pegando o número e realizando casting para int
                if (int.TryParse(Console.ReadLine(), out var valor))
                {
                    // Conforme o valor passado estamos realizando as operações
                    switch (valor)
                    {
                        case (1):
                        {
                            return calculadora.Somar();
                        }
                        case (2):
                        {
                            return calculadora.Subtrair();
                            
                        }
                        case (3):
                        {
                            return calculadora.Multiplicar();
                           
                        }
                        case (4):
                        {
                            return calculadora.Dividir();
                        }

                        default:
                        {
                            Console.WriteLine("Valor Invalido");
                            continue;
                        }
                    }
                }
                else // Realizando tratativa de valor inválido com o else
                {
                    Console.WriteLine("Valor Invalido");
                }
            }
        }
        public void PegarValores(Boolean modo)
        {
            // Passando para variável qual palavra deve aparecer conforme o valor desejado
            var qualValor = modo ? "primeiro" : "segundo";

            while (true)
            {

                Console.Write($"Digite o {qualValor} valor: ");

                // Pegando o número e realizando casting para double
                if (double.TryParse(Console.ReadLine(), out var valor))
                {
                    // atribuindo valor a classe conforme o valor boolean
                    if (modo)
                    {
                        calculadora.SetPrimeiroValor(valor);
                    }
                    else
                    {
                        calculadora.SetSegundoValor(valor);
                    }

                    return;
                }
                else // Realizando tratativa de valor inválido com o else
                {
                    Console.WriteLine("Valor Invalido");
                }
            }
        }
    }
}
