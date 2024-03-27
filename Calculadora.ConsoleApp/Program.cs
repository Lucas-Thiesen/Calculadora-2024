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
                Console.Write("--------------------------\n");
            Console.WriteLine("Digite 1 para Somar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");


            Console.WriteLine("Digite (S) para Sair!");
                Console.Write("--------------------------\n");


            string comando = Console.ReadLine();

                if (comando == "S" || comando == "s")
                    break;
                if (comando != "1" && comando != "2" && comando != "3" && comando != "4" && comando != "S")
                {
                    Console.WriteLine("Comando inválido, digite novamente!");
                    Console.ReadLine();

                    continue;
                }
            Console.WriteLine("Digite o primeiro número!");

            string primeiroNumeroString = Console.ReadLine();
            float primeiroNumero = Convert.ToInt32(primeiroNumeroString);

            Console.WriteLine("Digite o Segundo número!");

            string segundoNumeroString = Console.ReadLine();
            float segundoNumero = Convert.ToInt32(segundoNumeroString);

            float resultado = 0;
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
                else if (comando == "4")
                {
                    while(segundoNumero == 0)
                    {
                        Console.WriteLine("O segundo número não pode ser 0!!");
                        Console.WriteLine("Digite o valor novamente!");
                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                }

                {
                    

                    Console.WriteLine(resultado);
                }
                Console.ReadLine();

            }
        }
    }
}
