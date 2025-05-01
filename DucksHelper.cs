namespace SimuladorDePatos;
public class MallardDuck : Duck, IFlyable, IQuackble
{
    public override void display(){
        Console.WriteLine("MallardDuck");
    }

    public void Fly(){
        Console.WriteLine("Flying");
    }
    public void Quack(){
        Console.WriteLine("Quack");
    }
}

public class  RedHeadDuck : Duck, IQuackble, IFlyable {
    public override void display()
    {
        Console.WriteLine("Redhead duck!");
    }
    public void Fly(){
        Console.WriteLine("Redhead duck is flying...");
    }
    public void Quack(){
        Console.WriteLine("Redhead duck says: Quack quack!");
    }
}

public class RubberDuck: Duck, IQuackble {
    public override void display()
    {
        Console.WriteLine("Rubber duck!");
    }
    public void Quack(){
        Console.WriteLine("Rubber duck says: Quack quack!");
    }
}