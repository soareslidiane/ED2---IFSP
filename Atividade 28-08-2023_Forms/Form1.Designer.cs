
namespace Atividade21_10_01_Forms
{
    partial class Form_Agenda
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
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fone = new System.Windows.Forms.TextBox();
            this.label_Dia = new System.Windows.Forms.Label();
            this.textBox_Dia = new System.Windows.Forms.TextBox();
            this.label_Mes = new System.Windows.Forms.Label();
            this.textBox_Mes = new System.Windows.Forms.TextBox();
            this.label_Ano = new System.Windows.Forms.Label();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.button_Novo = new System.Windows.Forms.Button();
            this.button_Gravar = new System.Windows.Forms.Button();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.button_Pesquisa = new System.Windows.Forms.Button();
            this.button_Listar = new System.Windows.Forms.Button();
            this.listBox_Agenda = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(30, 10);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(42, 13);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "EMAIL:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(78, 7);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(200, 20);
            this.textBox_Email.TabIndex = 1;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(30, 45);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(42, 13);
            this.label_Nome.TabIndex = 2;
            this.label_Nome.Text = "NOME:";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(78, 42);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(200, 20);
            this.textBox_Nome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FONE:";
            // 
            // textBox_Fone
            // 
            this.textBox_Fone.Location = new System.Drawing.Point(78, 77);
            this.textBox_Fone.Name = "textBox_Fone";
            this.textBox_Fone.Size = new System.Drawing.Size(200, 20);
            this.textBox_Fone.TabIndex = 5;
            // 
            // label_Dia
            // 
            this.label_Dia.AutoSize = true;
            this.label_Dia.Location = new System.Drawing.Point(336, 10);
            this.label_Dia.Name = "label_Dia";
            this.label_Dia.Size = new System.Drawing.Size(28, 13);
            this.label_Dia.TabIndex = 6;
            this.label_Dia.Text = "DIA:";
            // 
            // textBox_Dia
            // 
            this.textBox_Dia.Location = new System.Drawing.Point(370, 7);
            this.textBox_Dia.Name = "textBox_Dia";
            this.textBox_Dia.Size = new System.Drawing.Size(50, 20);
            this.textBox_Dia.TabIndex = 7;
            // 
            // label_Mes
            // 
            this.label_Mes.AutoSize = true;
            this.label_Mes.Location = new System.Drawing.Point(336, 45);
            this.label_Mes.Name = "label_Mes";
            this.label_Mes.Size = new System.Drawing.Size(33, 13);
            this.label_Mes.TabIndex = 8;
            this.label_Mes.Text = "MÊS:";
            // 
            // textBox_Mes
            // 
            this.textBox_Mes.Location = new System.Drawing.Point(370, 42);
            this.textBox_Mes.Name = "textBox_Mes";
            this.textBox_Mes.Size = new System.Drawing.Size(50, 20);
            this.textBox_Mes.TabIndex = 9;
            // 
            // label_Ano
            // 
            this.label_Ano.AutoSize = true;
            this.label_Ano.Location = new System.Drawing.Point(336, 80);
            this.label_Ano.Name = "label_Ano";
            this.label_Ano.Size = new System.Drawing.Size(33, 13);
            this.label_Ano.TabIndex = 10;
            this.label_Ano.Text = "ANO:";
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Location = new System.Drawing.Point(370, 77);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(50, 20);
            this.textBox_Ano.TabIndex = 11;
            // 
            // button_Novo
            // 
            this.button_Novo.Location = new System.Drawing.Point(10, 125);
            this.button_Novo.Name = "button_Novo";
            this.button_Novo.Size = new System.Drawing.Size(75, 23);
            this.button_Novo.TabIndex = 12;
            this.button_Novo.Text = "NOVO";
            this.button_Novo.UseVisualStyleBackColor = true;
            this.button_Novo.Click += new System.EventHandler(this.button_Novo_Click);
            // 
            // button_Gravar
            // 
            this.button_Gravar.Location = new System.Drawing.Point(100, 125);
            this.button_Gravar.Name = "button_Gravar";
            this.button_Gravar.Size = new System.Drawing.Size(75, 23);
            this.button_Gravar.TabIndex = 13;
            this.button_Gravar.Text = "GRAVAR";
            this.button_Gravar.UseVisualStyleBackColor = true;
            // 
            // button_Excluir
            // 
            this.button_Excluir.Location = new System.Drawing.Point(190, 125);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(75, 23);
            this.button_Excluir.TabIndex = 14;
            this.button_Excluir.Text = "EXCLUIR";
            this.button_Excluir.UseVisualStyleBackColor = true;
            // 
            // button_Pesquisa
            // 
            this.button_Pesquisa.Location = new System.Drawing.Point(280, 125);
            this.button_Pesquisa.Name = "button_Pesquisa";
            this.button_Pesquisa.Size = new System.Drawing.Size(75, 23);
            this.button_Pesquisa.TabIndex = 15;
            this.button_Pesquisa.Text = "PESQUISA";
            this.button_Pesquisa.UseVisualStyleBackColor = true;
            // 
            // button_Listar
            // 
            this.button_Listar.Location = new System.Drawing.Point(370, 125);
            this.button_Listar.Name = "button_Listar";
            this.button_Listar.Size = new System.Drawing.Size(75, 23);
            this.button_Listar.TabIndex = 16;
            this.button_Listar.Text = "LISTAR";
            this.button_Listar.UseVisualStyleBackColor = true;
            this.button_Listar.Click += new System.EventHandler(this.button_Listar_Click);
            // 
            // listBox_Agenda
            // 
            this.listBox_Agenda.FormattingEnabled = true;
            this.listBox_Agenda.Location = new System.Drawing.Point(10, 170);
            this.listBox_Agenda.Name = "listBox_Agenda";
            this.listBox_Agenda.Size = new System.Drawing.Size(435, 95);
            this.listBox_Agenda.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox_Agenda);
            this.Controls.Add(this.button_Listar);
            this.Controls.Add(this.button_Pesquisa);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.button_Gravar);
            this.Controls.Add(this.button_Novo);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.label_Ano);
            this.Controls.Add(this.textBox_Mes);
            this.Controls.Add(this.label_Mes);
            this.Controls.Add(this.textBox_Dia);
            this.Controls.Add(this.label_Dia);
            this.Controls.Add(this.textBox_Fone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Name = "Form_Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Fone;
        private System.Windows.Forms.Label label_Dia;
        private System.Windows.Forms.TextBox textBox_Dia;
        private System.Windows.Forms.Label label_Mes;
        private System.Windows.Forms.TextBox textBox_Mes;
        private System.Windows.Forms.Label label_Ano;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.Button button_Novo;
        private System.Windows.Forms.Button button_Gravar;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.Button button_Pesquisa;
        private System.Windows.Forms.Button button_Listar;
        private System.Windows.Forms.ListBox listBox_Agenda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

