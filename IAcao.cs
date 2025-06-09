namespace FormsPatos;
public interface IAcao
{
    
}
public interface IQuack : IAcao
{
    string Quack(string nome);
}
public interface IVoar : IAcao
{
    string Voar(string nome);
}
public interface INadar : IAcao
{
    string Nadar(string nome);
}
public interface IDormir : IAcao
{
    string Dormir(string nome);
}
public interface IAcordar : IAcao
{
    string Acordar(string nome);
}