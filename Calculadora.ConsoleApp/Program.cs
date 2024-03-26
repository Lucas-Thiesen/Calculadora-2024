namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            { 
            Console.Clear();
            Console.WriteLine("Calculadora Tabajara 2024!");

            Console.WriteLine("Digite 1 para Somar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para multiplicar");

            Console.WriteLine("Digite (S) para Sair!");

            string comando = Console.ReadLine();

                if (comando == "S")
                    break;
                
            Console.WriteLine("Digite o primeiro número!");

            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

            Console.WriteLine("Digite o Segundo número!");

            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = 0;
                if(comando == "1")
                {
                resultado = primeiroNumero + segundoNumero;
                }
                else if (comando == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (comando == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                Console.WriteLine(resultado);
                Console.ReadLine();

            }
        }
    }
}
