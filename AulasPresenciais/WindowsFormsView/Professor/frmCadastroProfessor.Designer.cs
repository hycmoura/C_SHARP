namespace WindowsFormsView.Professor
{
    partial class frmCadastroProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.textBoxNomeProfessor = new System.Windows.Forms.TextBox();
            this.lblmatriculaProfessor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEspecializacao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Location = new System.Drawing.Point(50, 39);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(38, 13);
            this.lblNomeProfessor.TabIndex = 0;
            this.lblNomeProfessor.Text = "Nome:";
            // 
            // textBoxNomeProfessor
            // 
            this.textBoxNomeProfessor.Location = new System.Drawing.Point(103, 32);
            this.textBoxNomeProfessor.Name = "textBoxNomeProfessor";
            this.textBoxNomeProfessor.Size = new System.Drawing.Size(196, 20);
            this.textBoxNomeProfessor.TabIndex = 1;
            // 
            // lblmatriculaProfessor
            // 
            this.lblmatriculaProfessor.AutoSize = true;
            this.lblmatriculaProfessor.Location = new System.Drawing.Point(32, 65);
            this.lblmatriculaProfessor.Name = "lblmatriculaProfessor";
            this.lblmatriculaProfessor.Size = new System.Drawing.Size(56, 13);
            this.lblmatriculaProfessor.TabIndex = 2;
            this.lblmatriculaProfessor.Text = "Matricula: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Especialização:";
            // 
            // textBoxEspecializacao
            // 
            this.textBoxEspecializacao.Location = new System.Drawing.Point(103, 84);
            this.textBoxEspecializacao.Name = "textBoxEspecializacao";
            this.textBoxEspecializacao.Size = new System.Drawing.Size(196, 20);
            this.textBoxEspecializacao.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(143, 128);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 179);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBoxEspecializacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblmatriculaProfessor);
            this.Controls.Add(this.textBoxNomeProfessor);
            this.Controls.Add(this.lblNomeProfessor);
            this.Name = "frmCadastroProfessor";
            this.Text = "frmCadastroProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.TextBox textBoxNomeProfessor;
        private System.Windows.Forms.Label lblmatriculaProfessor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEspecializacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}