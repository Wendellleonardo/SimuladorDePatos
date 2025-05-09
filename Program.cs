namespace SimuladorDePatos;

class Program
{
    static void Main(string[] args)
    {
        int opcao;
        bool iniciarJogo = false;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nSeja bem-vindo ao simulador de patos!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Neste programa você poderá conhecer um pouco mais de algumas espécies de pato, vamos lá!");
        do
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nSelecione uma opção para ver o que essa espécie faz: \n1 - Marreco\n2 - Pato zarro-americano\n3 - Pato de borracha\n4 - Pato do mato\n5 - Pato arlequim\n6 - Pato-das-torrentes\n0 - Sair do programa.");
            Console.ForegroundColor = ConsoleColor.White;
            opcao = int.Parse(Console.ReadLine()!);

            if (opcao == 0) {
                break;
            }
            switch (opcao)
            {
                case 1:
                    DucksHelper.exibirPatos(opcao);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato? 1 para sim, ou qualquer outro número para voltar ao menu.");
                    int selecionar = int.Parse(Console.ReadLine()!);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (selecionar == 1) {
                        iniciarJogo = true;
                    }
                    break;
                case 2:
                    DucksHelper.exibirPatos(opcao);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato? 1 para sim, ou qualquer tecla para voltar ao menu.");
                    selecionar = int.Parse(Console.ReadLine()!);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (selecionar == 1) {
                        iniciarJogo = true;
                    }
                    break;
                case 3:
                    DucksHelper.exibirPatos(opcao);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato? 1 para sim, ou qualquer tecla para voltar ao menu.");
                    selecionar = int.Parse(Console.ReadLine()!);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (selecionar == 1) {
                        iniciarJogo = true;
                    }
                    break;
                case 4:
                    DucksHelper.exibirPatos(opcao);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato? 1 para sim, ou qualquer tecla para voltar ao menu.");
                    selecionar = int.Parse(Console.ReadLine()!);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (selecionar == 1) {
                        iniciarJogo = true;
                    }
                    break;
                case 5:
                    DucksHelper.exibirPatos(opcao);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato? 1 para sim, ou qualquer tecla para voltar ao menu.");
                    selecionar = int.Parse(Console.ReadLine()!);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (selecionar == 1) {
                        iniciarJogo = true;
                    }
                    break;
                case 6:
                    DucksHelper.exibirPatos(opcao);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato? 1 para sim, ou qualquer tecla para voltar ao menu.");
                    selecionar = int.Parse(Console.ReadLine()!);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (selecionar == 1) {
                        iniciarJogo = true;
                    }
                    break;
                default:
                    Console.WriteLine("\nOpção não cadastrada!");
                    break;
            }

        } while (iniciarJogo == false);

        if (opcao == 0) {
            return;
        }

        do {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nDigite a ação que seu pato deve realizar (de acordo com o que ele faz segundo a descrição) ou 0 para sair do programa:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDigite 'quack' para fazer um som, 'swim' para ele nadar, 'fly' para fazer ele voar, 'sleep' para colocar ele para dormir ou 'wakeup' para acordá-lo.");
            string selecionar = Console.ReadLine()!.ToLower();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            if (selecionar == "0") {
                return;
            }

            switch (opcao)
            {
                case 1:
                    DucksHelper.jogar(opcao, selecionar);
                    break;
                case 2:
                    DucksHelper.jogar(opcao, selecionar);
                    break;
                case 3:
                    DucksHelper.jogar(opcao, selecionar);
                    break;
                case 4:
                    DucksHelper.jogar(opcao, selecionar);
                    break;
                case 5:
                    DucksHelper.jogar(opcao, selecionar);
                    break;
                case 6:
                    DucksHelper.jogar(opcao, selecionar);
                    break;
                default:
                    Console.WriteLine("Ação não conhecida! Tente novamente.");
                    break;
            }
        } while (iniciarJogo == true);
    }
}
