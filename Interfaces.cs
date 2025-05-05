namespace SimuladorDePatos;

public interface IQuackable{
    public void Quack();
}

public interface IFlyable
{
    public void Fly();
}

public interface IStatus {
    public void Sleep();
    public void WakeUp();
}


public interface IOrigin
{
    public void Origin();
}

public interface IOCienfica
{
    public void Nome();
    public void Familia();
}