namespace SimuladorDePatos;

class Program
{
    static void Main(string[] args)
    {
        MallardDuck mk = new MallardDuck();
        mk.display();

        RubberDuck borracha = new RubberDuck();
        borracha.display();
        borracha.Quack();

        RedHeadDuck rh = new RedHeadDuck();
        rh.display();
        rh.Fly();
        rh.Quack();

        // Console.WriteLine("Hello, World!");
    }
}
