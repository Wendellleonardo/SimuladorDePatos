namespace SimuladorDePatos;

class Program
{
    static void Main(string[] args)
    {

        int opcao, selecionar = -1;
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

            if (opcao == 0)
            {
                break;
            }
            if (opcao >= 1 && opcao <= 6)
            {
                int indiceAtual = opcao;

                bool escolhendoPato = true;
                while (escolhendoPato == true)
                {
                    DucksHelper.exibirPatos(indiceAtual);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nDeseja jogar com esse pato?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("7 - Avançar para o próximo pato");
                    Console.WriteLine("8 - Voltar para o pato anterior");
                    Console.WriteLine("Qualquer outro número - Voltar ao menu principal");
                    Console.ForegroundColor = ConsoleColor.White;
                    string entrada = Console.ReadLine()!;

                    try
                    {
                        selecionar = int.Parse(entrada);
                    }
                    catch
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente!");
                        continue;
                    }

                    switch (selecionar)
                    {
                        case 1:
                            iniciarJogo = true;
                            escolhendoPato = false;
                            break;
                        case 7:
                            if (indiceAtual < 6)
                            {
                                indiceAtual++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nVocê já está no último pato!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case 8:
                            if (indiceAtual > 1)
                            {
                                indiceAtual--;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nVocê já está no primeiro pato!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        default:
                            escolhendoPato = false;
                            break;
                    }
                }
            }

            do
            {
                if (iniciarJogo == false)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nDigite a ação que seu pato deve realizar (de acordo com o que ele faz segundo a descrição) ou 0 para voltar ao menu:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nSelecione uma opção para o pato realizar uma ação: \n1 - Quack\n2 - Voar\n3 - Nadar\n4 - Dormir\n5 - Acordar\n0 - Voltar para o menu inicial.");
                int selecao = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (selecao == 0)
                {
                    iniciarJogo = false;
                    Console.WriteLine("Voltando para o menu inicial...");
                }

                switch (opcao)
                {
                    case 1:
                        DucksHelper.jogar(opcao, selecao);
                        break;
                    case 2:
                        DucksHelper.jogar(opcao, selecao);
                        break;
                    case 3:
                        DucksHelper.jogar(opcao, selecao);
                        break;
                    case 4:
                        DucksHelper.jogar(opcao, selecao);
                        break;
                    case 5:
                        DucksHelper.jogar(opcao, selecao);
                        break;
                    case 6:
                        DucksHelper.jogar(opcao, selecao);
                        break;
                    default:
                        Console.WriteLine("Ação não conhecida! Tente novamente.");
                        break;
                }
            } while (iniciarJogo == true);

        } while (iniciarJogo == false);


    }
}
