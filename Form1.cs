using FormsPatos;

namespace FormDosPatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private List<Duck> patos = new List<Duck>();
        private DuckController controller = new DuckController();

        private void Form1_Load(object sender, EventArgs e)
        {
            patos = new List<Duck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new MuscovyDuck(),
                new HarlequinDuck(),
                new TorrentDuck()
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
                lblDescricao.Text = pato.Descrever();
            }
        }

        private void btnExecAcao_Click(object sender, EventArgs e)
        {
            string acao = comboBoxAcoes.SelectedItem?.ToString();
            if (acao == null)
            {
                MessageBox.Show("Selecione uma ação.");
                return;
            }

            if (comboBoxPatos.SelectedItem is Duck pato)
            {
                lblResultado.Text = controller.ExecutarAcao(pato, acao);

                string caminhoGif = controller.ObterCaminhoGif(pato, acao);

                if (caminhoGif != null && File.Exists(caminhoGif))
                {
                    pictureBoxAnimacao.Image = Image.FromFile(caminhoGif);
                }
                else
                {
                    pictureBoxAnimacao.Image = null;
                }
            }
        }

    }
}
