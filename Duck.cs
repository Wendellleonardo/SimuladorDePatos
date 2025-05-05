namespace SimuladorDePatos;

public class Duck
{
    public virtual void display()
    {
        Console.WriteLine("Pato");
    }
    public virtual void swim()
    {
        Console.WriteLine("O pato está nadando...");
    }
}

public class MallardDuck : Duck, IFlyable, IQuackable, IOrigin, IOCienfica, IStatus
{
    public override void display()
    {
        Console.WriteLine("\nEste é o pato marreco! Ele pode fazer 'quack', voar, nadar, dormir e acordar.");
    }
    public override void swim()
    {
        Console.WriteLine("O pato marreco está nadando...");
    }
    public void Sleep()
    {
        Console.WriteLine("O pato marreco está indo dormir...");
    }
    public void WakeUp()
    {
        Console.WriteLine("O pato marreco está acordando...");
    }

    public void Fly()
    {
        Console.WriteLine("O pato marreco está voando...");
    }
    public void Quack()
    {
        Console.WriteLine("O pato marreco fez: quack quack!");
    }
    public void Origin()
    {
        Console.WriteLine("Ele é originário da região paleoártica.");
    }
    public void Nome()
    {
        Console.WriteLine("Seu nome científico é: Spatula querquedula.");
    }
    public void Familia()
    {
        Console.WriteLine("Ele faz parte da família Anatidae.");
    }
}

public class RedHeadDuck : Duck, IQuackable, IFlyable, IOrigin, IOCienfica, IStatus
{
    public override void display()
    {
        Console.WriteLine("\nEste é o pato zarro-americano! Ele pode fazer 'quack', voar, nadar, dormir e acordar.");
    }
    public override void swim()
    {
        Console.WriteLine("O pato zarro-americano está nadando...");
    }
    public void Sleep()
    {
        Console.WriteLine("O pato zarro-americano está indo dormir...");
    }
    public void WakeUp()
    {
        Console.WriteLine("O pato zarro-americano está acordando...");
    }
    public void Fly()
    {
        Console.WriteLine("O pato zarro-americano está voando...");
    }
    public void Quack()
    {
        Console.WriteLine("O pato zarro-americano fez: Quack quack!");
    }
    public void Origin()
    {
        Console.WriteLine("Ele é originário da América do Norte.");
    }
    public void Nome()
    {
        Console.WriteLine("Seu nome científico é: Aythya affinis.");
    }
    public void Familia()
    {
        Console.WriteLine("Ele faz parte da família Anatidae.");
    }
}

public class RubberDuck : Duck, IQuackable, IOrigin, IOCienfica
{
    public override void display()
    {
        Console.WriteLine("\nEste é o pato de borracha! Ele fez 'quack'.");
    }
    public override void swim()
    {
        Console.WriteLine("O pato está boiando...");
    }
    public void Quack()
    {
        Console.WriteLine("O pato de borracha fez: Quack quack!");
    }
    public void Origin()
    {
        Console.WriteLine("O pato de borracha pode ser encontrado em qualquer lugar do mundo.");
    }
    public void Nome()
    {
        Console.WriteLine("O pato de borracha não possui nome científico.");
    }
    public void Familia()
    {
        Console.WriteLine("Ele também não possui nenhuma família.");
    }
}

public class MuscovyDuck : Duck, IQuackable, IFlyable, IOrigin, IOCienfica, IStatus
{
    public override void display()
    {
        Console.WriteLine("\nEste é o pato do mato! Ele pode fazer 'quack', voar, nadar, dormir e acordar.");
    }
    public override void swim()
    {
        Console.WriteLine("O pato do mato está nadando...");
    }
    public void Sleep()
    {
        Console.WriteLine("O pato do mato está indo dormir...");
    }
    public void WakeUp()
    {
        Console.WriteLine("O pato do mato está acordando...");
    }
    public void Quack()
    {
        Console.WriteLine("O pato do mato fez: Quack quack!");
    }
    public void Fly()
    {
        Console.WriteLine("O pato do mato está voando...");
    }
    public void Origin()
    {
        Console.WriteLine("O pato do mato é originário da América Latina, e é encontrado em maior número na América do Sul.");
    }
    public void Nome()
    {
        Console.WriteLine("Seu nome científico é: Cairina moschata.");
    }
    public void Familia()
    {
        Console.WriteLine("Ele faz parte da família Anatidae.");
    }
}

public class HarlequinDuck : Duck, IQuackable, IOrigin, IOCienfica, IStatus
{
    public override void display()
    {
        Console.WriteLine("\nEste é o pato arlequim! Ele pode fazer 'quack', nadar, dormir e acordar.");
    }
    public override void swim()
    {
        Console.WriteLine("O pato arlequim está nadando...");
    }
    public void Sleep()
    {
        Console.WriteLine("O pato arlequim está indo dormir...");
    }
    public void WakeUp()
    {
        Console.WriteLine("O pato arlequim está acordando...");
    }
    public void Quack()
    {
        Console.WriteLine("O pato arlequim fez: Quack quack!");
    }
    public void Origin()
    {
        Console.WriteLine("Ele está presente no noroeste dos Estados Unidos, no nordeste da Rússia, na Islândia e no sul da Groenlândia.");
    }
    public void Nome()
    {
        Console.WriteLine("Seu nome científico é: Histrionicus histrionicus.");
    }
    public void Familia()
    {
        Console.WriteLine("Ele faz parte da família Anatidae.");
    }
}

public class TorrentDuck : Duck, IQuackable, IFlyable, IOrigin, IOCienfica, IStatus
{
    public override void display()
    {
        Console.WriteLine("\nEste é o pato-das-torrentes! Ele pode fazer 'quack', voar, nadar, dormir e acordar.");
    }
    public override void swim()
    {
        Console.WriteLine("O pato-das-torrentes está nadando...");
    }
    public void Sleep()
    {
        Console.WriteLine("O pato-das-torrentes está indo dormir...");
    }
    public void WakeUp()
    {
        Console.WriteLine("O pato-das-torrentes está acordando...");
    }
    public void Quack()
    {
        Console.WriteLine("O pato-das-torrentes fez: Quack quack!");
    }
    public void Fly()
    {
        Console.WriteLine("O pato-das-torrentes está voando...");
    }
    public void Origin()
    {
        Console.WriteLine("Ele é originário da América do Sul, na região dos Andes.");
    }
    public void Nome()
    {
        Console.WriteLine("Seu nome científico é: Merganetta armata.");
    }
    public void Familia()
    {
        Console.WriteLine("Ele faz parte da família Anatidae.");
    }
}