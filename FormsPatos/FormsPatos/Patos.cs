using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FormsPatos
{
    public partial class Patos : Form
    {
        private List<Duck> patos;
        public Patos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            patos = new List<Duck>
            {
                new Duck { Nome = "Marreco", Descricao = "Este é o pato marreco!\nEle é originário da região paleoártica.\nSeu nome científico é: Spatula querquedula e ele faz parte da família Anatidae." },
                new Duck { Nome = "Pato zarro-americano", Descricao = "Este é o pato zarro-americano!\nEle é originário da América do Norte.\nSeu nome científico é: Aythya affinis, e ele faz parte da família Anatidae." },
                new Duck { Nome = "Pato de borracha", Descricao = "Este é o pato de borracha!\nO pato de borracha pode ser encontrado em qualquer lugar do mundo." },
                new Duck { Nome = "Pato do mato", Descricao = "Este é o pato do mato!\nO pato do mato é originário da América Latina, e é encontrado em maior número na América do Sul.\nSeu nome científico é: Cairina moschata e ele faz parte da família Anatidae." },
                new Duck { Nome = "Pato arlequim", Descricao = "Este é o pato arlequim!\nEle está presente no noroeste dos Estados Unidos, no nordeste da Rússia, na Islândia e no sul da Groenlândia.\nSeu nome científico é: Histrionicus histrionicus e ele faz parte da família Anatidae. " },
                new Duck { Nome = "Pato-das-torrentes", Descricao = "Este é o pato-das-torrentes!\nEle é originário da América do Sul, na região dos Andes.\nSeu nome científico é: Merganetta armata, ele também faz parte da família Anatidae." }
            };

            comboBoxPatos.DataSource = patos;

            comboBoxAcoes.Items.AddRange(new string[]
            {
                "Quack", "Voar", "Nadar", "Dormir", "Acordar"
            });
        }

        private void comboBoxPatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatos.SelectedItem is Duck pato)
            {
                lblDescricao.Text = pato.Descricao;
            }
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            string acao = comboBoxAcoes.SelectedItem?.ToString();
            if (acao == null)
            {
                MessageBox.Show("Selecione uma ação.");
                return;
            }

            switch (acao)
            {
                case "Quack":
                    pictureBoxAnimacao.Image = Image.FromFile("Gifs/quack.gif");
                    break;
                case "Voar":
                    pictureBoxAnimacao.Image = Image.FromFile("Gifs/fly.gif");
                    break;
                case "Nadar":
                    pictureBoxAnimacao.Image = Image.FromFile("Gifs/swim.gif");
                    break;
                case "Dormir":
                    pictureBoxAnimacao.Image = Image.FromFile("Gifs/sleep.gif");
                    break;
                case "Acordar":
                    pictureBoxAnimacao.Image = Image.FromFile("Gifs/wakeup.gif");
                    break;
            }
        }
    }
}
