namespace FormDosPatos
{
    partial class Form1
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
            pictureBoxAnimacao = new PictureBox();
            btnExecAcao = new Button();
            comboBoxAcoes = new ComboBox();
            lblDescricao = new Label();
            comboBoxPatos = new ComboBox();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimacao).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAnimacao
            // 
            pictureBoxAnimacao.Location = new Point(403, 301);
            pictureBoxAnimacao.Name = "pictureBoxAnimacao";
            pictureBoxAnimacao.Size = new Size(300, 300);
            pictureBoxAnimacao.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxAnimacao.TabIndex = 9;
            pictureBoxAnimacao.TabStop = false;
            // 
            // btnExecAcao
            // 
            btnExecAcao.Location = new Point(504, 222);
            btnExecAcao.Name = "btnExecAcao";
            btnExecAcao.Size = new Size(95, 23);
            btnExecAcao.TabIndex = 8;
            btnExecAcao.Text = "Executar ação";
            btnExecAcao.UseVisualStyleBackColor = true;
            btnExecAcao.Click += btnExecAcao_Click;
            // 
            // comboBoxAcoes
            // 
            comboBoxAcoes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAcoes.FormattingEnabled = true;
            comboBoxAcoes.Location = new Point(491, 193);
            comboBoxAcoes.Name = "comboBoxAcoes";
            comboBoxAcoes.Size = new Size(121, 23);
            comboBoxAcoes.TabIndex = 7;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(191, 98);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(722, 80);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição do pato...";
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxPatos
            // 
            comboBoxPatos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatos.FormattingEnabled = true;
            comboBoxPatos.Location = new Point(491, 72);
            comboBoxPatos.Name = "comboBoxPatos";
            comboBoxPatos.Size = new Size(121, 23);
            comboBoxPatos.TabIndex = 5;
            comboBoxPatos.SelectedIndexChanged += comboBoxPatos_SelectedIndexChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(488, 283);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 613);
            Controls.Add(lblResultado);
            Controls.Add(pictureBoxAnimacao);
            Controls.Add(btnExecAcao);
            Controls.Add(comboBoxAcoes);
            Controls.Add(lblDescricao);
            Controls.Add(comboBoxPatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAnimacao;
        private Button btnExecAcao;
        private ComboBox comboBoxAcoes;
        private Label lblDescricao;
        private ComboBox comboBoxPatos;
        private Label lblResultado;
    }
}
