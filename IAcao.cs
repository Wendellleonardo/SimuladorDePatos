namespace FormsPatos;
public interface IAcao
{
    string Executar(string acao);
}
public interface IQuack : IAcao
{

}
public interface IVoar : IAcao
{

}
public interface INadar : IAcao
{

}
public interface IDormir : IAcao
{

}
public interface IAcordar : IAcao
{

}