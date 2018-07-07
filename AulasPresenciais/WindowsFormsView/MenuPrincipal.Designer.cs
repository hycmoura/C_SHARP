namespace WindowsFormsView
{
    partial class MenuPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.groupBoxProfessor = new System.Windows.Forms.GroupBox();
            this.btnListarProfessor = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.groupBoxDiciplina = new System.Windows.Forms.GroupBox();
            this.btnCadastarDiciplina = new System.Windows.Forms.Button();
            this.btnListarDiciplina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxProfessor.SuspendLayout();
            this.groupBoxDiciplina.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarAluno);
            this.groupBox1.Controls.Add(this.btnCadastrarAluno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // btnListarAluno
            // 
            this.btnListarAluno.Location = new System.Drawing.Point(7, 50);
            this.btnListarAluno.Name = "btnListarAluno";
            this.btnListarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnListarAluno.TabIndex = 1;
            this.btnListarAluno.Text = "Listar";
            this.btnListarAluno.UseVisualStyleBackColor = true;
            this.btnListarAluno.Click += new System.EventHandler(this.btnListarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 0;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // groupBoxProfessor
            // 
            this.groupBoxProfessor.Controls.Add(this.btnListarProfessor);
            this.groupBoxProfessor.Controls.Add(this.btnCadastrarProfessor);
            this.groupBoxProfessor.Location = new System.Drawing.Point(137, 14);
            this.groupBoxProfessor.Name = "groupBoxProfessor";
            this.groupBoxProfessor.Size = new System.Drawing.Size(99, 89);
            this.groupBoxProfessor.TabIndex = 1;
            this.groupBoxProfessor.TabStop = false;
            this.groupBoxProfessor.Text = "Professor";
            // 
            // btnListarProfessor
            // 
            this.btnListarProfessor.Location = new System.Drawing.Point(7, 48);
            this.btnListarProfessor.Name = "btnListarProfessor";
            this.btnListarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnListarProfessor.TabIndex = 1;
            this.btnListarProfessor.Text = "Listar";
            this.btnListarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(7, 20);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarProfessor.TabIndex = 0;
            this.btnCadastrarProfessor.Text = "Cadastrar";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // groupBoxDiciplina
            // 
            this.groupBoxDiciplina.Controls.Add(this.btnListarDiciplina);
            this.groupBoxDiciplina.Controls.Add(this.btnCadastarDiciplina);
            this.groupBoxDiciplina.Location = new System.Drawing.Point(262, 14);
            this.groupBoxDiciplina.Name = "groupBoxDiciplina";
            this.groupBoxDiciplina.Size = new System.Drawing.Size(91, 89);
            this.groupBoxDiciplina.TabIndex = 2;
            this.groupBoxDiciplina.TabStop = false;
            this.groupBoxDiciplina.Text = "Diciplina";
            // 
            // btnCadastarDiciplina
            // 
            this.btnCadastarDiciplina.Location = new System.Drawing.Point(7, 18);
            this.btnCadastarDiciplina.Name = "btnCadastarDiciplina";
            this.btnCadastarDiciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCadastarDiciplina.TabIndex = 0;
            this.btnCadastarDiciplina.Text = "Cadastrar";
            this.btnCadastarDiciplina.UseVisualStyleBackColor = true;
            // 
            // btnListarDiciplina
            // 
            this.btnListarDiciplina.Location = new System.Drawing.Point(7, 48);
            this.btnListarDiciplina.Name = "btnListarDiciplina";
            this.btnListarDiciplina.Size = new System.Drawing.Size(75, 23);
            this.btnListarDiciplina.TabIndex = 1;
            this.btnListarDiciplina.Text = "Listar";
            this.btnListarDiciplina.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 117);
            this.Controls.Add(this.groupBoxDiciplina);
            this.Controls.Add(this.groupBoxProfessor);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxProfessor.ResumeLayout(false);
            this.groupBoxDiciplina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.GroupBox groupBoxProfessor;
        private System.Windows.Forms.Button btnListarProfessor;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.GroupBox groupBoxDiciplina;
        private System.Windows.Forms.Button btnListarDiciplina;
        private System.Windows.Forms.Button btnCadastarDiciplina;
    }
}