using System;

namespace JogoGourmet
{
    class Program
    {
        static void Main(string[] args)
        {
            Prato prato = new Prato();


            prato.AdicionarPrato("Massa", "Macarrão");

            while (true)
            {
                var novoPrato = prato.NovaTentativa();

                Console.WriteLine("Pense em um prato [pressione ENTER para continuar]");
                Console.ReadKey();
                Console.WriteLine($"O prato que você pensou é {novoPrato.TipoDoPrato}? [S,N]");
                string simNao = Console.ReadLine().ToUpper();

                if (simNao == "S")
                {
                    Console.WriteLine($"O prato que você pensou é {novoPrato.NomePrato}? [S,N]");
                    simNao = Console.ReadLine().ToUpper();

                    if (simNao == "S")
                    {
                        Console.WriteLine("Acertamos!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Em qual prato você pensou?");
                        string nomeDoPrato = Console.ReadLine();

                        prato.AdicionarPrato(novoPrato.TipoDoPrato, nomeDoPrato);

                    }
                }
                else
                {
                    Console.WriteLine("Em qual prato você pensou?");
                    string nomeDoPrato = Console.ReadLine();
                    Console.WriteLine($"E {nomeDoPrato} é qual tipo de prato? [Massa, carne, legume]");
                    string tipoDoPrato = Console.ReadLine();

                    prato.AdicionarPrato(tipoDoPrato, nomeDoPrato);
                }

                Console.Clear();
            }
        }
    }
}
