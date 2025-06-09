using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FormsPatos;

namespace FormsPatos
{
    public abstract class Duck : IDescrever, IAcao
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }

        public IQuack FazendoQuack { get; set; }
        public IVoar Voando { get; set; }
        public INadar Nadando { get; set; }
        public IDormir Dormindo { get; set; }
        public IAcordar Acordando { get; set; }
        public IVoar NaoConsegueVoar { get; set; }
        public INadar Boiando { get; set; }
        public IDormir NaoConsegueDormir { get; set; }
        public IAcordar NaoConsegueAcordar { get; set; }

        public abstract string Descrever();

        public virtual string Executar(string acao)
        {
            switch (acao)
            {
                case "Quack":
                    if (FazendoQuack != null)
                        return FazendoQuack.Quack(Nome);
                    else
                        return $"{Nome} não emite som.";

                case "Voar":
                    if (Voando != null)
                        return Voando.Voar(Nome);
                    else
                        return $"{Nome} não sabe voar.";

                case "Nadar":
                    if (Nadando != null)
                        return Nadando.Nadar(Nome);
                    else
                        return $"{Nome} não nada.";

                case "Dormir":
                    if (Dormindo != null)
                        return Dormindo.Dormir(Nome);
                    else
                        return $"{Nome} não dorme.";

                case "Acordar":
                    if (Acordando != null)
                        return Acordando.Acordar(Nome);
                    else
                        return $"{Nome} não acorda.";

                default:
                    return $"{Nome} não fez nada.";
            }
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Nome = "Marreco";
            FazendoQuack = new FazerQuack();
            Voando = new PatoVoar();
            Nadando = new PatoNadar();
            Dormindo = new PatoDormir();
            Acordando = new PatoAcordar();
        }
        public override string Descrever()
        {
            return "Este é o pato marreco!\nÉ uma ave aquática comum em várias partes do mundo.\nNome científico: Anas platyrhynchos.\nFamília: Anatidae.";
        }
    }
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            Nome = "Zarro-americano";
            FazendoQuack = new FazerQuack();
            Voando = new PatoVoar();
            Nadando = new PatoNadar();
            Dormindo = new PatoDormir();
            Acordando = new PatoAcordar();
        }
        public override string Descrever()
        {
            return "Este é o pato zarro-americano!\nEle é originário da América do Norte.\nSeu nome científico é: Aythya affinis, e ele faz parte da família Anatidae.";
        }
    }
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Nome = "Pato de Borracha";
            FazendoQuack = new FazerQuack();
            NaoConsegueVoar = new PatoVoar();
            Boiando = new PatoNadar();
            NaoConsegueDormir = new PatoDormir();
            NaoConsegueAcordar = new PatoAcordar();
        }
        public override string Descrever()
        {
            return "Este é o pato de borracha!\nO pato de borracha pode ser encontrado em qualquer lugar do mundo.";
        }
    }
    public class MuscovyDuck : Duck
    {
        public MuscovyDuck()
        {
            Nome = "Pato do mato";
            FazendoQuack = new FazerQuack();
            Voando = new PatoVoar();
            Nadando = new PatoNadar();
            Dormindo = new PatoDormir();
            Acordando = new PatoAcordar();
        }
        public override string Descrever()
        {
            return "Este é o pato do mato!\nO pato do mato é originário da América Latina, e é encontrado em maior número na América do Sul.\nSeu nome científico é: Cairina moschata e ele faz parte da família Anatidae.";
        }
    }
    public class HarlequinDuck : Duck
    {
        public HarlequinDuck()
        {
            Nome = "Pato-arlequim";
            FazendoQuack = new FazerQuack();
            Voando = new PatoVoar();
            Nadando = new PatoNadar();
            Dormindo = new PatoDormir();
            Acordando = new PatoAcordar();
        }
        public override string Descrever()
        {
            return "Este é o pato-arlequim!\nEle está presente no noroeste dos Estados Unidos, no nordeste da Rússia, na Islândia e no sul da Groenlândia.\nSeu nome científico é: Histrionicus histrionicus e ele faz parte da família Anatidae.";
        }
    }
    public class TorrentDuck : Duck
    {
        public TorrentDuck()
        {
            Nome = "Pato-das-torrentes";
            FazendoQuack = new FazerQuack();
            Voando = new PatoVoar();
            Nadando = new PatoNadar();
            Dormindo = new PatoDormir();
            Acordando = new PatoAcordar();
        }
        public override string Descrever()
        {
            return "Este é o pato-das-torrentes!\nEle é originário da América do Sul, na região dos Andes.\nSeu nome científico é: Merganetta armata, ele também faz parte da família Anatidae.";
        }
    }
}
