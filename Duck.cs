using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    public abstract class Duck : IDescrever, IAcao
    {
        public string Nome { get; set; }

        public abstract string Descrever();

        public virtual string Executar(string acao)
        {
            string resultado;

            switch (acao)
            {
                case "Quack":
                    resultado = Nome + " está fazendo quack!";
                    break;
                case "Voar":
                    resultado = Nome + " está voando!";
                    break;
                case "Nadar":
                    resultado = Nome + " está nadando!";
                    break;
                case "Dormir":
                    resultado = Nome + " está dormindo!";
                    break;
                case "Acordar":
                    resultado = Nome + " acordou!";
                    break;
                default:
                    resultado = Nome + " não fez nada.";
                    break;
            }

            return resultado;
        }

        public override string ToString()
        {
            return Nome;
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Nome = "Marreco";
        }
        public override string Descrever()
        {
            return "Este é o pato marreco!\nÉ uma ave aquática comum em várias partes do mundo.\nNome científico: Anas platyrhynchos.\nFamília: Anatidae.";
        }
    }
    public class RedheadDuck : Duck, IDescrever
    {
        public RedheadDuck()
        {
            Nome = "Zarro-americano";
        }
        public override string Descrever()
        {
            return "Este é o pato zarro-americano!\nEle é originário da América do Norte.\nSeu nome científico é: Aythya affinis, e ele faz parte da família Anatidae.";
        }
    }
    public class RubberDuck : Duck, IDescrever
    {
        public RubberDuck()
        {
            Nome = "Pato de Borracha";
        }
        public override string Descrever()
        {
            return "Este é o pato de borracha!\nO pato de borracha pode ser encontrado em qualquer lugar do mundo.";
        }
        public override string Executar(string acao)
        {

            if (acao == "Voar")
            {
                return Nome + " não pode voar! Ele é feito de borracha.";
            }
            if (acao == "Nadar")
            {
                return Nome + " está boiando.";
            }
            if (acao == "Dormir")
            {
                return Nome + " não dorme, ele é um brinquedo.";
            }

            if (acao == "Acordar")
            {
                return Nome + " não acorda, ele é um brinquedo";
            }

            return base.Executar(acao);
        }
    }
    public class MuscovyDuck : Duck, IDescrever
    {
        public MuscovyDuck()
        {
            Nome = "Pato do mato";
        }
        public override string Descrever()
        {
            return "Este é o pato do mato!\nO pato do mato é originário da América Latina, e é encontrado em maior número na América do Sul.\nSeu nome científico é: Cairina moschata e ele faz parte da família Anatidae.";
        }
    }
    public class HarlequinDuck : Duck, IDescrever
    {
        public HarlequinDuck()
        {
            Nome = "Pato-arlequim";
        }
        public override string Descrever()
        {
            return "Este é o pato-arlequim!\nEle está presente no noroeste dos Estados Unidos, no nordeste da Rússia, na Islândia e no sul da Groenlândia.\nSeu nome científico é: Histrionicus histrionicus e ele faz parte da família Anatidae.";
        }
    }
    public class TorrentDuck : Duck, IDescrever
    {
        public TorrentDuck()
        {
            Nome = "Pato-das-torrentes";
        }
        public override string Descrever()
        {
            return "Este é o pato-das-torrentes!\nEle é originário da América do Sul, na região dos Andes.\nSeu nome científico é: Merganetta armata, ele também faz parte da família Anatidae.";
        }
    }
}
