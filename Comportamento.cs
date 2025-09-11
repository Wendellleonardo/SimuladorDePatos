using FormsPatos;

namespace FormsPatos
{
    public class FazerQuack : IQuack
    {
        public string Quack(string nome)
        {
            return $"{nome} fez quack quack!";
        }
    }

    public class PatoVoar : IVoar
    {
        public string Voar(string nome)
        {
            return $"{nome} está voando!";
        }
    }

    public class PatoNadar : INadar
    {
        public string Nadar(string nome)
        {
            return $"{nome} está nadando!";
        }
    }

    public class PatoDormir : IDormir
    {
        public string Dormir(string nome)
        {
            return $"{nome} está dormindo...";
        }
    }

    public class PatoAcordar : IAcordar
    {
        public string Acordar(string nome)
        {
            return $"{nome} está acordando...";
        }
    }

    public class NaoVoa : IVoar
    {
        public string Voar(string nome)
        {
            return $"{nome} não consegue voar!";
        }
    }

    public class Boiar : INadar
    {
        public string Nadar(string nome)
        {
            return $"{nome} está boiando...";
        }
    }

    public class NaoDorme : IDormir
    {
        public string Dormir(string nome)
        {
            return $"{nome} não dorme, ele é um brinquedo!";
        }
    }

    public class NaoAcorda : IAcordar
    {
        public string Acordar(string nome)
        {
            return $"{nome} não acorda, ele é um brinquedo!";
        }
    }
}