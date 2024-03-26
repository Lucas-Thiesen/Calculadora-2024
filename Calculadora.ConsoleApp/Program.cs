namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            bool ehVerdade = true;

            do
            {          
            Console.WriteLine("Calculadora Tabajara 2024!");
            Console.WriteLine("Digite o primeiro número!");

            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

            Console.WriteLine("Digite o Segundo número!");

            string segundoNumeroString= Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = primeiroNumero + segundoNumero;

            Console.WriteLine(resultado);

            Console.WriteLine("Você deseja continuar? (S/N)");
            string resposta = Console.ReadLine();

                if (resposta == "n")
                {
                    ehVerdade = false;
                }          

            } while (ehVerdade == true);
        }
    }
}
