namespace BancoDeDadosLocal
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
            buttonCriarTabela = new Button();
            ButtonDeletarTabela = new Button();
            buttonInserirDados = new Button();
            SuspendLayout();
            // 
            // buttonCriarTabela
            // 
            buttonCriarTabela.Location = new Point(100, 83);
            buttonCriarTabela.Name = "buttonCriarTabela";
            buttonCriarTabela.Size = new Size(166, 29);
            buttonCriarTabela.TabIndex = 0;
            buttonCriarTabela.Text = "Criar Tabela";
            buttonCriarTabela.UseVisualStyleBackColor = true;
            buttonCriarTabela.Click += CriarTabela;
            // 
            // ButtonDeletarTabela
            // 
            ButtonDeletarTabela.Location = new Point(144, 161);
            ButtonDeletarTabela.Name = "ButtonDeletarTabela";
            ButtonDeletarTabela.Size = new Size(94, 29);
            ButtonDeletarTabela.TabIndex = 1;
            ButtonDeletarTabela.Text = "Deletar Tabela";
            ButtonDeletarTabela.UseVisualStyleBackColor = true;
            ButtonDeletarTabela.Click += DeletarTabela;
            // 
            // buttonInserirDados
            // 
            buttonInserirDados.Location = new Point(179, 258);
            buttonInserirDados.Name = "buttonInserirDados";
            buttonInserirDados.Size = new Size(161, 29);
            buttonInserirDados.TabIndex = 2;
            buttonInserirDados.Text = "Inserir Dados";
            buttonInserirDados.UseVisualStyleBackColor = true;
            buttonInserirDados.Click += InserirDados;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInserirDados);
            Controls.Add(ButtonDeletarTabela);
            Controls.Add(buttonCriarTabela);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCriarTabela;
        private Button ButtonDeletarTabela;
        private Button buttonInserirDados;
    }
}
