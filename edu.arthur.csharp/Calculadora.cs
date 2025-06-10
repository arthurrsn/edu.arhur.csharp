using edu.arthur.csharp.Controller;

namespace edu.arthur.csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var controller = new CalculadoraController(); // Passando construtor da classe para variável
            controller.PegarValores(true);
            controller.PegarValores(false);
            
            // Pegando resultado e imprimindo
            var resultado = controller.ExecutarFuncao();
            Console.WriteLine($"\nresultado: {resultado:F2}"); // 2 pontos flutuantes
        }
    }
}
