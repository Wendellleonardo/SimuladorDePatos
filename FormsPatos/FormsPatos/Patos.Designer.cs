namespace FormsPatos
{
    partial class Patos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPatos = new ComboBox();
            lblDescricao = new Label();
            comboBoxAcoes = new ComboBox();
            btnExecAcao = new Button();
            pictureBoxAnimacao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimacao).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPatos
            // 
            comboBoxPatos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatos.FormattingEnabled = true;
            comboBoxPatos.Location = new Point(405, 53);
            comboBoxPatos.Name = "comboBoxPatos";
            comboBoxPatos.Size = new Size(121, 23);
            comboBoxPatos.TabIndex = 0;
            comboBoxPatos.SelectedIndexChanged += comboBoxPatos_SelectedIndexChanged;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(105, 79);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(722, 50);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição do pato...";
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxAcoes
            // 
            comboBoxAcoes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAcoes.FormattingEnabled = true;
            comboBoxAcoes.Location = new Point(405, 163);
            comboBoxAcoes.Name = "comboBoxAcoes";
            comboBoxAcoes.Size = new Size(121, 23);
            comboBoxAcoes.TabIndex = 2;
            // 
            // btnExecAcao
            // 
            btnExecAcao.Location = new Point(418, 192);
            btnExecAcao.Name = "btnExecAcao";
            btnExecAcao.Size = new Size(95, 23);
            btnExecAcao.TabIndex = 3;
            btnExecAcao.Text = "Executar ação";
            btnExecAcao.UseVisualStyleBackColor = true;
            btnExecAcao.Click += buttonExecutar_Click;
            // 
            // pictureBoxAnimacao
            // 
            pictureBoxAnimacao.Location = new Point(318, 221);
            pictureBoxAnimacao.Name = "pictureBoxAnimacao";
            pictureBoxAnimacao.Size = new Size(300, 300);
            pictureBoxAnimacao.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxAnimacao.TabIndex = 4;
            pictureBoxAnimacao.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 569);
            Controls.Add(pictureBoxAnimacao);
            Controls.Add(btnExecAcao);
            Controls.Add(comboBoxAcoes);
            Controls.Add(lblDescricao);
            Controls.Add(comboBoxPatos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxPatos;
        private Label lblDescricao;
        private ComboBox comboBoxAcoes;
        private Button btnExecAcao;
        private PictureBox pictureBoxAnimacao;
    }
}
