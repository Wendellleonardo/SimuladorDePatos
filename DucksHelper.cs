namespace SimuladorDePatos;

public class DucksHelper
{
    public static void exibirPatos(int _opcao)
    {
        if (_opcao == 1)
        {
            MallardDuck pato = new MallardDuck();
            pato.display();
            pato.Origin();
            pato.Nome();
            pato.Familia();
        }
        if (_opcao == 2)
        {
            RedHeadDuck pato = new RedHeadDuck();
            pato.display();
            pato.Origin();
            pato.Nome();
            pato.Familia();
        }
        if (_opcao == 3)
        {
            RubberDuck pato = new RubberDuck();
            pato.display();
            pato.Origin();
            pato.Nome();
            pato.Familia();
        }
        if (_opcao == 4)
        {
            MuscovyDuck pato = new MuscovyDuck();
            pato.display();
            pato.Origin();
            pato.Nome();
            pato.Familia();
        }
        if (_opcao == 5)
        {
            HarlequinDuck pato = new HarlequinDuck();
            pato.display();
            pato.Origin();
            pato.Nome();
            pato.Familia();
        }
        if (_opcao == 6)
        {
            TorrentDuck pato = new TorrentDuck();
            pato.display();
            pato.Origin();
            pato.Nome();
            pato.Familia();
        }
    }
    public static void jogar(int _opcao, string _selecionar)
    {
        if (_opcao == 1)
        {
            MallardDuck pato = new MallardDuck();
            if (_selecionar == "quack") {
                pato.Quack();
            }
            else if (_selecionar == "fly") {
                pato.Fly();
            }
            else if (_selecionar == "swim") {
                pato.swim();
            }
            else if (_selecionar == "sleep") {
                pato.Sleep();
            }
            else if (_selecionar == "wakeup") {
                pato.WakeUp();
            }
        }
        if (_opcao == 2)
        {
            RedHeadDuck pato = new RedHeadDuck();
            if (_selecionar == "quack") {
                pato.Quack();
            }
            else if (_selecionar == "fly") {
                pato.Fly();
            }
            else if (_selecionar == "swim") {
                pato.swim();
            }
            else if (_selecionar == "sleep") {
                pato.Sleep();
            }
            else if (_selecionar == "wakeup") {
                pato.WakeUp();
            }
            
        }
        if (_opcao == 3)
        {
            RubberDuck pato = new RubberDuck();
            if (_selecionar == "quack") {
                pato.Quack();
            }
            else if (_selecionar == "fly") {
                Console.WriteLine("Esse pato não voa!");
            }
            else if (_selecionar == "swim") {
                pato.swim();
            }
            else if (_selecionar == "sleep") {
                Console.WriteLine("O pato de borracha não dorme!");
            }
            else if (_selecionar == "wakeup") {
                Console.WriteLine("O pato de borracha não dorme!");
            }
            
        }
        if (_opcao == 4)
        {
            MuscovyDuck pato = new MuscovyDuck();
            if (_selecionar == "quack") {
                pato.Quack();
            }
            else if (_selecionar == "fly") {
                pato.Fly();
            }
            else if (_selecionar == "swim") {
                pato.swim();
            }
            else if (_selecionar == "sleep") {
                pato.Sleep();
            }
            else if (_selecionar == "wakeup") {
                pato.WakeUp();
            }
            
        }
        if (_opcao == 5)
        {
            HarlequinDuck pato = new HarlequinDuck();
            if (_selecionar == "quack") {
                pato.Quack();
            }
            else if (_selecionar == "fly") {
                Console.WriteLine("Esse pato não voa, ele apenas plana!");
            }
            else if (_selecionar == "swim") {
                pato.swim();
            }
            else if (_selecionar == "sleep") {
                pato.Sleep();
            }
            else if (_selecionar == "wakeup") {
                pato.WakeUp();
            }
            
        }
        if (_opcao == 6)
        {
            TorrentDuck pato = new TorrentDuck();
            if (_selecionar == "quack") {
                pato.Quack();
            }
            else if (_selecionar == "fly") {
                pato.Fly();
            }
            else if (_selecionar == "swim") {
                pato.swim();
            }
            else if (_selecionar == "sleep") {
                pato.Sleep();
            }
            else if (_selecionar == "wakeup") {
                pato.WakeUp();
            }

        }
    }
}